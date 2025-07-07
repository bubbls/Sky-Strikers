using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon.Shop
{
	[NetworkBehaviourWeaved(3)]
	[RequireComponent(typeof(MFSM))]
	public class ShopFSMManager : NetworkBehaviour
	{
		private const float WaitTimeAfterGoal = 4f;

		private const float BallRespawnDelay = 3f;

		private const string StaFreePlay = "Match";

		private const string StaGoal = "Goal";

		[DefaultForProperty("PauseTimer", 0, 1)]
		private TickTimer _PauseTimer;

		[DefaultForProperty("CurBall", 1, 2)]
		private MBall _CurBall;

		[SerializeField]
		private MBallSpawner _ballSpawner;

		[SerializeField]
		private ArenaGoal _goal;

		private MFSM _mFsm;

		private static Changed<ShopFSMManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<ShopFSMManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<ShopFSMManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 1)]
		private TickTimer PauseTimer
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
		private MBall CurBall
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public override void Spawned()
		{
		}

		private void BallSpawner_OnBallSpawned(MBall ball)
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void SetInitialStateAfterSpawned()
		{
		}

		private void S_FreePlay(MFSM.Phase phase)
		{
		}

		private void ArenaGoal_OnGoal(ArenaGoal goal, MBall ball)
		{
		}

		private void S_Goal(MFSM.Phase phase)
		{
		}

		private bool T_GoalToCountDown()
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
