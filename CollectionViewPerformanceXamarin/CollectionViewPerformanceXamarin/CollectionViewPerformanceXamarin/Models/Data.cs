using CollectionViewPerformanceXamarin.Enums;
using CollectionViewPerformanceXamarin.Helpers;
using System;
using System.Collections.Generic;

namespace CollectionViewPerformanceXamarin.Models
{
	public sealed class Data
	{
		public Template Template { get; set; }

		public string Category { get; set; } = string.Empty;

		public string Title { get; set; } = string.Empty;

		public string Subtitle { get; set; } = string.Empty;

		public string ContentAsString { get; set; } = string.Empty;

		public List<string> ContentAsList { get; set; } = new();

		public string ConditionalContent { get; set; } = string.Empty;

		public bool ShowConditionalContent { get; set; } = false;

		public Data()
		{
			var random = new Random();

			this.Template = Template.CardWithTheLot;
			this.Category = RandomContentHelper.GenerateRandomWord();
			this.Title = RandomContentHelper.GenerateRandomSentence(4);
			this.Subtitle = RandomContentHelper.GenerateRandomSentence(5);
			this.ContentAsString = RandomContentHelper.GenerateRandomSentence(random.Next(6, 12));
			this.ContentAsList = new List<string>()
			{
				RandomContentHelper.GenerateRandomSentence(random.Next(6, 12)),
				RandomContentHelper.GenerateRandomSentence(random.Next(6, 12)),
				RandomContentHelper.GenerateRandomSentence(random.Next(6, 12))
			};
			this.ConditionalContent = "I'm sometimes invisible";
			this.ShowConditionalContent = random.Next(0, 2) == 1; // 50/50 chance
		}
	}
}
