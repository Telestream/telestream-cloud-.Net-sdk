using System;
using System.IO;

namespace Telestream.Cloud.Flip.Api
{
	public class ExtraFileMetadata
	{
		public ExtraFileMetadata(string tag, string filePath)
		{
			if (string.IsNullOrWhiteSpace(tag)) { throw new ArgumentNullException(nameof(tag)); }
			if (string.IsNullOrWhiteSpace(filePath)) { throw new ArgumentNullException(nameof(filePath)); }
			if (!File.Exists(filePath)) { throw new FileNotFoundException(); }

			Tag = tag;
			FilePath = filePath;
		}

		public string Tag { get; set; }
		public string FilePath { get; set; }
	}
}
