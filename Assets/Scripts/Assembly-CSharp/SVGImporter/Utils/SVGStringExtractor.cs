using System.Collections.Generic;
using SVGImporter.Rendering;

namespace SVGImporter.Utils
{
	public static class SVGStringExtractor
	{
		public static string pathCommands;

		private static char[] splitPipe;

		public static char[] splitSpaceComma;

		private static List<int> _break;

		private static char[] splitColonSemicolon;

		public static List<SVGTransform> ExtractTransformList(string inputText)
		{
			return null;
		}

		public static float[] ExtractTransformValueAsPX(string inputText)
		{
			return null;
		}

		public static string[] ExtractTransformValue(string inputText)
		{
			return null;
		}

		public static void ExtractPathSegList(string inputText, ref List<char> charList, ref List<string> valueList)
		{
		}

		public static string[] ExtractStringArray(string inputText)
		{
			return null;
		}

		public static void ExtractStyleValue(string inputText, ref Dictionary<string, string> dic)
		{
		}

		public static string ExtractUrl(string inputText)
		{
			return null;
		}
	}
}
