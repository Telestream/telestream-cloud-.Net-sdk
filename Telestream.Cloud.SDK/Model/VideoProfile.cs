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
		public string KeyframeInterval { get; set; }

		[JsonProperty("preset_name")]
		public string PresetName { get; set; }

		[JsonProperty("updated_at")]
		public string UpdatedAt { get; set; }

		[JsonProperty("height")]
		public string Height { get; set; }

		[JsonProperty("width")]
		public string Width { get; set; }

		[JsonProperty("upscale")]
		public string Upscale { get; set; }

		[JsonProperty("audio_bitrate")]
		public string AudioBitrate { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("audio_sample_rate")]
		public string AudioSampleRate { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("video_bitrate")]
		public string VideoBitrate { get; set; }

		[JsonProperty("extname")]
		public string Extname { get; set; }

		[JsonProperty("priority")]
		public string Priority { get; set; }

		[JsonProperty("time_code")]
		public string TimeCode { get; set; }

		[JsonProperty("aspect_mode")]
		public string AspectMode { get; set; }

		[JsonProperty("created_at")]
		public string CreatedAt { get; set; }
	}
}
