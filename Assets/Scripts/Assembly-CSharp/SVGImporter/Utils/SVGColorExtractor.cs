using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SVGImporter.Utils
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct SVGColorExtractor
	{
		public static Dictionary<string, Color> ConstantColors;

		private static Color change(int r, int g, int b)
		{
			return default(Color);
		}

		public static Color ConstColor(string name)
		{
			return default(Color);
		}

		public static bool IsConstName(string textColor)
		{
			return false;
		}

		public static bool IsHexColor(string colorStr)
		{
			return false;
		}

		public static bool IsRGBColor(string colorStr)
		{
			return false;
		}

		private static int ParseHexDigit(char c)
		{
			return 0;
		}

		public static Color HexColor(string colorStr)
		{
			return default(Color);
		}

		public static Color RGBColor(string colorStr)
		{
			return default(Color);
		}

		private static int GetColorValue(string value)
		{
			return 0;
		}
	}
}
