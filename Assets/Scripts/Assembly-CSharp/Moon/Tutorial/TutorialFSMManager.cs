using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon.Tutorial
{
	[NetworkBehaviourWeaved(3)]
	[RequireComponent(typeof(MFSM))]
	public class TutorialFSMManager : NetworkBehaviour
	{
		private const float WaitTimeAfterGoal = 1f;

		private const float BallRespawnDelay = 1f;

		private const string FreePlayState = "Match";

		private const string GoalState = "Goal";

		[DefaultForProperty("GoalStateTransferToFreePlayStateTimer", 0, 1)]
		private TickTimer _GoalStateTransferToFreePlayStateTimer;

		[DefaultForProperty("CurrentBall", 1, 2)]
		private MBall _CurrentBall;

		[SerializeField]
		private MBallSpawner _ballSpawner;

		[SerializeField]
		private List<ArenaGoal> _tutorialGoals;

		private MFSM _mFsm;

		private ArenaGoal _currentGoal;

		private static Changed<TutorialFSMManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<TutorialFSMManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<TutorialFSMManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 1)]
		private TickTimer GoalStateTransferToFreePlayStateTimer
		{
			get
			{
				return default(TickTimer);
			}
			set
			{
			}
		}

		[NetworkedWeaved(1, 2)]
		[Networked]
		private MBall CurrentBall
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<ArenaGoal> TutorialGoals => null;

		public int GoalCount => 0;

		public event Action<ArenaGoal> OnTutorialGoaled
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void BallSpawner_HandleOnBallSpawned(MBall ball)
		{
		}

		public void ResetBall()
		{
		}

		public override void Spawned()
		{
		}

		private void TutorialGoal_HandleOnGoal(ArenaGoal goal, MBall ball)
		{
		}

		private void HandleOnFreePlayState(MFSM.Phase phase)
		{
		}

		private void HandleOnGoalState(MFSM.Phase phase)
		{
		}

		private bool HandleOnGoalToCountDown()
		{
			return false;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
