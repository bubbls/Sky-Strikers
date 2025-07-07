using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.Arena;
using Moon.Framework.Leaderboard;
using Moon.MultiPlay;
using Moon.PlayerProfile;
using UnityEngine;

namespace Moon
{
	public class PlayerLegacyStatsHandler : PlayerStatsHandler
	{
		[CompilerGenerated]
		private sealed class _003CDelayExitStatsTrackingAreaCoroutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerLegacyStatsHandler _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDelayExitStatsTrackingAreaCoroutine_003Ed__27(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const double MinTimeForAssist = 3.5;

		private const float MinTimeBetweenSaves = 1f;

		private ILeaderboard _leaderboard;

		private PlayerGoalStats _playerGoalStats;

		private PlayerMatchStats _playerMatchStats;

		private MPlayerStatsTracker _tracker;

		private NetworkRunner _runner;

		private TickTimer _lastSaveTimer;

		private bool _isInTeamGoalArea;

		private Location _teamGoalLocation;

		private bool _inStatsTrackingArea;

		private bool _isTrackingStats;

		private Coroutine _delayExitStatsTrackingAreaCoroutine;

		public PlayerLegacyStatsHandler(PlayerRef playerRef, string playFabId, PlayerInfo playerInfo, NetworkRunner networkRunner, MPlayerStatsTracker tracker)
			: base(default(PlayerRef), null, default(PlayerInfo))
		{
		}

		public override void StartTracking()
		{
		}

		private void ArenaSharedData_HandleOnHasInitialSync()
		{
		}

		public override void StopTracking()
		{
		}

		public override void OnMatchPrepare()
		{
		}

		public override void OnMatchStarted()
		{
		}

		public override void OnEnterStatsTrackingArea()
		{
		}

		public override void OnExitStatsTrackingArea()
		{
		}

		public override void OnMatchCelebrateGoal(GoalMessageData goalMessageData)
		{
		}

		public override void HandleLocalPlayerLocationChanged(PlayerLocationChangedMessage playerLocationChangedMessage)
		{
		}

		public override void HandleRocketFired(GeneralActionMessageData messageData)
		{
		}

		public override void HandleBallHit(BallHittableInfoMessageData ballHitMessageData)
		{
		}

		public override void OnMatchCompleted(MatchEndMessageData matchEndMessageData)
		{
		}

		private bool TryGetXpAndLevelStats(PlayerMatchStats matchStats, out Statistic stats)
		{
			stats = default(Statistic);
			return false;
		}

		[IteratorStateMachine(typeof(_003CDelayExitStatsTrackingAreaCoroutine_003Ed__27))]
		private IEnumerator DelayExitStatsTrackingAreaCoroutine()
		{
			return null;
		}

		private void UploadStats(List<Statistic> statsList)
		{
		}

		private List<Statistic> GetStatistics()
		{
			return null;
		}

		private void UploadStatOnMatchCompleted(MatchEndMessageData matchEndMessageData)
		{
		}

		private void ResetTickTimers()
		{
		}

		private void TryActiveStatsTracking()
		{
		}

		private void StopDelayExitStatsTrackingAreaCoroutine()
		{
		}

		private void DeactivateStatsTracking()
		{
		}

		private void ClearPlayerStats()
		{
		}
	}
}
