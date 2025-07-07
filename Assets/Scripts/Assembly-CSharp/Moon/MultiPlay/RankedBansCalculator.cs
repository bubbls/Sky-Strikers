using System;

namespace Moon.MultiPlay
{
	public static class RankedBansCalculator
	{
		public static void CalculateLeaverLevelReduction(int currentLeaverLevel, RankedPlayerBanData playerBanData, RankedBanConfiguration banConfig, DateTime currentTime, out int newLeaverLevel)
		{
			newLeaverLevel = default(int);
		}

		public static void CalculateBanDuration(int leaverLevel, RankedBanConfiguration banConfig, out int banDuration)
		{
			banDuration = default(int);
		}
	}
}
