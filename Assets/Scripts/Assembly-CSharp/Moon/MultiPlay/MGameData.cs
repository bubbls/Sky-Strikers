using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.MultiPlay.Aoi;
using UnityEngine;

namespace Moon.MultiPlay
{
	public class MGameData : Singleton<MGameData>
	{
		public struct PlayerData
		{
			public MPlayerContainer Container;

			public MPlayer Player;

			public bool IsValid => false;
		}

		private readonly PlayerData[] _playerData;

		private PlayerInfo _localPlayerInfo;

		private IMessageSubscriber? _onConnChanged;

		public static PlayerRef LocalPlayer => default(PlayerRef);

		protected override void Initialize()
		{
		}

		protected override void Dispose()
		{
		}

		private int OnConnChanged(IMessage<ConnChangedMessage> message)
		{
			return 0;
		}

		public static bool HasPlayers(params string[] playFabIds)
		{
			return false;
		}

		public static void SpawnContainer(PlayerRef playerRef, MPlayerContainer containerPrefab, ConnectionToken connectionToken)
		{
		}

		public static void TrySpawnPlayer(PlayerRef playerRef, MPlayer playerPrefab)
		{
		}

		public static void SpawnPlayerAt(PlayerRef playerRef, MPlayer playerPrefab, Transform spawnPoint)
		{
		}

		private static void SpawnPlayerInternal(PlayerRef playerRef, MPlayer playerPrefab, Transform spawnPoint)
		{
		}

		public static void Despawn(PlayerRef playerRef, bool isHostClient)
		{
		}

		public static void SpawnPlayers(NetworkRunner runner, Action<PlayerRef, MPlayer> spawnPlayer)
		{
		}

		private static void UpdateGameMaster()
		{
		}

		private static bool CanSetGameMaster()
		{
			return false;
		}

		public static bool IsGameMaster(PlayerRef playerRef)
		{
			return false;
		}

		public static PlayerRef GetGameMaster(out MPlayerContainer? container)
		{
			container = null;
			return default(PlayerRef);
		}

		public static void NotifyPlayerContainerSpawned(MPlayerContainer container)
		{
		}

		public static void NotifyPlayerSpawned(MPlayer player)
		{
		}

		public static PlayerData[] GetRawPlayers()
		{
			return null;
		}

		public static IEnumerable<PlayerData> GetActivePlayers()
		{
			return null;
		}

		public static void GetActivePlayers(List<MPlayer> result)
		{
		}

		public static PlayerInfo GetLocalPlayerInfo()
		{
			return default(PlayerInfo);
		}

		public static void SetLocalPlayerLocationAndSync(Location location)
		{
		}

		public static void SetLocalPlayerVisionFlag(NetworkVisionFlag flag, bool forceUpdate = false)
		{
		}

		public static void SetLocalPlayerInfoAndSync(PlayerInfo playerInfo)
		{
		}

		public static void SetLocalPlayerInfoOnly(PlayerInfo playerInfo)
		{
		}

		public static bool TryGetPlayerInfo(PlayerRef playerRef, out PlayerInfo playerInfo)
		{
			playerInfo = default(PlayerInfo);
			return false;
		}

		public static List<PlayerVisualsConfig> GetAllPlayerVisualsConfig()
		{
			return null;
		}

		public static PlayerInfo GetPlayerInfo(PlayerRef playerRef)
		{
			return default(PlayerInfo);
		}

		public static void SetPlayerInfo(PlayerRef playerRef, PlayerInfo playerInfo)
		{
		}

		public static MPlayer GetPlayer(string playFabId)
		{
			return null;
		}

		public static MPlayer? GetPlayer(PlayerRef playerRef)
		{
			return null;
		}

		private static PlayerData? GetPlayerData(PlayerRef playerRef)
		{
			return null;
		}

		public static MPlayerContainer? GetPlayerContainer(PlayerRef playerRef)
		{
			return null;
		}

		public static void SetPlayerNo(int playerNo)
		{
		}

		public static void SetPlayerTeamNo(PlayerRef playerRef, TeamNo teamNo)
		{
		}

		private static TeamNo AssignTeamNo()
		{
			return default(TeamNo);
		}

		private static void GetTeamPlayerCount(out int teamOneCount, out int teamTwoCount)
		{
			teamOneCount = default(int);
			teamTwoCount = default(int);
		}
	}
}
