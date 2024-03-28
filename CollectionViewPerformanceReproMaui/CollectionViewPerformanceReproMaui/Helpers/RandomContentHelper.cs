using System.Text;

namespace CollectionViewPerformanceReproMaui.Helpers
{
	public static class RandomContentHelper
	{
		private static readonly List<string> Words = new()
		{
			"sat",
			"cat",
			"the",
			"on",
			"with",
			"dog",
			"lovely",
			"angry",
			"mysterious",
			"quick",
			"brown",
			"fox",
			"jumps",
			"over",
			"lazy",
			"strong",
			"brave",
			"hero",
			"beautiful",
			"city"
		};

		private static readonly List<string> MoreWords = new()
		{
			"cat",
			"angry",
			"strength",
			"mysterious"
		};

		public static string GenerateRandomSentence(int length)
		{
			var sentence = new StringBuilder();

			for (var i = 0; i < length; i++)
			{
				var word = Words[new Random().Next(Words.Count)];

				if (i == 0)
				{
					word = char.ToUpper(word[0]) + word.Substring(1);
				}

				sentence.Append(word);

				if (i < length - 1)
				{
					sentence.Append(" ");
				}
			}

			return sentence.ToString();
		}

		public static string GenerateRandomWord()
		{
			return MoreWords[new Random().Next(MoreWords.Count)];
		}
	}
}
