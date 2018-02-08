using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Telestream.Cloud.Flip.Api
{
	public class FileUploader : FileUploaderBase
	{
		public FileUploader(FlipApi apiClient) : base(apiClient)
		{

		}

		public async Task UploadFile(string filePath, string contextId, List<ExtraFileMetadata> extraFiles = default(List<ExtraFileMetadata>), string profiles = default(string), string pathFormat = default(string), string payload = default(string), Dictionary<string, string> extraVariables = default(Dictionary<string, string>), string watermarkUrl = default(string), string watermarkLeft = default(string), string watermarkTop = default(string), string watermarkRight = default(string), string watermarkBottom = default(string), string watermarkWidth = default(string), string watermarkHeight = default(string), string clipLength = default(string), string clipOffset = default(string))
		{
			var fileName = Path.GetFileName(filePath);
			var fileInfo = new FileInfo(filePath);
			var extraFilesData = PrepareExtraFiles(extraFiles);
			var videoSession = await PrepareMainFile(filePath,
													 contextId,
													 extraFilesData == null ? null : extraFilesData.ToExtraFileList(),
													 profiles,
													 pathFormat,
													 payload,
													 extraVariables,
													 watermarkUrl,
													 watermarkLeft,
													 watermarkTop,
													 watermarkRight,
													 watermarkBottom,
													 watermarkWidth,
													 watermarkHeight,
													 clipLength,
													 clipOffset);
			await UploadFile(filePath, videoSession, extraFilesData);

		}

		private Task<UploadSession> PrepareMainFile(string filePath, string contextId, List<ExtraFile> extraFiles = default(List<ExtraFile>), string profiles = default(string), string pathFormat = default(string), string payload = default(string), Dictionary<string, string> extraVariables = default(Dictionary<string, string>), string watermarkUrl = default(string), string watermarkLeft = default(string), string watermarkTop = default(string), string watermarkRight = default(string), string watermarkBottom = default(string), string watermarkWidth = default(string), string watermarkHeight = default(string), string clipLength = default(string), string clipOffset = default(string))
		{
			var fileInfo = new FileInfo(filePath);
			var uploadBody = new VideoUploadBody(fileInfo.Length,
												 fileInfo.Name,
												 extraFiles,
												 profiles,
												 pathFormat,
												 payload,
												 extraVariables,
												 watermarkUrl,
												 watermarkLeft,
												 watermarkTop,
												 watermarkRight,
												 watermarkBottom,
												 watermarkWidth,
												 watermarkHeight,
												 clipLength,
												 clipOffset,
												 true);

			return _apiClient.UploadVideoAsync(contextId, uploadBody);
		}
	}
}
