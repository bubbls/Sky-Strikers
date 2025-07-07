using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Fusion;
using Moon.Framework.Base;
using PlayFab.MultiplayerAgent.Model;
using PlayFab.MultiplayerModels;

namespace Moon.Bootstrap
{
	public static class ServerSharedData
	{
		public struct Change
		{
			public List<MatchmakingPlayerWithTeamAssignment> Added;

			public List<MatchmakingPlayerWithTeamAssignment> Removed;
		}

		public static readonly Dictionary<PlayFabRegion, PhotonRegion.Code> PlayFab2PhotonRegion;

		public static string PublicIpV4;

		public static ushort PublicPort;

		public static string QueueName;

		public static readonly List<PlayFab.MultiplayerAgent.Model.ConnectedPlayer> ConnectedPlayers;

		public static readonly Dictionary<PlayerRef, MatchmakingPlayerWithTeamAssignment> MatchmakingPlayers;

		private static readonly Regex _connectedPlayerRegex;

		public static event Action<Change> OnMatchmakingPlayersChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static PlayFabRegion PhotonRegionToPlayFabRegion(PhotonRegion.Code photonRegion)
		{
			return default(PlayFabRegion);
		}

		public static List<MatchmakingPlayerWithTeamAssignment> GetConnectedMatchmakingPlayers()
		{
			return null;
		}

		public static bool AddMatchmakingPlayer(PlayerRef playerRef, string entityId, string teamId, bool isInParty, LatencyFusion latencyFusion)
		{
			return false;
		}

		public static bool RemoveMatchmakingPlayer(PlayerRef playerRef)
		{
			return false;
		}

		public static void ClearMatchmakingPlayer()
		{
		}

		public static PlayFab.MultiplayerAgent.Model.ConnectedPlayer CreateConnectedPlayer(PlayerRef playerRef, string playFabId)
		{
			return null;
		}

		public static PlayerRef GetPlayerRef(PlayFab.MultiplayerAgent.Model.ConnectedPlayer connectedPlayer)
		{
			return default(PlayerRef);
		}
	}
}
