using Fusion;
using Moon.Arena;
using Moon.Framework.Base;

namespace Moon.Bootstrap
{
	public static class SharedData
	{
		public static class Constants
		{
			public const string Chamber8_SSVR_TitleId = "CEBD4";

			public const string Chamber8_SSVR_BETA_TitleId = "9071E";

			public const string DefaultPhotonLobbyName = "Production";

			public const string PublicRoomName = "_PublicRoom";

			public const string BackFillMatchmakingFlagPublic = "BackFillMatchmakingFlagPublic";

			public const string BackFillMatchmakingFlagPrivate = "BackFillMatchmakingFlagPrivate";

			public const string ArenaSessionQueue = "arena_session";

			public const string ArenaSessionQueuePrivate = "arena_session_private";

			public const string ArenaRankedSessionQueue = "arena_session_ranked";

			public const string ArenaRankedSessionQueuePrivate = "arena_session_ranked_private";

			public const int ArenaPlayerCount = 8;

			public const int ArenaMatchSummaryPlayerCount = 6;

			public const int ArenaRankedPlayerCount = 6;

			public const string HubSessionQueue = "hub_session";

			public const string HubSessionQueuePrivate = "hub_session_private";

			public const int HubPlayerCount = 10;

			public const int MaxPlayerCapacity = 10;
		}

		public static PlayFabRegion PlayFabRegion;

		public static string PlayFabRoomName;

		public static PhotonRegion.Code PhotonRegion;

		public static string PhotonLobbyName;

		public static string PhotonSessionId;

		private static FieldType _fieldType;

		public static ushort Port;

		private static string _lastHubCode;

		public static string LastUnRankedArenaCode;

		public static GameMode GameMode;

		public static readonly PlayerRef[] TeamOnePlayers;

		public static readonly PlayerRef[] TeamTwoPlayers;

		public static bool IsPublicRoom => false;

		public static string LastHubCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static FieldType FieldType
		{
			get
			{
				return default(FieldType);
			}
			set
			{
			}
		}

		public static int GetPlayerCapacity()
		{
			return 0;
		}

		static SharedData()
		{
		}

		public static void RegisterTeamPlayer(TeamNo teamNo, PlayerRef playerRef)
		{
		}

		public static void UnregisterTeamPlayer(TeamNo teamNo, PlayerRef playerRef)
		{
		}

		public static void ClearTeamPlayers()
		{
		}
	}
}
