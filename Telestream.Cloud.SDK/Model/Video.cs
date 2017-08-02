using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Model
{
	public class Video : ModelBase
	{
		public Video()
		{
			Encodings = new List<VideoEncoding>();
		}

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("extname")]
		public string Extname { get; set; }

		[JsonProperty("audio_sample_rate")]
		public int AudioSampleRate { get; set; }

		[JsonProperty("audio_codec")]
		public string AudioCodec { get; set; }

		[JsonProperty("fps")]
		public double Fps { get; set; }

		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }

		[JsonProperty("updated_at")]
		public DateTime UpdatedAt { get; set; }

		[JsonProperty("source_url")]
		public string SourceUrl { get; set; }

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("audio_channels")]
		public int AudioChannels { get; set; }

		[JsonProperty("video_bitrate")]
		public int VideoBitrate { get; set; }

		[JsonProperty("original_filename")]
		public string OriginalFilename { get; set; }

		[JsonProperty("file_size")]
		public long FileSize { get; set; }

		[JsonProperty("duration")]
		public int Duration { get; set; }

		[JsonProperty("video_codec")]
		public string VideoCodec { get; set; }

		[JsonProperty("path")]
		public string Path { get; set; }

                [JsonProperty("path_format")]
                public string PathFormat { get; set; }

		[JsonProperty("height")]
		public int Height { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("mime_type")]
		public string MimeType { get; set; }

		[JsonProperty("audio_bitrate")]
		public int AudioBitrate { get; set; }

		[JsonProperty("profiles")]
		public string Profiles { get; set; }

		[JsonProperty("extra_variables")]
		public Dictionary<String, String> ExtraVariables { get;  set; }

		public List<VideoEncoding> Encodings { get; set; }
	}
}
