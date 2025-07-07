using Fusion;

namespace Moon.Leaderboard
{
	public class PlayerRankedStatisticsUpdatedMessage
	{
		public PlayerRef PlayerRef;

		public PlayerRankedStatistics Statistics;

		public PlayerSuitClass SuitClass;

		public PlayerStatisticsViewSetting.PageType PageType;
	}
}
