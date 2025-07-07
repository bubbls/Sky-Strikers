using DP.Takeaway.Sound;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(5)]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	public class MHubArenaLavaGround : MHubArenaFieldObject
	{
		private static readonly int _maskOffset;

		[DefaultForProperty("GroundSize", 2, 1)]
		[SerializeField]
		private float _GroundSize;

		[SerializeField]
		[DefaultForProperty("TargetGroundSize", 3, 1)]
		private float _TargetGroundSize;

		[SerializeField]
		[DefaultForProperty("ScaleDuration", 4, 1)]
		private float _ScaleDuration;

		[SerializeField]
		private MeshRenderer _laveMeshRenderer;

		[SerializeField]
		private float _scaleSyncLerp;

		[SerializeField]
		private LavaGroundDeadzone _lavaGroundDeadzone;

		[SerializeField]
		private LavaGroundCollider _ballCollider;

		[SerializeField]
		private float _maxBallVelocityForForce;

		[SerializeField]
		private float _forceToAddOnBall;

		[SerializeField]
		private GameObject _lavaPushBallFxPrefab;

		[SerializeField]
		private ForceMode _forceMode;

		[SerializeField]
		private float _randomForceChance;

		[SerializeField]
		private ForceMode _randomForceMode;

		[SerializeField]
		private float _randomForce;

		[SerializeField]
		private SoundInfo _ballPushSfx;

		[SerializeField]
		private SoundInfo _playerLavaJumpSfx;

		[SerializeField]
		private GameObject _playerBurnedFxPrefab;

		[SerializeField]
		private float _playerBurnedFxOffset;

		private float _startValue;

		private float _elapsedTime;

		private bool _isSpawned;

		private float _currentValue;

		private static Changed<MHubArenaLavaGround> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaLavaGround> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaLavaGround> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(2, 1)]
		[Networked]
		public float GroundSize
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		[NetworkedWeaved(3, 1)]
		[Networked]
		public float TargetGroundSize
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		[NetworkedWeaved(4, 1)]
		[Networked]
		public float ScaleDuration
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		protected override void AnimateIn(float duration)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void LateUpdate()
		{
		}

		protected override void AnimateOut(float duration)
		{
		}

		private void SetLavaMaterialOffset(float val)
		{
		}

		[ContextMenu("Moon/Debug animate in")]
		private void DebugAnimateIn()
		{
		}

		[ContextMenu("Moon/Debug animate out")]
		private void DebugAnimateOut()
		{
		}

		private void BallCollider_OnBallCollided(MBall ball, Collision collision)
		{
		}

		private Vector3 CalcForceForBall(Vector3 velocity, float force)
		{
			return default(Vector3);
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void RPC_HandleOnCollisionEnter(Vector3 fxPoint)
		{
		}

		private void LavaGroundDeadzone_OnPlayerDidLavaJump(Vector3 touchPos)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.All)]
		private void RPC_HandleOnPlayerTouchedDeadzone(Vector3 fxPoint)
		{
		}

		private void PlayFx(Vector3 fxPoint, GameObject fx, SoundInfo soundInfo)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(3, 1, 7)]
		[Preserve]
		protected unsafe static void RPC_HandleOnCollisionEnter_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(4, 7, 7)]
		protected unsafe static void RPC_HandleOnPlayerTouchedDeadzone_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
