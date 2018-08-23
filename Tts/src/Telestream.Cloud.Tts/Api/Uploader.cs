using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using Telestream.Cloud.Tts.Client;
using Telestream.Cloud.Tts.Model;

namespace Telestream.Cloud.Tts.Api
{
        public class FileUploader : FileUploaderBase
        {
                public FileUploader(TtsApi apiClient) : base(apiClient)
                {

                }

                public async Task UploadFile(string filePath, string contextId, IProgress<double> progress = null, CancellationToken cancelToken = default(CancellationToken), Job job = default(Job))
                {
                        var fileName = Path.GetFileName(filePath);
                        var fileInfo = new FileInfo(filePath);
                        var videoSession = await PrepareMainFile(filePath,
                                                                                                         contextId,
                                                                                                         job);
                        await UploadFile(filePath, videoSession, null, progress, cancelToken);

                }

                private Task<UploadSession> PrepareMainFile(string filePath, string contextId, Job job = default(Job))
                {
                        var fileInfo = new FileInfo(filePath);
                        var uploadBody = new VideoUploadBody(fileInfo.Length,
                                                                                                 fileInfo.Name,
                                                                                                 "",
                                                                                                 true,
                                                                                                 null, job);

                        return _apiClient.UploadVideoAsync(contextId, uploadBody);
                }
        }
}
