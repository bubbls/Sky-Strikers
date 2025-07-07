using Chamber8.Framework.Messaging;

namespace Moon.Bootstrap
{
	public static class GameCycleMessageModels
	{
		public static readonly ISubscriptionModel ConnChanged;

		public static readonly ISubscriptionModel ReportConnProgress;

		public static readonly ISubscriptionModel ReportError;

		public static readonly ISubscriptionModel PlayerAdded;

		public static readonly ISubscriptionModel PlayerRemoved;

		public static readonly ISubscriptionModel Shutdown;

		public static readonly ISubscriptionModel RankedMatchmakingStatusChanged;

		public static readonly ISubscriptionModel JoinRankedSessionFailed;

		public static readonly ISubscriptionModel RequestStopBackfillTicket;

		public static readonly ISubscriptionModel ApplicationPauseChanged;
	}
}
