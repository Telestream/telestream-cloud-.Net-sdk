using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telestream.Cloud.SDK.Core;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Telestream.Cloud.SDK.Model;
using System.IO;
using System.Net.Http;
using System.Threading;
namespace Telestream.Cloud.SDK
{
	public class TelestreamCloudService : ServiceBase
	{
		public TelestreamCloudService()
			: this(TelestreamCloudConfig.Credentials)
		{

		}

		public TelestreamCloudService(ApiAccess apiAccess)
			: base(apiAccess)
		{
		}

		public TelestreamCloudService(IConfigurationService configuration)
			: base(configuration)
		{
		}

		public Task<List<Factory>> GetFactories()
		{
			var request = _requestFactory.Get("factories.json");
			return _client.Invoke<List<Factory>>(request);
		}

		public Task DeleteVideo(string factoryId, string videoId)
		{
			return InvokeDelete(factoryId, string.Format("videos/{0}.json", videoId));
		}

		public Task DeleteVideoSource(string factoryId, string videoId)
		{
			return InvokeDelete(factoryId, string.Format("videos/{0}/source.json", videoId));
		}

		public Task DeleteEncoding(string factoryId, string encodingId)
		{
			ValidateId("encodingId", encodingId);

			return InvokeDelete(factoryId, string.Format("encodings/{0}.json", encodingId));
		}

		public Task DeleteProfile(string factoryId, string profileId)
		{
			ValidateId("profileId", profileId);

			return InvokeDelete(factoryId, string.Format("profiles/{0}.json", profileId));
		}

        public Task<Video> CreateVideo(string factoryId, string url, string[] profiles)
        {
            return InvokePost<Video>(
                 factoryId,
                "videos.json",
              QueryParamList.New()
              .AddNonEmpty("profiles", String.Join(",", profiles))
              .AddNonEmpty("source_url", url)
             );
        }

        public Task<Video> CreateVideo(string factoryId, Video video)
        {
            return InvokePost<Video>(factoryId, "videos.json", video);
        }

        public Task<List<Video>> GetVideos(string factoryId)
		{
			ValidateFactoryId(factoryId);

			return InvokeGet<List<Video>>(factoryId, "videos.json");
		}

		public async Task<Video> GetVideo(string factoryId, string videoId, bool fetchEncodings = false)
		{
			ValidateVideoId(videoId);

			var video = await InvokeGet<Video>(
						factoryId,
						string.Format("videos/{0}.json", videoId));

			if (fetchEncodings)
			{
				var encodings = await GetEncodings(factoryId, video.Id);
				video.Encodings = encodings;
			}

			return video;
		}

		public Task<List<VideoEncoding>> GetEncodings(string factoryId, EncodingStatus status = null, string profileId = null, string profileName = null, string videoId = null, bool? screenshots = null, int? page = null, int? perPage = null)
		{
			return InvokeGet<List<VideoEncoding>>(
					factoryId,
					"encodings.json",
					QueryParamList.New()
						.AddNonEmpty("status", status)
						.AddNonEmpty("profile_id", profileId)
						.AddNonEmpty("profile_name", profileName)
						.AddNonEmpty("video_id", videoId)
						.AddNonEmpty("screenshots", screenshots)
						.AddNonEmpty("page", page)
						.AddNonEmpty("per_page", perPage));
		}

		public Task<List<VideoEncoding>> GetEncodings(string factoryId, string videoId)
		{
			ValidateVideoId(videoId);

			return InvokeGet<List<VideoEncoding>>(
					factoryId,
					string.Format("videos/{0}/encodings.json", videoId));
		}

		public Task<VideoEncoding> GetEncoding(string factoryId, string encodingId, bool? screenshots = null)
		{
			ValidateId("encodingId", encodingId);

			return InvokeGet<VideoEncoding>(
				factoryId,
				string.Format("encodings/{0}.json", encodingId),
				QueryParamList.New()
					.AddNonEmpty("screenshots", screenshots));
		}

		public Task<VideoEncoding> CreateEncoding(string factoryId, string videoId, string profileId, string profileName)
		{
			ValidateId("videoId", videoId);

			return InvokePost<VideoEncoding>(
				factoryId,
				"encodings.json",
				QueryParamList.New()
				.AddNonEmpty("video_id", videoId)
				.AddNonEmpty("profile_id", profileId)
				.AddNonEmpty("profileName", profileName));
		}

		public Task<VideoEncoding> CancelEncoding(string factoryId, string encodingId)
		{
			ValidateId("encodingId", encodingId);

			return InvokePost<VideoEncoding>(
				factoryId,
				string.Format("encodings/{0}/cancel.json", encodingId),
				null);
		}

		public Task<VideoEncoding> RetryEncoding(string factoryId, string encodingId)
		{
			ValidateId("encodingId", encodingId);

			return InvokePost<VideoEncoding>(
				factoryId,
				string.Format("encodings/{0}/retry.json", encodingId),
				null);
		}

		public Task<List<VideoProfile>> GetProfiles(string factoryId, bool? expand = null, int? page = null, int? perPage = null)
		{
			return InvokeGet<List<VideoProfile>>(
				factoryId,
				"profiles.json",
				QueryParamList.New()
					.AddNonEmpty("expand", expand)
					.AddNonEmpty("page", page)
					.AddNonEmpty("per_page", perPage));
		}

		public Task<VideoProfile> GetProfile(string factoryId, string idOrName, bool? expand = null)
		{
			ValidateId("idOrName", idOrName);

			return InvokeGet<VideoProfile>(
				factoryId,
				string.Format("profiles/{0}.json", idOrName),
				QueryParamList.New().AddNonEmpty("expand", expand));
		}

		public Task<VideoProfile> CreateProfile(string factoryId, VideoProfile profile)
		{
			if (profile == null) { throw new ArgumentNullException("profile"); }

			return InvokePost<VideoProfile>(factoryId, "profiles.json", profile);
		}

		public Task<VideoProfile> UpdateProfile(string factoryId, VideoProfile profile)
		{
			if (profile == null) { throw new ArgumentNullException("profile"); }

			return InvokePut<VideoProfile>(factoryId, string.Format("profiles/{0}.json", profile.Id), profile);

		}

		public Task<VideoMetadata> Metadata(string factoryId, string videoId)
		{
			ValidateVideoId(videoId);

			return InvokeGet<VideoMetadata>(factoryId, string.Format("videos/{0}/metadata.json", videoId));
		}

		public Task<Factory> ChangeFactoryName(string factoryId, string newName)
		{
			ValidateFactoryId(factoryId);
			var request = _requestFactory.PutJson(string.Format("factories/{0}.json", factoryId), new { name = newName }, null);
			return _client.Invoke<Factory>(request);
		}

		public Task<Factory> ChangeFactoryOutputsPathFormat(string factoryId, string newOutputsPathFormat)
		{
			ValidateFactoryId(factoryId);
			var request = _requestFactory.PutJson(string.Format("factories/{0}.json", factoryId), new { outputs_path_format = newOutputsPathFormat }, null);
			return _client.Invoke<Factory>(request);
		}
    public Task<UploadSession> StartUpload(string factoryId, long fileSize, string fileName, CancellationToken cancelToken = default(CancellationToken))
               {
                       return StartUpload(factoryId, fileSize, fileName, null, null, null, cancelToken);
               }

               public Task<UploadSession> StartUpload(string factoryId, long fileSize, string fileName, string pathFormat,
                                                      Dictionary<string, string> extraVars, string profiles = null,
                                                      CancellationToken cancelToken = default(CancellationToken))
               {
                       var data = new Dictionary<string, object>();
                       data["file_name"] = fileName;
                       data["file_size"] = fileSize;
                       data["multi_chunk"] = true;
                       data["path_format"] = pathFormat;
                       data["extra_variables"] = extraVars;
                       data["profiles"] = profiles;

                       var request = _requestFactory.Post(
                               "videos/upload.json",
                               data, factoryId);

                       return _client.Invoke<UploadSession>(request, cancelToken);
               }
        }               
}
