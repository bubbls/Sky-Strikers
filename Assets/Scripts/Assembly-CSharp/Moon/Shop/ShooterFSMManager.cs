using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon.Shop
{
	[NetworkBehaviourWeaved(0)]
	[RequireComponent(typeof(MFSM))]
	public class ShooterFSMManager : NetworkBehaviour
	{
		private const float BallRespawnDelayRange = 1f;

		[SerializeField]
		private TutorialBallSpawner[] _ballSpawner;

		[SerializeField]
		private ArenaGoal[] _goals;

		[SerializeField]
		private ShooterScoreStatistics _shooterScoreStatistics;

		private static Changed<ShooterFSMManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<ShooterFSMManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<ShooterFSMManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
		{
		}

		private void BallSpawner_OnBallSpawned(MBall ball)
		{
		}

		private void BallSpawner_OnBallEnteredDeadZone(MBall ball)
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void ArenaGoal_OnGoal(ArenaGoal goal, MBall ball)
		{
		}

		private bool CheckBall(MBall ball)
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
