using System;
using Fusion;
using Moon.Arena;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon
{
	[NetworkBehaviourWeaved(20)]
	[OrderAfter(new Type[] { typeof(HitboxManager) })]
	public abstract class MMissile : MProjectile, IPredictedSpawnBehaviour
	{
		[SerializeField]
		private LocalExplosion _explosion;

		[DefaultForProperty("NetworkedInputAuthority", 0, 1)]
		private PlayerRef _NetworkedInputAuthority;

		private PlayerRef _predictiveInputAuthority;

		[DefaultForProperty("NetworkedExplosionTargetTick", 1, 1)]
		private int _NetworkedExplosionTargetTick;

		private int _predictiveExplosionTargetTick;

		[DefaultForProperty("NetworkedTeamNo", 2, 1)]
		private TeamNo _NetworkedTeamNo;

		private TeamNo _predictedTeamNo;

		[DefaultForProperty("NetworkedVisualTheme", 3, 1)]
		private SuitVisualTheme _NetworkedVisualTheme;

		private SuitVisualTheme _predictedVisualTheme;

		[DefaultForProperty("NetworkedLastBullet", 4, 1)]
		private NetworkBool _NetworkedLastBullet;

		private bool _predictedLastBullet;

		[DefaultForProperty("NetworkedFirePosition", 5, 3)]
		private Vector3 _NetworkedFirePosition;

		private Vector3 _predictedFirePosition;

		[DefaultForProperty("NetworkedFireDirection", 8, 3)]
		private Vector3 _NetworkedFireDirection;

		private Vector3 _predictedFireDirection;

		[DefaultForProperty("NetworkedMPlayerHand", 11, 2)]
		private MPlayerHand _NetworkedMPlayerHand;

		private MPlayerHand _predictedMPlayerHand;

		[DefaultForProperty("NetworkedIsExploded", 13, 1)]
		private NetworkBool _NetworkedIsExploded;

		private bool _isExplodedLocally;

		[DefaultForProperty("NetworkedExplosionPosition", 14, 3)]
		private Vector3 _NetworkedExplosionPosition;

		private Vector3 _localExplosionPosition;

		[DefaultForProperty("NetworkedExplosionDirection", 17, 3)]
		private Vector3 _NetworkedExplosionDirection;

		private Vector3 _localExplosionDirection;

		private readonly MissileMovementHandler _movementHandler;

		private MissileLifetimeData _lifetimeData;

		private NetworkRunnerCallbacksForwarder _callbackForwarder;

		private bool _isMissileConfigured;

		private bool _isExplosionConfigured;

		private bool _isSpawnedOnServer;

		private MissileVisual _missileVisual;

		private static Changed<MMissile> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MMissile> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MMissile> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 1)]
		[Networked]
		private PlayerRef NetworkedInputAuthority
		{
			get
			{
				return default(PlayerRef);
			}
			set
			{
			}
		}

		public PlayerRef InputAuthority
		{
			get
			{
				return default(PlayerRef);
			}
			set
			{
			}
		}

		[NetworkedWeaved(1, 1)]
		[Networked]
		private int NetworkedExplosionTargetTick
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int ExplosionTargetTick
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[NetworkedWeaved(2, 1)]
		[Networked]
		private TeamNo NetworkedTeamNo
		{
			get
			{
				return default(TeamNo);
			}
			set
			{
			}
		}

		public TeamNo TeamNo
		{
			get
			{
				return default(TeamNo);
			}
			set
			{
			}
		}

		[NetworkedWeaved(3, 1)]
		[Networked]
		private SuitVisualTheme NetworkedVisualTheme
		{
			get
			{
				return default(SuitVisualTheme);
			}
			set
			{
			}
		}

		public SuitVisualTheme VisualTheme
		{
			get
			{
				return default(SuitVisualTheme);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(4, 1)]
		private NetworkBool NetworkedLastBullet
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		public bool LastBullet
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(5, 3)]
		private Vector3 NetworkedFirePosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 FirePosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[NetworkedWeaved(8, 3)]
		[Networked]
		private Vector3 NetworkedFireDirection
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 FireDirection
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
		[NetworkedWeaved(11, 2)]
		private MPlayerHand NetworkedMPlayerHand
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MPlayerHand MPlayerHand
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NetworkedWeaved(13, 1)]
		[Networked]
		private NetworkBool NetworkedIsExploded
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		[NetworkedWeaved(14, 3)]
		[Networked]
		private Vector3 NetworkedExplosionPosition
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
		[NetworkedWeaved(17, 3)]
		private Vector3 NetworkedExplosionDirection
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public override void Spawned()
		{
		}

		private void TryLoadMissileVisual()
		{
		}

		protected abstract MissileVisual LoadMissileVisual();

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private bool IsExploded()
		{
			return false;
		}

		private void DoUpdate(bool hasAuthority)
		{
		}

		private void HandleInitialConfiguration()
		{
		}

		public abstract MissileConfig GetMissileConfig();

		private void HandleDespawn()
		{
		}

		private void UnloadExplosion()
		{
		}

		public override void Render()
		{
		}

		private void TogglePredictedVisual(bool enable)
		{
		}

		private void ToggleFX(bool enable)
		{
		}

		private void TrySpawnExplosion()
		{
		}

		protected abstract ExplosionConfiguration GetExplosionConfiguration();

		protected abstract void LoadExplosionFx(in LocalExplosion explosion, TeamNo teamNo);

		void IPredictedSpawnBehaviour.PredictedSpawnSpawned()
		{
		}

		void IPredictedSpawnBehaviour.PredictedSpawnUpdate()
		{
		}

		void IPredictedSpawnBehaviour.PredictedSpawnRender()
		{
		}

		void IPredictedSpawnBehaviour.PredictedSpawnSuccess()
		{
		}

		void IPredictedSpawnBehaviour.PredictedSpawnFailed()
		{
		}

		private void OnDestroy()
		{
		}

		private void CallbackListener_OnServerShutdown(NetworkRunner networkRunner, ShutdownReason shutdownReason)
		{
		}

		private void RemoveCallbackListener()
		{
		}

		private void OnDrawGizmos()
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
