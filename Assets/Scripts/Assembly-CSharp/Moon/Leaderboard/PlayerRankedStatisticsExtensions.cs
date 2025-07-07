using System.Collections.Generic;
using Moon.Framework.Leaderboard;

namespace Moon.Leaderboard
{
	public static class PlayerRankedStatisticsExtensions
	{
		public static void UpdateStatisticsValue(this ref PlayerRankedStatistics stats, List<Statistic> statistics, PlayerSuitClass suitClass)
		{
		}

		public static ushort GetChampionWeaponGoals(this PlayerRankedStatistics stats, SuitWeaponVisualTheme weaponVisualTheme)
		{
			return 0;
		}

		public static LeaderboardNames GetChampionWeaponGoalsStatName(SuitWeaponVisualTheme weaponVisualTheme)
		{
			return default(LeaderboardNames);
		}
	}
}
