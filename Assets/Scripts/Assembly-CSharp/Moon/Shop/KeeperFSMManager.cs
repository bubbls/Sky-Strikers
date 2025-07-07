using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon.Shop
{
	[NetworkBehaviourWeaved(0)]
	[RequireComponent(typeof(MFSM))]
	public class KeeperFSMManager : NetworkBehaviour
	{
		private const float BallRespawnDelayRange = 3f;

		[SerializeField]
		private TutorialBallSpawner[] _ballSpawner;

		[SerializeField]
		private ArenaGoal[] _goals;

		[SerializeField]
		private Transform[] _respawnPoint;

		[SerializeField]
		private KeeperScoreStatistics _keeperScoreStatistics;

		private Vector3 _curRespawnPoint;

		public Transform respawnPointsParent;

		private static Changed<KeeperFSMManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<KeeperFSMManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<KeeperFSMManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

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

		[ContextMenu("GetRespawnPoint")]
		public void GetVisuals()
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
