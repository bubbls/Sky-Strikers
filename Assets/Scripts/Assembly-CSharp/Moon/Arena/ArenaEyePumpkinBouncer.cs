using DP.Takeaway.Sound;
using Fusion;
using Moon.GameActivity;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(4)]
	public class ArenaEyePumpkinBouncer : ArenaEyePumpkin
	{
		[DefaultForProperty("IsExploded", 1, 1)]
		private NetworkBool _IsExploded;

		[DefaultForProperty("WarningNetworkStruct", 2, 2)]
		private ArenaEyePumpkinBouncerWarningNetworkStruct _WarningNetworkStruct;

		[Header("Bounce")]
		[SerializeField]
		private GameObject _bouncer;

		[Header("Explosion")]
		[SerializeField]
		private float _explodeCountdownTime;

		[SerializeField]
		[Range(0f, 1f)]
		private float _reduceAmountFactor;

		[SerializeField]
		private float _warningTime;

		[SerializeField]
		private GameObject _localExplosionPrefab;

		[SerializeField]
		[Header("Visual")]
		private ArenaEyePumpkinBouncerLocalTear _localTear;

		[SerializeField]
		private ArenaEyePumpkinBouncerVisual _visual;

		[Header("Sound")]
		[SerializeField]
		private SoundInfo _countdownSoundInfo;

		[SerializeField]
		private SoundInfo _lastWarningSoundInfo;

		[SerializeField]
		private SoundInfo _tearDropSoundInfo;

		[SerializeField]
		[Header("Siplsets")]
		private MSiplets _mSipletsPrefab;

		[SerializeField]
		private Transform _spawnSipletsPoint;

		[SerializeField]
		private float _sipletsDelayTime;

		private const float ExplodeCountdownThreshold = 0.1f;

		private float _explodeCountdown;

		private int _explodeCountdownIndex;

		private bool _hasLocalExplosion;

		private LocalExplosion _localExplosion;

		private MSiplets _mSiplets;

		private bool _canSpawnSiplets;

		private bool _despawnManually;

		private static Changed<ArenaEyePumpkinBouncer> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<ArenaEyePumpkinBouncer> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<ArenaEyePumpkinBouncer> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "OnIsExplodedChanged")]
		[NetworkedWeaved(1, 1)]
		private NetworkBool IsExploded
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		[Networked(OnChanged = "OnWarningNetworkStructChanged")]
		[NetworkedWeaved(2, 2)]
		private ref ArenaEyePumpkinBouncerWarningNetworkStruct WarningNetworkStruct
		{
			get
			{
				throw null;
			}
		}

		private TickTimer ExplodeCountdownTime { get; set; }

		private TickTimer WarningTime { get; set; }

		private TickTimer SipletsDelayTime { get; set; }

		public override void Initialize(Vector3 direction, bool canSpawnSiplets = false)
		{
		}

		private void HandleOnTearHitGroundLocally()
		{
		}

		protected override void HandleOnSpawned()
		{
		}

		protected override void HandleOnDespawned()
		{
		}

		[Rpc]
		private void RPC_ReleaseLocalExplosion()
		{
		}

		private void ReleaseLocalExplosion()
		{
		}

		public void DespawnManually()
		{
		}

		protected override void HandleLifeTimeExpired()
		{
		}

		protected override void HandleDropOnTheGround()
		{
		}

		protected override void HandleServerFixedUpdateNetworkWhenOnTheGround()
		{
		}

		private void CreateLocalExplosion()
		{
		}

		protected override void HandleServerFixedUpdateNetwork()
		{
		}

		protected override void HandleOnIsOnTheGroundChanged()
		{
		}

		private void TryShowPlatformVisual()
		{
		}

		[Preserve]
		private static void OnIsExplodedChanged(Changed<ArenaEyePumpkinBouncer> changed)
		{
		}

		private void ToggleTearPlatformVisual()
		{
		}

		[Preserve]
		private static void OnWarningNetworkStructChanged(Changed<ArenaEyePumpkinBouncer> changed)
		{
		}

		private void HandleOnWarningNetworkStructChanged()
		{
		}

		private void TryDespawnSiplets()
		{
		}

		[Rpc]
		private void RPC_DespawnManually()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 7, 7)]
		[Preserve]
		protected unsafe static void RPC_ReleaseLocalExplosion_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 7, 7)]
		protected unsafe static void RPC_DespawnManually_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
