﻿using System;
using System.IO;
using Telestream.Cloud.Tts.Model;

namespace Telestream.Cloud.Tts.Api
{
	public class ExtraFileItem : ExtraFileMetadata
	{
		public long? FileSize { get; set; }
		public string FileName { get; set; }
		public int? Parts { get; set; }
		public int? PartSize { get; set; }
		public ExtraFileItem(string tag, string filePath) : base(tag, filePath)
		{
			var fileInfo = new FileInfo(filePath);
			FileSize = fileInfo.Length;
			FileName = fileInfo.Name;
		}

		public ExtraFile ToExtraFile()
		{
			return new ExtraFile(Tag, FileSize.Value, FileName);
		}
	}
}
