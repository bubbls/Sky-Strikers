using Chamber8.Framework.Messaging;

namespace Moon.MultiPlay
{
	public static class MessageModels
	{
		public static readonly ISubscriptionModel AdditiveSceneLoaded;

		public static readonly ISubscriptionModel LocalPlayerInfoChanged;

		public static readonly ISubscriptionModel LocalPlayerTeamChanged;

		public static readonly ISubscriptionModel PlayerInfoBeforeChanged;

		public static readonly ISubscriptionModel PlayerInfoChanged;

		public static readonly ISubscriptionModel PlayerRTTChanged;

		public static readonly ISubscriptionModel PlayerAction;

		public static readonly ISubscriptionModel PlayerLocomotion;

		public static readonly ISubscriptionModel MatchEvent;

		public static readonly ISubscriptionModel MatchActionEvent;

		public static readonly ISubscriptionModel CrowdResponseTriggered;

		public static readonly ISubscriptionModel LocalPlayerLocationChanged;

		public static readonly ISubscriptionModel OtherPlayerLocationChanged;

		public static readonly ISubscriptionModel LocalPlayerVisualsChanged;

		public static readonly ISubscriptionModel BenchmarkMessage;

		public static readonly ISubscriptionModel GeneralMessage;

		public static readonly ISubscriptionModel FieldMessage;

		public static readonly ISubscriptionModel MPlayerSpawnedMessage;

		public static readonly ISubscriptionModel MPlayerContainerSpawnedMessage;

		public static readonly ISubscriptionModel PlayerInitialized;

		public static readonly ISubscriptionModel NotificationMessage;

		public static readonly ISubscriptionModel LocalPlayerTouchDeadZone;

		public static readonly ISubscriptionModel LocalPlayerFinishedTeleport;

		public static readonly ISubscriptionModel PlayerEnergyCollected;

		public static readonly ISubscriptionModel PlayerAbilityInflicted;

		public static readonly ISubscriptionModel PlayerPossessionChanged;

		public static readonly ISubscriptionModel PlayerAmmoStatusChanged;

		public static readonly ISubscriptionModel PlayerDoTargetShot;

		public static readonly ISubscriptionModel PlayerChampionWeaponStatusUpdated;

		public static readonly ISubscriptionModel PlayerChampionWeaponStatusRequested;
	}
}
