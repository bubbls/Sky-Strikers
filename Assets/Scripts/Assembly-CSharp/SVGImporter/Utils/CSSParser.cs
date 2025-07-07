using System.Collections.Generic;

namespace SVGImporter.Utils
{
	public class CSSParser
	{
		private const char elementStartChar = '{';

		private const char elementEndChar = '}';

		private const char elementSplitChar = ',';

		private const char attributeStartChar = ':';

		private const char attributeEndChar = ';';

		public static CSSSelector GetSelector(string value)
		{
			return default(CSSSelector);
		}

		public static string CleanCSS(string cssString)
		{
			return null;
		}

		public static Dictionary<string, Dictionary<string, string>> Parse(string value)
		{
			return null;
		}

		private static Dictionary<string, string> Merge(Dictionary<string, string> a, Dictionary<string, string> b)
		{
			return null;
		}
	}
}
