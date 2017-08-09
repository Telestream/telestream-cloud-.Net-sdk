using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Telestream.Cloud.SDK.Core;
using Telestream.Cloud.SDK.Model;

namespace Telestream.Cloud.SDK
{
    public class FactoryService : ServiceBase
    {
        private TelestreamCloudService _cloudService;
        private FileUploader _fileUploader = new FileUploader();

        public FactoryService(string factoryId)
            : base()
        {
            Initialize(factoryId);
        }

        public FactoryService(ApiAccess apiAccess, string factoryId)
            : base(apiAccess)
        {
            Initialize(factoryId);
        }

        public FactoryService(IConfigurationService configuration, string factoryId)
            : base(configuration)
        {
            Initialize(factoryId);
        }

        public FactoryService(ApiAccess apiAccess, Factory factory)
            : base(apiAccess)
        {
            if (factory == null) { throw new ArgumentNullException("factory"); }

            Initialize(factory.Id);
        }

        public string FactoryId { get; private set; }

        private void Initialize(string factoryId)
        {
            _cloudService = new TelestreamCloudService(_apiAccess);

            ValidateId("factoryId", factoryId);
            FactoryId = factoryId;
        }


        public Task DeleteVideo(string videoId)
        {
            return _cloudService.DeleteVideo(FactoryId, videoId);
        }

        public Task DeleteVideoSource(string videoId)
        {
            return _cloudService.DeleteVideoSource(FactoryId, videoId);
        }

        public Task DeleteEncoding(string encodingId)
        {
            return _cloudService.DeleteEncoding(FactoryId, encodingId);
        }

        public Task DeleteProfile(string profileId)
        {
            return _cloudService.DeleteProfile(FactoryId, profileId);
        }

        public Task<List<Video>> GetVideos()
        {
            return _cloudService.GetVideos(FactoryId);
        }

        public Task<Video> GetVideo(string videoId, bool fetchEncodings = false)
        {
            return _cloudService.GetVideo(FactoryId, videoId, fetchEncodings);
        }

        public Task<List<VideoEncoding>> GetEncodings(EncodingStatus status = null, string profileId = null, string profileName = null, string videoId = null, bool? screenshots = null, int? page = null, int? perPage = null)
        {
            return _cloudService.GetEncodings(FactoryId, status, profileId, profileName, videoId, screenshots, page, perPage);
        }

        public Task<List<VideoEncoding>> GetEncodings(string videoId)
        {
            return _cloudService.GetEncodings(FactoryId, videoId);
        }

        public Task<VideoEncoding> GetEncoding(string encodingId, bool? screenshots = null)
        {
            return _cloudService.GetEncoding(FactoryId, encodingId, screenshots);
        }

        public Task<VideoEncoding> CreateEncoding(string videoId, string profileId, string profileName)
        {
            return _cloudService.CreateEncoding(FactoryId, videoId, profileId, profileName);
        }

        public Task<VideoEncoding> CancelEncoding(string encodingId)
        {
            return _cloudService.CancelEncoding(FactoryId, encodingId);
        }

        public Task<VideoEncoding> RetryEncoding(string encodingId)
        {
            return _cloudService.RetryEncoding(FactoryId, encodingId);
        }

        public Task<List<VideoProfile>> GetProfiles(bool? expand = null, int? page = null, int? perPage = null)
        {
            return _cloudService.GetProfiles(FactoryId, expand, page, perPage);
        }

        public Task<VideoProfile> GetProfile(string idOrName, bool? expand = null)
        {
            return _cloudService.GetProfile(FactoryId, idOrName, expand);
        }

        public Task<VideoProfile> CreateProfile(VideoProfile profile)
        {
            return _cloudService.CreateProfile(FactoryId, profile);
        }

        public Task<VideoProfile> UpdateProfile(VideoProfile profile)
        {
            return _cloudService.UpdateProfile(FactoryId, profile);
        }

        public Task<VideoMetadata> Metadata(string factoryId, string videoId)
        {
            return _cloudService.Metadata(FactoryId, videoId);
        }

        public Task<Factory> ChangeFactoryName(string factoryId, string newName)
        {
            return _cloudService.ChangeFactoryName(FactoryId, newName);
        }

        public Task<Factory> ChangeFactoryOutputsPathFormat(string factoryId, string newOutputsPathFormat)
        {
            return _cloudService.ChangeFactoryOutputsPathFormat(FactoryId, newOutputsPathFormat);
        }

        public Task<FileUploader> InitFileUploader(string fileName, Stream dataStream, CancellationToken cancelToken = default(CancellationToken))
        {
            return InitFileUploader(fileName, dataStream, null, cancelToken);
        }

        public async Task<FileUploader> InitFileUploader(string fileName, Stream dataStream, IProgress<double> progress, CancellationToken cancelToken = default(CancellationToken))
        {
            return await FileUploader.Init(_client, _requestFactory, FactoryId, dataStream, fileName, cancelToken);
        }

        public Task<UploadSession> BeginUpload(string fileName, Stream dataStream, CancellationToken cancelToken = default(CancellationToken))
        {
            return BeginUpload(fileName, dataStream, null, null, null, cancelToken);
        }

        public Task<UploadSession> BeginUpload(string fileName, Stream dataStream, string pathFormat,
                                               Dictionary<string, string> extraVars, string profiles,
                                               CancellationToken cancelToken = default(CancellationToken))
        {
            return _cloudService.StartUpload(FactoryId, dataStream.Length, fileName, pathFormat, extraVars, profiles, cancelToken);
        }
        public Task UploadFile(string fileName, Stream dataStream, CancellationToken cancelToken = default(CancellationToken))
        {
            return UploadFile(fileName, dataStream, null, null, null, null, cancelToken);
        }

        public async Task UploadFile(string fileName, Stream dataStream, string pathFormat,
                               Dictionary<string, string> extraVars, string profiles = null,
                               IProgress<double> progress = null,
                               CancellationToken cancelToken = default(CancellationToken))
        {
            var session = await BeginUpload(fileName, dataStream, pathFormat, extraVars, profiles, cancelToken);
            await _fileUploader.UploadFile(session, dataStream, progress, cancelToken);
        }
    }
}
