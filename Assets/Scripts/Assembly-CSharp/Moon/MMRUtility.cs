using System;
using Moon.PlayerProfile;

namespace Moon
{
	public static class MMRUtility
	{
		[Serializable]
		public class MMRCalculateOriginalData
		{
			public MatchResult MatchResult;

			public int MMR;

			public bool IsForfeit;

			public int ForfeitDurationThreshold;

			public bool IsUnderdog;

			public double UnderdogMMRMultiplier;

			public int WinStreak;

			public int HighestWinStreak;

			public int WinStreakThresholdAmount;

			public int TotalPlayTime;

			public bool HasLeaverInTeam;

			public int LeaverLoseMMRDivider;

			public int LeaverLevel;

			public bool IsLeaver;
		}

		[Serializable]
		public class MMRCalcuateResultData
		{
			public int NewMMR;

			public bool ShouldUpdateWinStreak;

			public bool ShouldUpdateHighestWinStreak;

			public int WinStreak;

			public int HighestWinStreak;

			public int WinStreakMMR;

			public int UnderdogMMR;
		}

		public static void CalculateMMR(MMRCalculateOriginalData originalData, out MMRCalcuateResultData resultData)
		{
			resultData = null;
		}
	}
}
