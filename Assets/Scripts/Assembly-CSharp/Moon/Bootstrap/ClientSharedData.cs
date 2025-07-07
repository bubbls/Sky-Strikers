using System;
using System.Collections.Generic;
using Chamber8.Framework.Service.PlayFab;
using Fusion;
using Moon.Framework.Base;
using PlayFab.MultiplayerModels;

namespace Moon.Bootstrap
{
	public static class ClientSharedData
	{
		public enum Status
		{
			None = 0,
			Error = 1,
			PermissionGranting = 2,
			PermissionGranted = 3,
			LoggingIn = 4,
			LoggedIn = 5,
			Maintenance = 6,
			AppOutdated = 7,
			Matching = 8,
			Matched = 9
		}

		public enum Error
		{
			Ok = 0,
			LoginFailed = 1,
			CreateMatchmakingTicketFailed = 2,
			GetMatchFailed = 3,
			MatchmakingCancelled = 4,
			PollingMatchmakingTicketFailed = 5,
			ConnectingToPhotonFailed = 6
		}

		[Serializable]
		public class ClientLocalSettings
		{
			public bool IsMicEnabled;

			public List<string> mutePlayerFabId;
		}

		private static Status _curStatus;

		private static MatchmakingStatus _matchmakingStatus;

		public static ClientErrorCode LastErrorCode;

		public static Latency LowestLatency;

		public static readonly List<Latency> Latencies;

		public static MatchmakingPlayerWithTeamAssignment MatchmakingPlayer;

		public static string PlayFabRoomNameBeingKickedFrom;

		public static bool IsServerUnderMaintenance;

		public static string PlayFabId;

		public static PlayFabRegion UserPreferredRegion;

		private static readonly List<Latency> _userPreferredLatencies;

		private static ClientLocalSettings LocalSettings;

		private const string ClientLocalSettingsKey = "ClientRemoteSetting";

		private static byte[] _cachedConnectionToken;

		public static Status CurStatus => default(Status);

		public static bool IsMatchmaking => false;

		public static MatchmakingStatus MatchmakingStatus
		{
			get
			{
				return default(MatchmakingStatus);
			}
			set
			{
			}
		}

		public static PlayFabRegion CurrentUserPreferredRegion { get; private set; }

		public static bool IsPrivateSession { get; set; }

		public static string MultiPlayEntityId { get; private set; }

		public static bool ObserverMode { get; private set; }

		public static void UpdateStatus(Status status, Error error = Error.Ok)
		{
		}

		public static void UpdateLowestLatency(Latency any)
		{
		}

		public static void UpdateLatencies(List<Latency> all)
		{
		}

		public static List<Latency> GetLatencies()
		{
			return null;
		}

		public static void UpdateUserPreferredLatencies()
		{
		}

		public static void UpdateUserPreferredLatencies(List<string> preferredRegions)
		{
		}

		public static List<Latency> GetUserPreferredLatencies()
		{
			return null;
		}

		public static void UpdateInitialCombinedInfo(LinkedPlayFabAccount account)
		{
		}

		public static bool IsLocalMicEnabled()
		{
			return false;
		}

		public static void SetObserverMode(bool enable)
		{
		}

		public static byte[] CreateConnectionToken()
		{
			return null;
		}

		public static byte[] GetCachedConnectionToken()
		{
			return null;
		}

		private static void LoadClientLocalSetting()
		{
		}

		public static void SetLocalMicEnabled(bool micEnabled)
		{
		}

		public static bool IsMutePlayer(PlayerRef playerRef)
		{
			return false;
		}

		public static void ModifyMutePlayers(PlayerRef playerRef, bool mute)
		{
		}

		private static void SavePlayerProfile()
		{
		}
	}
}
