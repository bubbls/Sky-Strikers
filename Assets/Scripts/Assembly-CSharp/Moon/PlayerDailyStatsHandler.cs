using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using Moon.Framework.Leaderboard;
using Moon.MultiPlay;
using Moon.PlayerProfile;
using UnityEngine;

namespace Moon
{
	public class PlayerDailyStatsHandler : PlayerStatsHandler
	{
		[CompilerGenerated]
		private sealed class _003CDelayExitStatsTrackingAreaCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerDailyStatsHandler _003C_003E4__this;

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
			public _003CDelayExitStatsTrackingAreaCoroutine_003Ed__23(int _003C_003E1__state)
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

		private const float MinTimeBetweenSaves = 1f;

		private PlayerGoalStats _playerGoalStats;

		private NetworkRunner _runner;

		private ILeaderboard _leaderboard;

		private readonly Stopwatch _matchPlayTime;

		private bool _isInTeamGoalArea;

		private Location _teamGoalLocation;

		private TickTimer _lastSaveTimer;

		private bool _inStatsTrackingArea;

		private bool _isTrackingStats;

		private MPlayerStatsTracker _tracker;

		private Coroutine _delayExitStatsTrackingAreaCoroutine;

		private IMessageSubscriber[] _subscribers;

		private bool _didParticipateInMatch;

		public PlayerDailyStatsHandler(PlayerRef playerRef, string playFabId, PlayerInfo playerInfo, NetworkRunner networkRunner, MPlayerStatsTracker tracker)
			: base(default(PlayerRef), null, default(PlayerInfo))
		{
		}

		public override void StartTracking()
		{
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
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

		public override void OnEnterStatsTrackingArea()
		{
		}

		public override void OnExitStatsTrackingArea()
		{
		}

		private void StopDelayExitStatsTrackingAreaCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayExitStatsTrackingAreaCoroutine_003Ed__23))]
		private IEnumerator DelayExitStatsTrackingAreaCoroutine()
		{
			return null;
		}

		public override void HandleLocalPlayerLocationChanged(PlayerLocationChangedMessage playerLocationChangedMessage)
		{
		}

		public override void HandleRocketFired(GeneralActionMessageData messageData)
		{
		}

		public override void OnMatchStarted()
		{
		}

		public override void OnMatchCelebrateGoal(GoalMessageData goalMessageData)
		{
		}

		public override void OnMatchCompleted(MatchEndMessageData matchEndMessageData)
		{
		}

		public override void HandleBallHit(BallHittableInfoMessageData ballHitMessageData)
		{
		}

		private void UploadStats()
		{
		}

		private void TryActiveStatsTracking()
		{
		}

		private void DeactivateStatsTracking()
		{
		}

		private List<Statistic> GetAllStatistics()
		{
			return null;
		}

		private void ClearPlayerStats()
		{
		}

		private void ResetTickTimers()
		{
		}
	}
}
