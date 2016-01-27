using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telestream.Cloud.SDK.Core;
using Telestream.Cloud.SDK.Model;

namespace Telestream.Cloud.SDK
{
	public class FactoryService : ServiceBase
	{
		private TelestreamCloudService _cloudService;

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
	}
}
