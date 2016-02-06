using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Model
{
	public class VideoProfile : ModelBase
	{
		[JsonProperty("keyframe_interval")]
		public int KeyframeInterval { get; set; }

		[JsonProperty("preset_name")]
		public string PresetName { get; set; }

		[JsonProperty("updated_at")]
		public string UpdatedAt { get; set; }

		[JsonProperty("height")]
		public int Height { get; set; }

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("upscale")]
		public bool Upscale { get; set; }

		[JsonProperty("audio_bitrate")]
		public int AudioBitrate { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("audio_sample_rate")]
		public int AudioSampleRate { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("video_bitrate")]
		public int VideoBitrate { get; set; }

		[JsonProperty("extname")]
		public string Extname { get; set; }

		[JsonProperty("priority")]
		public string Priority { get; set; }

		[JsonProperty("time_code")]
		public string TimeCode { get; set; }

		[JsonProperty("aspect_mode")]
		public string AspectMode { get; set; }

		[JsonProperty("created_at")]
		public DateTime CreatedAt { get; set; }
	}
}
