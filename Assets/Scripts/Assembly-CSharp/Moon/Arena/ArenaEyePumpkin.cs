using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(1)]
	public abstract class ArenaEyePumpkin : NetworkBehaviour
	{
		[DefaultForProperty("IsOnTheGround", 0, 1)]
		private NetworkBool _IsOnTheGround;

		[SerializeField]
		private float _minForce;

		[SerializeField]
		private float _maxForce;

		[SerializeField]
		private float _lifeTime;

		protected Rigidbody _rigidbody;

		private bool _isOnTheGround;

		private bool _canStartLifeTime;

		private Vector3 _initialForce;

		private static Changed<ArenaEyePumpkin> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<ArenaEyePumpkin> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<ArenaEyePumpkin> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "OnIsOnTheGroundChanged")]
		[NetworkedWeaved(0, 1)]
		protected NetworkBool IsOnTheGround
		{
			get
			{
				return default(NetworkBool);
			}
			private set
			{
			}
		}

		private TickTimer LifeTime { get; set; }

		public event Action<ArenaEyePumpkin> OnSpawned
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

		public event Action<ArenaEyePumpkin, bool> OnDespawned
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

		private void Awake()
		{
		}

		public virtual void Initialize(Vector3 direction, bool canSpawnSiplets = false)
		{
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		protected abstract void HandleOnSpawned();

		protected abstract void HandleOnDespawned();

		protected abstract void HandleLifeTimeExpired();

		protected virtual void HandleServerFixedUpdateNetwork()
		{
		}

		protected virtual void HandleServerFixedUpdateNetworkWhenOnTheGround()
		{
		}

		protected virtual void HandleDropOnTheGround()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void OnCollisionEnter(Collision other)
		{
		}

		protected void SendOnDespawnedEvent(bool despawnManually)
		{
		}

		[Preserve]
		private static void OnIsOnTheGroundChanged(Changed<ArenaEyePumpkin> changed)
		{
		}

		protected virtual void HandleOnIsOnTheGroundChanged()
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
