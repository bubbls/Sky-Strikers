using System;

namespace Moon
{
	public static class EnumExtensions
	{
		public static T RandomEnum<T>() where T : Enum
		{
			return default(T);
		}

		public static string ToReadableString(this Enum enumValue, bool toUpper = false)
		{
			return null;
		}
	}
}
