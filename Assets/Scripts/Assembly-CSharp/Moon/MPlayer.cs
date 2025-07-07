using System;
using System.Runtime.InteropServices;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Arena;
using Moon.Backpack;
using Moon.Interaction;
using Moon.MultiPlay;
using Moon.MultiPlay.Aoi;
using Moon.Player;
using Moon.Player.Ability;
using Moon.Player.Visual;
using Moon.PlayerProfile;
using Photon.Voice.Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon
{
	[NetworkBehaviourWeaved(13)]
	[OrderAfter(new Type[] { typeof(NetworkTransform) })]
	public class MPlayer : NetworkBehaviour, ICommandExecutor
	{
		[StructLayout((LayoutKind)2, Size = 16)]
		[NetworkStructWeaved(4)]
		public struct PlayerSpawnInfo : INetworkStruct
		{
			[FieldOffset(0)]
			public bool PlayerSpawned;

			[FieldOffset(4)]
			public Vector3 RespawnPosition;
		}

		public enum PlayerSpeakerVolume
		{
			Mute = 0,
			LevelOne = 1,
			LevelTwo = 2,
			LevelThree = 3,
			Max = 4
		}

		[SerializeField]
		private MNetworkRig _networkRig;

		[SerializeField]
		private VoiceNetworkObject _voiceNetworkObject;

		[SerializeField]
		private MPlayerHand _mPlayerLeftHand;

		[SerializeField]
		private MPlayerHand _mPlayerRightHand;

		[SerializeField]
		private MPlayerFx _mPlayerFx;

		[SerializeField]
		private MAmmoBox _mAmmoBox;

		[SerializeField]
		private HitboxRoot _hitboxRoot;

		[SerializeField]
		private Hitbox _bodyHitbox;

		[SerializeField]
		private AudioSource _speaker;

		[SerializeField]
		private MHitter[] _bodyHitters;

		[DefaultForProperty("RespawnPosition", 0, 3)]
		private Vector3 _RespawnPosition;

		[DefaultForProperty("RespawnRotation", 3, 4)]
		private Quaternion _RespawnRotation;

		[SerializeField]
		[DefaultForProperty("SpawnInfo", 7, 4)]
		private PlayerSpawnInfo _SpawnInfo;

		private LocalPlayerRig _localPlayerRig;

		[SerializeField]
		private MPlayerStatsTracker _playerStatsTracker;

		[SerializeField]
		private MGrabbableBackpack _playerBackpack;

		private IMessageSubscriber[] _subscribers;

		private bool _firstUpdate;

		private PlayerSpeakerVolume _speakerVolume;

		private bool _enableSpeakerManual;

		private bool _enableSpeakerAuto;

		private bool _isCulled;

		private Vector3 _bodyHitboxPos;

		private NetworkAoiProxy _networkAoiProxy;

		[DefaultForProperty("PlayerAbility", 11, 2)]
		private MPlayerAbility _PlayerAbility;

		private PlayerInputProcessor _playerInputProcessor;

		[SerializeField]
		private bool _acceptPortalTeleport;

		private static Changed<MPlayer> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayer> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayer> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public MNetworkRig NetworkRig => null;

		public MPlayerHand LeftHand => null;

		public MPlayerHand RightHand => null;

		public MAmmoBox AmmoBox => null;

		[NetworkedWeaved(0, 3)]
		[Networked]
		private Vector3 RespawnPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(3, 4)]
		private Quaternion RespawnRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public PlayerVisualsController PlayerVisualsController { get; private set; }

		[Networked(OnChanged = "OnRemoteNotifyPlayerSpawned")]
		[NetworkedWeaved(7, 4)]
		public PlayerSpawnInfo SpawnInfo
		{
			get
			{
				return default(PlayerSpawnInfo);
			}
			set
			{
			}
		}

		public MPlayerStatsTracker PlayerStatsTracker => null;

		public MGrabbableBackpack PlayerBackpack => null;

		public bool IsInitialized { get; private set; }

		public bool IsCulled => false;

		public bool IsSpeakerEnabled => false;

		public PlayerSpeakerVolume SpeakerVolume => default(PlayerSpeakerVolume);

		public PlayerRef PlayerRef => default(PlayerRef);

		[NetworkedWeaved(11, 2)]
		[Networked]
		private MPlayerAbility PlayerAbility
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PlayerInputProcessor InputProcessor => null;

		private bool PlayerVisible => false;

		public VoiceNetworkObject VoiceNetworkObject => null;

		private void Awake()
		{
		}

		public void InitializeBeforeSpawn(Vector3 position, Quaternion rotation)
		{
		}

		public override void Spawned()
		{
		}

		private void HandleOnSpawned()
		{
		}

		private void InitializePlayerVisualsController()
		{
		}

		private void HandleCollideWithDeadZone(IDeadzoneInfo deadzoneInfo)
		{
		}

		public void Teleport(Vector3 position, Quaternion rotation, bool keepVelocity = false, PlayerTeleportType teleportType = PlayerTeleportType.None)
		{
		}

		private void OnTeleported(Vector3 position, Quaternion rotation, PlayerTeleportType teleportType = PlayerTeleportType.None)
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void RegisterEventsToPlayerVisualsController(bool register)
		{
		}

		public PlayerInputData GetLocalPlayerInputData()
		{
			return default(PlayerInputData);
		}

		public override void FixedUpdateNetwork()
		{
		}

		public override void Render()
		{
		}

		public void AcceptInput(PlayerInputData inputData)
		{
		}

		private void UpdateInput(PlayerInputData inputData)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void RPC_PlayerSpawned(PlayerSpawnInfo spawnInfo)
		{
		}

		[Preserve]
		private static void OnRemoteNotifyPlayerSpawned(Changed<MPlayer> changed)
		{
		}

		private void UpdatePlayerSpawned()
		{
		}

		private void HandleAmmoBoxStatusChanged(WeaponType weaponType, MAmmoBox.Status status)
		{
		}

		private void PlayerVisualsController_OnHandVisualChanged(Transform pivot, PlayerSuitHandVisual suitHandVisual, bool isLeft)
		{
		}

		public void EnableSpeakerManual(bool enable)
		{
		}

		private void EnableSpeakerAuto(bool allowVoice)
		{
		}

		public void SetSpeakerVolume(PlayerSpeakerVolume volume)
		{
		}

		private void RefreshSpeakerMute()
		{
		}

		public bool IsHoldingGrabbableOfType(IGrabbable targetGrabbable)
		{
			return false;
		}

		public Vector3 GetInterpolatedBodyPosition()
		{
			return default(Vector3);
		}

		public Transform GetInterpolatedBodyTransform()
		{
			return null;
		}

		public Transform GetBodyTransform()
		{
			return null;
		}

		public Transform GetHeadTransform()
		{
			return null;
		}

		public Transform GetInterpolatedHeadTransform()
		{
			return null;
		}

		private void DespawnPlayerAbility()
		{
		}

		private void SpawnNewPlayerAbility(PlayerInfo playerInfo)
		{
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}

		private void HandlePlayerInfoChangedInternal(PlayerInfo oldPlayerInfo, PlayerInfo playerInfo)
		{
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		public bool TryToggleAOICull(bool isCulled, bool allowVoice)
		{
			return false;
		}

		private void OnNetworkAoiStateUpdated(bool isCulled)
		{
		}

		private bool RefreshAoiCull(bool isCulled)
		{
			return false;
		}

		public void ToggleHitboxes(bool enableHitbox)
		{
		}

		private static void HandleBeforeRenderPortalCamera(Camera portalCamera)
		{
		}

		private bool HandlePortalRequestTeleport(Vector3 position, Quaternion rotation)
		{
			return false;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 7, 1)]
		protected unsafe static void RPC_PlayerSpawned_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
