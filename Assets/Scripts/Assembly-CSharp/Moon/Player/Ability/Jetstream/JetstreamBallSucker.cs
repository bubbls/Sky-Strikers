using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.AI.VisualScripting;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Player.Ability.Jetstream
{
	[NetworkBehaviourWeaved(5)]
	[OrderBefore(new Type[] { typeof(MPlayerAbilityJetstream) })]
	[SimulationBehaviour(Stages = SimulationStages.Forward)]
	public class JetstreamBallSucker : NetworkBehaviour, IDisposable
	{
		[DefaultForProperty("NetworkedHand", 0, 2)]
		private MPlayerHand _NetworkedHand;

		[DefaultForProperty("NetworkedBall", 2, 2)]
		private MBall _NetworkedBall;

		[DefaultForProperty("NetworkedSuckTime", 4, 1)]
		private float _NetworkedSuckTime;

		[Header("Sucking")]
		[Space(7f)]
		[SerializeField]
		private JetstreamBallSuckerBallSlowArea _suckArea;

		[SerializeField]
		private ForceMode _suckForceMode;

		[SerializeField]
		private float _maxForceVelocity;

		[SerializeField]
		private float _maxSuckSpeed;

		[SerializeField]
		private float _suckForce;

		[SerializeField]
		[Header("Blast")]
		[Space(7f)]
		private AnimationCurve _blastPowerDistanceCurve;

		[SerializeField]
		private float _blastPowerNoAmmo;

		[SerializeField]
		private AnimationCurve _blastPowerWithAmmoCurve;

		[SerializeField]
		private ForceMode _blastForceModeWithAmmo;

		[SerializeField]
		private ForceMode _blastForceModeNoAmmo;

		[SerializeField]
		private JetstreamBallSuckerBallArea _blastArea;

		[SerializeField]
		private MJetstreamExplosion _jetstreamExplosion;

		[Header("Other")]
		[SerializeField]
		[Space(7f)]
		private MJetstreamWeaponController _leftHandWeaponController;

		[SerializeField]
		private MJetstreamWeaponController _rightHandWeaponController;

		[SerializeField]
		private float _ballDetectionAreaScaleDuration;

		[SerializeField]
		private Vector2 _bestShotNormalizedTimeRange;

		private MJetstreamWeaponController _currentWeaponController;

		private JetstreamAbilityFx _playmakerAbilityFx;

		private Vector3 _centerPointPosition;

		private bool _isInitialized;

		private bool _isSucking;

		private Transform _transform;

		private MPlayerHand _trackedHand;

		private List<LagCompensatedHit> _hits;

		private MBall _ball;

		private HittableHitInfo _cachedHittableHitInfo;

		private Vector3 _cachedBallForceDirection;

		private float _cachedBallForceMagnitude;

		private bool _isBallInBlastArea;

		private float _ballDetectionAreasScaleEndTime;

		private float _suckTime;

		private float _maxBlastPowerCurveDistance;

		private bool _curveDistanceSet;

		private float _cachedBlastPower;

		private bool _hasInputAuthority;

		private bool _hasStateAuthority;

		private bool _isInBestShotRange;

		private Vector3 _cachedBallMoveForce;

		private static Changed<JetstreamBallSucker> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<JetstreamBallSucker> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<JetstreamBallSucker> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "HandleOnNetworkedHandChanged")]
		[NetworkedWeaved(0, 2)]
		private MPlayerHand NetworkedHand
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Networked(OnChanged = "HandleOnNetworkedBallChanged")]
		[NetworkedWeaved(2, 2)]
		private MBall NetworkedBall
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(4, 1)]
		private float NetworkedSuckTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private MPlayer Player => null;

		public event Action<MPlayerHand, MBall, bool> OnSuckerShot
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

		public void Initialize(JetstreamAbilityFx jetstreamAbilityFx)
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public void Dispose()
		{
		}

		[ContextMenu("Set Max Blast Power Curve Distance")]
		private void SetMaxBlastPowerDistance()
		{
		}

		private void ResetSucker()
		{
		}

		public bool IsHandSucking(MPlayerHand hand)
		{
			return false;
		}

		public void StartSuck(MPlayerHand hand)
		{
		}

		private void FollowHand()
		{
		}

		public void TryShoot(MPlayerHand hand, PlayerInputData latestInputData)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority | RpcTargets.InputAuthority, InvokeResim = true)]
		private void Rpc_Shoot(MPlayerHand hand, PlayerInputData latestInputData)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.StateAuthority | RpcTargets.InputAuthority, InvokeResim = true)]
		private void Rpc_NotifyShotExecuted(MPlayerHand hand, MBall ball, bool usedAmmo, bool isInBestShotRange)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyBallShotFromBestRange(MPlayerHand hand)
		{
		}

		private void AddForceFromBlastToBall(Vector3 force, ForceMode forceMode)
		{
		}

		public void StopSuck(MPlayerHand hand)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		public override void Render()
		{
		}

		private void TrySuckBall()
		{
		}

		private bool CheckForOverlap(OverlapShapeDesc overlapShapeDesc, out List<LagCompensatedHit> hits)
		{
			hits = null;
			return false;
		}

		private void MoveBall(LagCompensatedHit lagCompensatedHit)
		{
		}

		[Preserve]
		private static void HandleOnNetworkedHandChanged(Changed<JetstreamBallSucker> changed)
		{
		}

		[Preserve]
		private static void HandleOnNetworkedBallChanged(Changed<JetstreamBallSucker> changed)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true, TickAligned = false)]
		private void Rpc_PlayBlastFx(MPlayerHand hand, bool usedAmmo, bool isLastAmmo)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyBallInBlastAreaStatusChanged(MPlayerHand hand, bool isInBlastArea)
		{
		}

		private void ScaleBallDetectionAreas()
		{
		}

		private void SetupBall(MBall ball)
		{
		}

		private void ClearBall()
		{
		}

		private void Ball_OnHit(PlayerInfo playerInfo, Vector3 force, HitSourceID hitSource)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.InputAuthority, InvokeResim = true)]
		private void Rpc_RestartSucking()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 2, 3)]
		[Preserve]
		protected unsafe static void Rpc_Shoot_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 1, 3)]
		[Preserve]
		protected unsafe static void Rpc_NotifyShotExecuted_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(3, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyBallShotFromBestRange_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(4, 2, 7)]
		protected unsafe static void Rpc_PlayBlastFx_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(5, 2, 7)]
		protected unsafe static void Rpc_NotifyBallInBlastAreaStatusChanged_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(6, 1, 2)]
		protected unsafe static void Rpc_RestartSucking_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
