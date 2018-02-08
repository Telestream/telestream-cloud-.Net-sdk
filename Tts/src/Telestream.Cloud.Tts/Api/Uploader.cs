using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Telestream.Cloud.Tts.Api
{
	public class FileUploader : FileUploaderBase
	{
		public FileUploader(TtsApi apiClient) : base(apiClient)
		{

		}

		public async Task UploadFile(string filePath, string contextId, List<ExtraFileMetadata> extraFiles = default(List<ExtraFileMetadata>), string profiles = default(string))
		{
			var fileName = Path.GetFileName(filePath);
			var fileInfo = new FileInfo(filePath);
			var extraFilesData = PrepareExtraFiles(extraFiles);
			var videoSession = await PrepareMainFile(filePath,
													 contextId,
													 extraFilesData == null ? null : extraFilesData.ToExtraFileList(),
													 profiles);
			await UploadFile(filePath, videoSession, extraFilesData);

		}

		private Task<UploadSession> PrepareMainFile(string filePath, string contextId, List<ExtraFile> extraFiles = default(List<ExtraFile>), string profiles = default(string))
		{
			var fileInfo = new FileInfo(filePath);
			var uploadBody = new VideoUploadBody(fileInfo.Length,
												 fileInfo.Name,
												 profiles,
												 true,
												 extraFiles);

			return _apiClient.UploadVideoAsync(contextId, uploadBody);
		}
	}
}
