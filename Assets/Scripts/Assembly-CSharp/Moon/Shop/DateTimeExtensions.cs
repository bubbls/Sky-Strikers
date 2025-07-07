using System;
using System.Globalization;

namespace Moon.Shop
{
	public static class DateTimeExtensions
	{
		private const DateTimeStyles Styles = DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal;

		public static string GetCountdownString(this TimeSpan countdown)
		{
			return null;
		}

		public static bool TryParseDateTimeString(this string s, out DateTime dt)
		{
			dt = default(DateTime);
			return false;
		}

		public static bool TryParseDateTimeStringExact(this string s, out DateTime dt)
		{
			dt = default(DateTime);
			return false;
		}
	}
}
