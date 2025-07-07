using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(6)]
	public abstract class MTeamBasedBallMatchControllerBase : MMatchController
	{
		[DefaultForProperty("LastGoalTeam", 2, 1)]
		private TeamNo _LastGoalTeam;

		[DefaultForProperty("CurBallInArena", 3, 2)]
		private MBall _CurBallInArena;

		[DefaultForProperty("LastGoalIndex", 5, 1)]
		private int _LastGoalIndex;

		[SerializeField]
		protected MBallSpawner _ballSpawner;

		[SerializeField]
		protected MTeamScoreTracker _teamScoreTracker;

		[SerializeField]
		protected ArenaGoalListener _goalListener;

		private TeamScoresUpdatedMessageData _messageData;

		private bool _isInMatchState;

		private static Changed<MTeamBasedBallMatchControllerBase> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MTeamBasedBallMatchControllerBase> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MTeamBasedBallMatchControllerBase> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(2, 1)]
		protected TeamNo LastGoalTeam
		{
			get
			{
				return default(TeamNo);
			}
			set
			{
			}
		}

		[NetworkedWeaved(3, 2)]
		[Networked(OnChanged = "HandleOnCurBallInArenaChanged")]
		protected MBall CurBallInArena
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NetworkedWeaved(5, 1)]
		[Networked]
		protected int LastGoalIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override void Initialize()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void SyncToSharedData()
		{
		}

		public override void ResetForMatch(GameSettings gameSettings)
		{
		}

		protected abstract void SpawnBall(float ballSpawnDelay);

		protected virtual void DespawnBall()
		{
		}

		public override void StopMatchController()
		{
		}

		public override void HandlePrepareState(MFSM.Phase phase, float prepareStateRemainingTime)
		{
		}

		public override void HandleNextRoundCountdown(MFSM.Phase phase, float remainingTime)
		{
		}

		public override void HandleMatchState(MFSM.Phase phase)
		{
		}

		public override void HandleMatchEndState(MFSM.Phase phase)
		{
		}

		private void GoalListener_OnGoalScored(MBall ball, int goalIndex, TeamNo scoringTeam)
		{
		}

		protected virtual void HandleOnGoalScoredInternal(MBall ball, int goalIndex, TeamNo scoringTeam)
		{
		}

		public override void Render()
		{
		}

		public override TeamNo GetWinnerInfo()
		{
			return default(TeamNo);
		}

		private void TeamScoreTracker_OnTeamScoresUpdated(TeamScore scoreOne, TeamScore scoreTwo)
		{
		}

		protected virtual void BallSpawner_OnBallSpawned(MBall ball)
		{
		}

		protected ArenaGoal GetGoalAtIndex(int index)
		{
			return null;
		}

		[Preserve]
		private static void HandleOnCurBallInArenaChanged(Changed<MTeamBasedBallMatchControllerBase> changed)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
