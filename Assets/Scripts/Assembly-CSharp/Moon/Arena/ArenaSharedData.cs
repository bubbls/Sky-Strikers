using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Arena
{
	public static class ArenaSharedData
	{
		public static GameSettings GameSettings;

		public static bool HasInitialSync;

		public static bool IsMatchInProgress;

		public static string CurrentMatchId;

		public static float ElapsedTime;

		public static float MatchTotalPlayTime;

		public static bool InOvertime;

		public static bool IsCountingDownToNextMatch;

		public static float OvertimeElapsedTime;

		public static Vector3 CurrentBallPosition;

		private static bool _shouldHideTeamPlayers;

		private static bool _shouldHideOpposingTeamPlayers;

		public static MBall CurrentBallInArena;

		public static bool ShouldHideTeamPlayers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool ShouldHideOpposingTeamPlayers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static float AmmoRegenMultiplier { get; private set; }

		public static ArenaGoal[] TeamGoals { get; private set; }

		private static Dictionary<TeamNo, TeamScore> TeamScores { get; }

		public static event Action OnHasInitialSync
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

		public static event Action OnShouldHideTeamPlayersChanged
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

		public static event Action OnShouldHideOpposingTeamPlayersChanged
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

		public static TeamScore GetTeamScore(TeamNo teamNo)
		{
			return default(TeamScore);
		}

		public static void SetTeamScore(TeamNo teamNo, TeamScore teamScore)
		{
		}

		public static void ResetArenaSharedData(GameSettings gameSettings)
		{
		}

		public static void ResetFromDespawn(GameSettings defaultGameSettings)
		{
		}

		public static void NotifySharedDataHasInitialSync()
		{
		}

		public static void SetArenaGoals(ArenaGoal[] goals)
		{
		}
	}
}
