using System;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Player.Ability.Jetstream
{
	[NetworkBehaviourWeaved(0)]
	[SimulationBehaviour(Modes = (SimulationModes.Server | SimulationModes.Host), Stages = SimulationStages.Forward)]
	public class JetstreamBlastedBallController : NetworkBehaviour
	{
		[SerializeField]
		private float _controlTime;

		[SerializeField]
		private float _force;

		[SerializeField]
		private float _handPositionUpdateSpeed;

		[SerializeField]
		private float _maxForceMagnitude;

		[SerializeField]
		private float _forwardForceMultiplier;

		[SerializeField]
		private float _rightForceMultiplier;

		private MPlayerHand _trackedHand;

		private MBall _trackedBall;

		private JetstreamBallShotControlFx _ballControlFx;

		private HittableHitInfo _cachedHittableHitInfo;

		private Vector3 _curHandMoveVelocity;

		private double _startTrackingTime;

		private PlayerInputData _latestInputData;

		private Transform _headTransform;

		private JetstreamAbilityFx _playmakerAbilityFx;

		private Vector3 _ballStartPosition;

		private Vector3 _cachedTargetVelocity;

		private Vector3 _cachedForward;

		private Vector3 _cachedForce;

		private static Changed<JetstreamBlastedBallController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<JetstreamBlastedBallController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<JetstreamBlastedBallController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public bool IsControllingBall { get; private set; }

		public event Action<MPlayerHand> OnBallControlTimeExpired
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

		public void Initialize(JetstreamAbilityFx playmakerAbilityFx)
		{
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public void StartControllingBall(MPlayerHand trackedHand, MBall ball, PlayerInputData latestInputData)
		{
		}

		private void Ball_OnDespawned()
		{
		}

		public bool IsHandControllingBall(MPlayerHand hand)
		{
			return false;
		}

		public void UpdateInput(PlayerInputData latestInputData)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void ControlBall()
		{
		}

		private bool CanControlBall()
		{
			return false;
		}

		public void StopControllingBall()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyControllingBall(MPlayerHand hand, MBall ball, double controlStartTime)
		{
		}

		public override void Render()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyStopControllingBall(bool didControlTimeExpire)
		{
		}

		private void ToggleFxs(bool isOn)
		{
		}

		private void ClearEvents()
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
		protected unsafe static void Rpc_NotifyControllingBall_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyStopControllingBall_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
