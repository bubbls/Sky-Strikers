using Chamber8.Framework.Messaging;

namespace Moon.Leaderboard
{
	public static class LeaderboardMessageModels
	{
		public static readonly ISubscriptionModel LocalPlayerStatisticsUpdated;

		public static readonly ISubscriptionModel PlayerStatisticsUpdated;

		public static readonly ISubscriptionModel PlayerRankedStatisticsUpdated;

		public static readonly ISubscriptionModel PlayerLastMatchStatisticsUpdated;

		public static readonly ISubscriptionModel PlayersLastMatchStatisticsUpdated;

		public static readonly ISubscriptionModel DataContributionLeaderboardUpdated;

		public static readonly ISubscriptionModel TotalDataContributionLeaderboardUpdated;
	}
}
