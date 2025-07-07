using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(7)]
	public class MVolleyballMatchController : MTeamBasedBallMatchControllerBase
	{
		[DefaultForProperty("IsNetShowing", 6, 1)]
		[SerializeField]
		private NetworkBool _IsNetShowing;

		[SerializeField]
		private Transform _teamOneBallSpawnerPoint;

		[SerializeField]
		private Transform _teamTwoBallSpawnerPoint;

		[SerializeField]
		private GameObject _volleyballWalls;

		[SerializeField]
		private GameObject _volleyballNet;

		private static Changed<MVolleyballMatchController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MVolleyballMatchController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MVolleyballMatchController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(6, 1)]
		public NetworkBool IsNetShowing
		{
			get
			{
				return default(NetworkBool);
			}
			private set
			{
			}
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void SyncToSharedData()
		{
		}

		protected override void SpawnBall(float ballSpawnDelay)
		{
		}

		protected override void DespawnBall()
		{
		}

		protected override bool IsMatchControllerActive()
		{
			return false;
		}

		public override GoalMessageData GetLastGoalInfo()
		{
			return null;
		}

		public override void HandlePrepareState(MFSM.Phase phase, float prepareStateRemainingTime)
		{
		}

		public override void StopMatchController()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_NotifyMatchControllerStopped()
		{
		}

		protected override void BallSpawner_OnBallSpawned(MBall ball)
		{
		}

		private void Ball_OnBallTaggedFromHit(BallTag ballTag, HittableHitInfo hitInfo)
		{
		}

		protected override void HandleOnGoalScoredInternal(MBall ball, int goalIndex, TeamNo scoringTeam)
		{
		}

		public void TryHideVolleyballNet()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyMatchControllerStopped_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
