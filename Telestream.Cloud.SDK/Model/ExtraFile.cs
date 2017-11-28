using System;
using Newtonsoft.Json;

namespace Telestream.Cloud.SDK.Model
{
    public class ExtraFile : ModelBase
    {
        public ExtraFile()
        {
        }

        public ExtraFile(string fileType, string url, string inputPath = null)
        {
            FileType = fileType;
            Url = url;
            InputPath = inputPath;
        }

        [JsonProperty("file_type")]
		public string FileType { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("input_path")]
		public string InputPath { get; set; }
	}
}
