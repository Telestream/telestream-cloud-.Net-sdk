using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telestream.Cloud.SDK.Model
{
	public class VideoMetadata : ModelBase
	{
		[JsonProperty("source_image_width")]
		public int SourceImageWidth { get; set; }

		[JsonProperty("create_date")]
		public DateTime CreateDate { get; set; }

		[JsonProperty("file_type")]
		public string FileType { get; set; }

		[JsonProperty("file_name")]
		public string FileName { get; set; }

		[JsonProperty("media_duration")]
		public string MediaDuration { get; set; }

		[JsonProperty("track_volume")]
		public string TrackVolume { get; set; }

		[JsonProperty("source_image_height")]
		public int SourceImageHeight { get; set; }

		[JsonProperty("file_size")]
		public string FileSize { get; set; }

		[JsonProperty("duration")]
		public string Duration { get; set; }

		[JsonProperty("preview_time")]
		public string PreviewTime { get; set; }

		[JsonProperty("preview_duration")]
		public string PreviewDuration { get; set; }

		[JsonProperty("media_language_code")]
		public string MediaLanguageCode { get; set; }

		[JsonProperty("minor_version")]
		public string MinorVersion { get; set; }

		[JsonProperty("current_time")]
		public string CurrentTime { get; set; }

		[JsonProperty("movie_header_version")]
		public string MovieHeaderVersion { get; set; }

		[JsonProperty("handler_type")]
		public string HandlerType { get; set; }

		[JsonProperty("track_modify_date")]
		public DateTime TrackModifyDate { get; set; }

		[JsonProperty("image_width")]
		public int ImageWidth { get; set; }

		[JsonProperty("track_id")]
		public string TrackId { get; set; }

		[JsonProperty("selection_time")]
		public string SelectionTime { get; set; }

		[JsonProperty("movie_data_size")]
		public long MovieDataSize { get; set; }

		[JsonProperty("compatible_brands")]
		public string[] CompatibleBrands { get; set; }

		[JsonProperty("x_resolution")]
		public int XResolution { get; set; }

		[JsonProperty("avg_bitrate")]
		public string AvgBitrate { get; set; }

		[JsonProperty("mime_type")]
		public string MimeType { get; set; }

		[JsonProperty("preferred_volume")]
		public string PreferredVolume { get; set; }

		[JsonProperty("time_scale")]
		public int TimeScale { get; set; }

		[JsonProperty("audio_channels")]
		public int AudioChannels { get; set; }

		[JsonProperty("audio_format")]
		public string AudioFormat { get; set; }

		[JsonProperty("track_duration")]
		public string TrackDuration { get; set; }

		[JsonProperty("matrix_structure")]
		public string MatrixStructure { get; set; }

		[JsonProperty("major_brand")]
		public string MajorBrand { get; set; }

		[JsonProperty("media_modify_date")]
		public string MediaModifyDate { get; set; }

		[JsonProperty("handler_vendor_id")]
		public string HandlerVendorId { get; set; }

		[JsonProperty("bit_depth")]
		public int BitDepth { get; set; }

		[JsonProperty("y_resolution")]
		public int YResolution { get; set; }

		[JsonProperty("track_create_date")]
		public string TrackCreateDate { get; set; }

		[JsonProperty("image_size")]
		public long ImageSize { get; set; }

		[JsonProperty("rotation")]
		public int Rotation { get; set; }

		[JsonProperty("media_create_date")]
		public string MediaCreateDate { get; set; }

		[JsonProperty("audio_sample_rate")]
		public string AudioSampleRate { get; set; }

		[JsonProperty("selection_duration")]
		public string SelectionDuration { get; set; }

		[JsonProperty("compressor_id")]
		public string CompressorId { get; set; }

		[JsonProperty("graphics_mode")]
		public string GraphicsMode { get; set; }

		[JsonProperty("track_layer")]
		public int TrackLayer { get; set; }

		[JsonProperty("next_track_id")]
		public string NextTrackId { get; set; }

		[JsonProperty("track_header_version")]
		public string TrackHeaderVersion { get; set; }

		[JsonProperty("media_time_scale")]
		public string MediaTimeScale { get; set; }

		[JsonProperty("poster_time")]
		public string PosterTime { get; set; }

		[JsonProperty("op_color")]
		public string OpColor { get; set; }

		[JsonProperty("video_frame_rate")]
		public string VideoFrameRate { get; set; }

		[JsonProperty("image_height")]
		public int ImageHeight { get; set; }

		[JsonProperty("modify_date")]
		public DateTime ModifyDate { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("preferred_rate")]
		public int PreferredRate { get; set; }

		[JsonProperty("balance")]
		public int Balance { get; set; }

		[JsonProperty("handler_description")]
		public string HandlerDescription { get; set; }

		[JsonProperty("media_header_version")]
		public int MediaHeaderVersion { get; set; }

		[JsonProperty("audio_bits_per_sample")]
		public int AudioBitsPerSample { get; set; }


	}
}
