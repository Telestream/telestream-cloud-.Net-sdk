using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Model
{
	public class VideoEncoding : ModelBase
	{
		public VideoEncoding()
		{
			Files = new List<string>();
			Screenshots = new List<string>();
		}

		[JsonProperty("files")]
		public List<string> Files { get; set; }

		[JsonProperty("screenshots")]
		public List<string> Screenshots { get; set; }

		[JsonProperty("status")]
		public EncodingStatus Status { get; set; }

		[JsonProperty("audio_channels")]
		public int AudioChannels { get; set; }

		[JsonProperty("profile_id")]
		public string ProfileId { get; set; }

		[JsonProperty("updated_at")]
		public string UpdatedAt { get; set; }

		[JsonProperty("height")]
		public int Height { get; set; }

		[JsonProperty("profile_name")]
		public string ProfileName { get; set; }

		[JsonProperty("audio_bitrate")]
		public int AudioBitrate { get; set; }

		[JsonProperty("audio_codec")]
		public string AudioCodec { get; set; }

		[JsonProperty("file_size")]
		public long FileSize { get; set; }

		[JsonProperty("duration")]
		public int Duration { get; set; }

		[JsonProperty("path")]
		public string Path { get; set; }

		[JsonProperty("extname")]
		public string Extname { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("encoding_time")]
		public int EncodingTime { get; set; }

		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }

		[JsonProperty("video_id")]
		public string VideoId { get; set; }

		[JsonProperty("started_encoding_at")]
		public DateTime StartedEncodingAt { get; set; }

		[JsonProperty("audio_sample_rate")]
		public int AudioSampleRate { get; set; }

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("encoding_progress")]
		public int EncodingProgress { get; set; }

		[JsonProperty("fps")]
		public double Fps { get; set; }

		[JsonProperty("video_codec")]
		public string VideoCodec { get; set; }

		[JsonProperty("video_bitrate")]
		public int VideoBitrate { get; set; }

		[JsonProperty("mime_type")]
		public string MimeType { get; set; }

		[JsonProperty("error_message")]
		public string ErrorMessage { get; set; }

		[JsonProperty("error_class")]
		public string ErrorClass { get; set; }
	}
}
