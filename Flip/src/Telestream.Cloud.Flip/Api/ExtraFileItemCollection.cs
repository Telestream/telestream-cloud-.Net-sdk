using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Telestream.Cloud.Flip.Client;
using Telestream.Cloud.Flip.Model;

namespace Telestream.Cloud.Flip.Api
{
	public class ExtraFileItemCollection : List<ExtraFileItem>
	{
		public ExtraFileItemCollection(List<ExtraFileMetadata> extraFiles) : base()
		{
			foreach (var extraFileGroup in extraFiles.GroupBy(x => x.Tag))
			{
				var tag = extraFileGroup.Key;

				if (extraFileGroup.Count() == 1)
				{
					var eff = extraFileGroup.ElementAt(0);
					Add(CreateItem(tag, eff.FilePath));
				}
				else
				{
					for (int i = 0; i < extraFileGroup.Count(); i++)
					{
						var eff = extraFileGroup.ElementAt(i);
						Add(CreateItem(tag + ".index-" + i, eff.FilePath));
					}
				}
			}
		}

		private ExtraFileItem CreateItem(string tag, string filePath)
		{
			var fileInfo = new FileInfo(filePath);
			return new ExtraFileItem(tag, filePath);
		}

		public List<ExtraFile> ToExtraFileList()
		{
			return this.Select(x => x.ToExtraFile()).ToList();
		}

		public void Apply(UploadSession uploadSession)
		{
			const string PARTS = "parts";
			const string PART_SIZE = "part_size";
			var source = (Newtonsoft.Json.Linq.JObject)uploadSession.ExtraFiles;
			var efs = source.ToObject<Dictionary<string, Dictionary<string, string>>>();
			foreach (var item in this)
			{
				var data = new Dictionary<string, string>();
				if (efs.TryGetValue(item.Tag, out data))
				{
					item.Parts = int.Parse(data[PARTS]);
					item.PartSize = int.Parse(data[PART_SIZE]);
				}
			}
		}
	}
}
