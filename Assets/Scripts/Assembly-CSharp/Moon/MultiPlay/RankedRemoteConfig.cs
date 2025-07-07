using System;

namespace Moon.MultiPlay
{
	[Serializable]
	public class RankedRemoteConfig
	{
		public MMRWinStreakTable WinStreakTable;

		public MMRUnderdogConfig UnderdogConfig;

		public RankedLeaverConfig LeaverConfig;

		public RankedForfeitConfig ForfeitConfig;

		public RankedMatchRewardConfig MatchRewardConfig;

		public RankedBanConfiguration BanConfig;

		public RankedPairMatchmakingConfig PairMatchmakingConfig;
	}
}
