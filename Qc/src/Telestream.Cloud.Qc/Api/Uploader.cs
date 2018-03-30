using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using Telestream.Cloud.Qc.Client;
using Telestream.Cloud.Qc.Model;

namespace Telestream.Cloud.Qc.Api
{
        public class FileUploader : FileUploaderBase
        {
                public FileUploader(QcApi apiClient) : base(apiClient)
                {

                }

                public async Task UploadFile(string filePath, string contextId, IProgress<double> progress = null, CancellationToken cancelToken = default(CancellationToken), List<ExtraFileMetadata> extraFiles = default(List<ExtraFileMetadata>), string profiles = default(string))
                {
                        var fileName = Path.GetFileName(filePath);
                        var fileInfo = new FileInfo(filePath);
                        var extraFilesData = PrepareExtraFiles(extraFiles);
                        var videoSession = await PrepareMainFile(filePath,
                                                                                                         contextId,
                                                                                                         extraFilesData == null ? null : extraFilesData.ToExtraFileList(),
                                                                                                         profiles);
                        await UploadFile(filePath, videoSession, extraFilesData, progress, cancelToken);

                }

                private Task<UploadSession> PrepareMainFile(string filePath, string contextId, List<ExtraFile> extraFiles = default(List<ExtraFile>), string profiles = default(string))
                {
                        var fileInfo = new FileInfo(filePath);
                        var uploadBody = new VideoUploadBody(fileInfo.Length,
                                                                                                 fileInfo.Name,
                                                                                                 extraFiles,
                                                                                                 profiles,
                                                             true);

                        return _apiClient.UploadVideoAsync(contextId, uploadBody);
                }
        }
}
