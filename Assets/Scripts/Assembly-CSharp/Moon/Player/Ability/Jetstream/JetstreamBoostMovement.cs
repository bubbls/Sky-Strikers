using System;
using DP.Takeaway.Utils;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Player.Ability.Jetstream
{
	[NetworkBehaviourWeaved(0)]
	[OrderAfter(new Type[] { typeof(MPlayerAbilityJetstream) })]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Host | SimulationModes.Client))]
	public class JetstreamBoostMovement : NetworkBehaviour
	{
		private const string NoJetstreamRechargeCollider = "NoJetstreamRechargeCollider";

		[SerializeField]
		private float _boostedConstantYForce;

		[SerializeField]
		private float _unboostedConstantYForce;

		[SerializeField]
		private float _playerMaxJumpSpeed;

		[SerializeField]
		private float _playerVelocityLimit;

		[SerializeField]
		private float _maxBoostSpeed;

		[SerializeField]
		private float _boostDuration;

		[SerializeField]
		private float _rechargeDelay;

		[SerializeField]
		private float _rechargeDuration;

		[SerializeField]
		private AnimationCurve _boostPowerCurve;

		[SerializeField]
		private ForceMode _playerForceMode;

		[SerializeField]
		private float _chargeFillSoundInterval;

		[SerializeField]
		private float _chargeSyncInterval;

		private JetstreamBoostChargeHandler _jetstreamBoostChargeHandler;

		private JetstreamBoostFxHandler _jetstreamBoostFxHandler;

		private PlayerLocomotionConfiguration _locomotionConfiguration;

		private Cooldown _chargeSyncIntervalCd;

		private Vector3 _cachedConstantForce;

		private LocalPlayerRig _localPlayerRig;

		private Transform _handForwardRef;

		private Vector3 _forceDirection;

		private JetstreamSuitThemeScheme _curVisualScheme;

		private float _curBoostPower;

		private float _cachedForce;

		private float _lastBoostChargeFillPlayTime;

		private bool _isInitialized;

		private bool _hasCurVisualScheme;

		private static Changed<JetstreamBoostMovement> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<JetstreamBoostMovement> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<JetstreamBoostMovement> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public bool IsBoosting { get; private set; }

		public MPlayerHand BoostingHand { get; private set; }

		public void Initialize()
		{
		}

		private void OnDisable()
		{
		}

		public void Reset()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		public void EnableBoostMode(MPlayerHand boostingHand)
		{
		}

		private void SetBoostingHand(MPlayerHand hand)
		{
		}

		private void HandleLocalBoostUpdate()
		{
		}

		public void DisableBoostMode()
		{
		}

		private void LocalPlayerRig_OnHandColliding(Transform hand, bool isLeft, RaycastHit hit)
		{
		}

		private void ChargeHandler_OnChargeFull()
		{
		}

		private void ChargeHandler_OnChargeEmpty()
		{
		}

		public void HandleOnPlayerSuitUpdated(MPlayer player, SuitVisualTheme visualTheme)
		{
		}

		private void ToggleBoostFx(MPlayerHand targetHand)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true, TickAligned = false)]
		private void Rpc_NotifyBoostFuelChanged(float charge)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true, TickAligned = false)]
		private void Rpc_ToggleBoostFx(MPlayerHand targetHand)
		{
		}

		private void ApplyInitialLocomotionConfiguration()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 2, 7)]
		protected unsafe static void Rpc_NotifyBoostFuelChanged_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 2, 7)]
		protected unsafe static void Rpc_ToggleBoostFx_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
