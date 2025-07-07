using System;

namespace SVGImporter.Utils
{
	public class FileSizeFormatProvider : IFormatProvider, ICustomFormatter
	{
		private const string fileSizeFormat = "fs";

		private const decimal OneKiloByte = 1024m;

		private const decimal OneMegaByte = 1048576m;

		private const decimal OneGigaByte = 1073741824m;

		public object GetFormat(Type formatType)
		{
			return null;
		}

		public string Format(string format, object arg, IFormatProvider formatProvider)
		{
			return null;
		}

		private static string defaultFormat(string format, object arg, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
