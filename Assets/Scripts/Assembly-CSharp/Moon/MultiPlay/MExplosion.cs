using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon.MultiPlay
{
	[RequireComponent(typeof(NetworkTransform))]
	[NetworkBehaviourWeaved(1)]
	public abstract class MExplosion : NetworkBehaviour, IPredictedSpawnBehaviour
	{
		[DefaultForProperty("NetworkedInputAuthority", 0, 1)]
		private PlayerRef _NetworkedInputAuthority;

		private PlayerRef _predictiveInputAuthority;

		[SerializeField]
		private LocalExplosion _explosion;

		private bool _isInitialized;

		private static Changed<MExplosion> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MExplosion> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MExplosion> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 1)]
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

		public override void Spawned()
		{
		}

		private void TryInitialize()
		{
		}

		protected abstract void LoadExplosionFx(in LocalExplosion explosion, TeamNo teamNo);

		protected virtual LayerMask GetExplosionQueryMask()
		{
			return default(LayerMask);
		}

		protected virtual ExplosionConfiguration GetExplosionConfiguration()
		{
			return null;
		}

		public override void FixedUpdateNetwork()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void HandleDespawn()
		{
		}

		void IPredictedSpawnBehaviour.PredictedSpawnSpawned()
		{
		}

		void IPredictedSpawnBehaviour.PredictedSpawnUpdate()
		{
		}

		void IPredictedSpawnBehaviour.PredictedSpawnRender()
		{
		}

		void IPredictedSpawnBehaviour.PredictedSpawnFailed()
		{
		}

		void IPredictedSpawnBehaviour.PredictedSpawnSuccess()
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
