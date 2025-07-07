using System;

namespace Moon.MultiPlay
{
	[Serializable]
	public class RankedPlayerBanData
	{
		public int Version;

		public int BanStartLeaverLevel;

		public string? BanStartTimeString;

		public string? BanEndTimeString;

		public DateTime GetBanStartTime()
		{
			return default(DateTime);
		}

		public DateTime GetBanEndTime()
		{
			return default(DateTime);
		}

		private static DateTime ParseBanString(string? banString)
		{
			return default(DateTime);
		}
	}
}
