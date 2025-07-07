using Chamber8.Framework.Messaging;

namespace Moon.Bootstrap
{
	public static class ServerGameCycleMessageModels
	{
		public static readonly ISubscriptionModel MatchmakingPlayerUpdated;

		public static readonly ISubscriptionModel PlayerStatsUpdated;

		public static readonly ISubscriptionModel PlayerRankedStatsUpdated;

		public static readonly ISubscriptionModel PlayerLastMatchStatsUpdated;

		public static readonly ISubscriptionModel TeamPlayersUpdated;
	}
}
