using Chamber8.Framework.Messaging;
using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Arena;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon
{
	[NetworkBehaviourWeaved(0)]
	public class MPlayerFx : NetworkBehaviour
	{
		[SerializeField]
		private SoundInfo _sfxGrab;

		[SerializeField]
		private SoundInfo _sfxFootstep;

		[SerializeField]
		private SoundInfo _sfxFootstepBig;

		[SerializeField]
		private SoundInfo _sfxFootstepLava;

		[SerializeField]
		private float _bigStepSpeed;

		[SerializeField]
		private float _footstepHapticAmp;

		[SerializeField]
		private float _footstepHapticDuration;

		[SerializeField]
		private float _footstepHapticFreq;

		private readonly Cooldown _footstepCd;

		private bool _wasLeftHandColliding;

		[SerializeField]
		private SoundInfo _sfxJump;

		[SerializeField]
		private float _jumpSpeedThreshold;

		private bool _jumping;

		[SerializeField]
		private SoundInfo _sfxFallsToGround;

		[SerializeField]
		private GameObject _vfxFallsToGround;

		private readonly Cooldown _fallsToGroundCd;

		[SerializeField]
		private SoundInfo _sfxDeadZoneTeleport;

		[SerializeField]
		private GameObject _undergroundSmokeFxPrefab;

		[SerializeField]
		private float _groundHeight;

		[SerializeField]
		private SoundInfo _sfxSwingBat;

		[SerializeField]
		private NetworkTransform _mBody;

		[SerializeField]
		private NetworkTransform _mLeftHand;

		[SerializeField]
		private NetworkTransform _mRightHand;

		[SerializeField]
		private float _spawnHeight;

		private GameObject _undergroundSmokeFx;

		private bool _isSpawned;

		private LocalPlayerRig _localPlayerRig;

		private IMessageSubscriber[] _subscribers;

		private Cooldown _teleportVfxCd;

		private Vector3 _lastTeleportVfxPos;

		private SurfaceTag _cachedSurfaceTag;

		private Vector3 _lastLeftHitPosition;

		private Vector3 _lastRightHitPosition;

		private const float MinHandCollisionMagnitude = 0.12f;

		private static Changed<MPlayerFx> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerFx> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerFx> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private int HandleLocalPlayerLocationChanged(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		public void SetLocalPlayerRig(LocalPlayerRig localPlayerRig)
		{
		}

		private void UpdateJumping()
		{
		}

		private void HandleFallsToGround()
		{
		}

		private void HandleHandColliding(Transform _, bool isLeft, RaycastHit hitInfo)
		{
		}

		private void HandleRaiseHandColliding(RaycastHit hitInfo, bool isLeft)
		{
		}

		private static bool CheckHandCollisionMagnitude(in Vector3 hitPosition, in Vector3 lastHitPosition)
		{
			return false;
		}

		[Rpc(RpcSources.All, RpcTargets.InputAuthority)]
		private void RPC_RaisePlayerJump()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.InputAuthority)]
		private void RPC_RaiseHandColliding(bool isLeft, float speed, int layer, SurfaceTagType surfaceTag, RpcInfo rpcInfo)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.InputAuthority)]
		private void RPC_RaiseFallsToGround()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.All, InvokeResim = true)]
		private void RPC_PlayRemoteTeleportFx(SuitVisualTheme playerVisualTheme, TeamNo playerTeamNo, Vector3 position, PlayerTeleportType teleportType)
		{
		}

		public void PlayTeleportFx(SuitVisualTheme playerVisualTheme, TeamNo playerTeamNo, Vector3 position, PlayerTeleportType teleportType)
		{
		}

		public void HandleTeleportFx(SuitVisualTheme playerVisualTheme, TeamNo playerTeamNo, Vector3 position, PlayerTeleportType teleportType)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 7, 2)]
		protected unsafe static void RPC_RaisePlayerJump_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 7, 2)]
		[Preserve]
		protected unsafe static void RPC_RaiseHandColliding_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 7, 2)]
		protected unsafe static void RPC_RaiseFallsToGround_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(4, 7, 7)]
		[Preserve]
		protected unsafe static void RPC_PlayRemoteTeleportFx_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
