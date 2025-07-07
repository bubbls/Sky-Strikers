namespace Moon.MultiPlay
{
	public static class RankedRemoteConfigManager
	{
		private const string ClassName = "RankedRemoteConfigManager";

		public static RankedPairMatchmakingConfig GetRankedPairMatchmakingConfig()
		{
			return null;
		}

		public static void GetWinStreakThresholdAmount(out int winStreakThresholdAmount)
		{
			winStreakThresholdAmount = default(int);
		}

		public static void GetWinStreakMMR(int winStreak, out int winStreakMMR)
		{
			winStreakMMR = default(int);
		}

		public static void GetUnderdogDifferenceThreshold(out int underdogDifferenceThreshold, out float underdogMMRMultiplier)
		{
			underdogDifferenceThreshold = default(int);
			underdogMMRMultiplier = default(float);
		}

		public static void GetRankedRemoteConfig(out RankedMatchRewardConfig rewardConfig, out RankedForfeitConfig forfeitConfig)
		{
			rewardConfig = null;
			forfeitConfig = null;
		}

		public static void GetRankedLeaverConfig(out RankedLeaverConfig leaverConfig)
		{
			leaverConfig = null;
		}

		public static void GetRankedBanConfig(out RankedBanConfiguration banConfig)
		{
			banConfig = null;
		}
	}
}
