using Chamber8.Framework.Messaging;

namespace Moon.Bootstrap
{
	public static class ClientGameCycleMessageModels
	{
		public static readonly ISubscriptionModel RequestJoinPrivateSession;

		public static readonly ISubscriptionModel RequestJoinSession;

		public static readonly ISubscriptionModel RequestJoinRankedSession;

		public static readonly ISubscriptionModel RequestJoinSessionNoMatchmaking;

		public static readonly ISubscriptionModel RequestJoinSessionFromKick;

		public static readonly ISubscriptionModel RequestRestartMatchmaking;

		public static readonly ISubscriptionModel ConnectAsSingle;

		public static readonly ISubscriptionModel MatchmakingStatusUpdated;

		public static readonly ISubscriptionModel MatchmakingResult;

		public static readonly ISubscriptionModel LatencyUpdated;

		public static readonly ISubscriptionModel CancelMatchmaking;

		public static readonly ISubscriptionModel FieldTypeChanged;

		public static readonly ISubscriptionModel HubeCodeChanged;

		public static readonly ISubscriptionModel PlayerStatsUpdated;

		public static readonly ISubscriptionModel RequestStartMultiPersonMatchmaking;

		public static readonly ISubscriptionModel MultiPersonMatchmakingTicketCreated;

		public static readonly ISubscriptionModel RequestJoinMultiPersonTicket;

		public static readonly ISubscriptionModel MultiPersonTicketMatchFound;

		public static readonly ISubscriptionModel RequestJoinSessionFromMultiPersonTicket;
	}
}
