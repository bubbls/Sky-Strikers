using System;
using System.Collections.Generic;
using Moon.Arena;

namespace Moon.MultiPlay
{
	public static class ServerPersistentData
	{
		[Serializable]
		public class PreservedArenaPlayerData
		{
			public PlayerSuitClass SuitClass;

			public TeamNo TeamNo;

			public int MMR;

			public int WinStreak;

			public int HighestWinStreak;

			public int LeaverLevel;

			public bool IsInParty;
		}

		[Serializable]
		public class FirstHalfLeftPlayerData
		{
			public TeamNo TeamNo;
		}

		public static readonly Dictionary<string, PreservedArenaPlayerData> PreservedPlayers;

		public static readonly Dictionary<string, FirstHalfLeftPlayerData> FirstHalfLeftPlayers;

		public static List<string> GetPreservedPlayerIds()
		{
			return null;
		}

		public static int GetPreservedPlayerMMR(string playerPlayFabId)
		{
			return 0;
		}

		public static int GetPreservedPlayerLeaverLevel(string playerPlayFabId)
		{
			return 0;
		}

		public static int GetPreservedPlayerWinStreak(string playerPlayFabId)
		{
			return 0;
		}

		public static int GetPreservedPlayerHighestWinStreak(string playerPlayFabId)
		{
			return 0;
		}

		public static void CheckIfTeamsHaveParties(out bool teamOneHasParty, out bool teamTwoHasParty)
		{
			teamOneHasParty = default(bool);
			teamTwoHasParty = default(bool);
		}

		public static void RegisterPreservedPlayerTeam(string playerPlayFabId, PreservedArenaPlayerData arenaPlayerData)
		{
		}

		public static bool TryGetPreservedPlayerTeam(string playerId, out PreservedArenaPlayerData arenaPlayerData)
		{
			arenaPlayerData = null;
			return false;
		}

		public static void Clear()
		{
		}

		public static void CleanUpInactivePreservedPlayers(List<MPlayer> activePlayers)
		{
		}

		public static void RegisterFirstHalfLeftPlayers(string playFabId, FirstHalfLeftPlayerData firstHalfLeftPlayerData)
		{
		}

		public static void UnRegisterFirstHalfLeftPlayers(string playFabId)
		{
		}

		public static void SetPreservedPlayerLeaverLevel(string playFabId, int leaverLevel)
		{
		}
	}
}
