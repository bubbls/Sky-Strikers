using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(3)]
	public class MExplodingTrampoline : NetworkBehaviour
	{
		[DefaultForProperty("Lifetime", 0, 1)]
		[SerializeField]
		private float _Lifetime;

		[DefaultForProperty("Scale", 1, 1)]
		[SerializeField]
		private float _Scale;

		[DefaultForProperty("TimeTillExplode", 2, 1)]
		[SerializeField]
		private TickTimer _TimeTillExplode;

		[SerializeField]
		private float _scaleUpSpeed;

		[SerializeField]
		private float _scaleUpDuration;

		[SerializeField]
		private Transform _trampolineContainer;

		[SerializeField]
		private LocalExplosion _localExplosion;

		[SerializeField]
		private ExplodingTrampoline _explodingTrampolineVisualPrefab;

		[SerializeField]
		private ExplosionConfiguration _explosionConfiguration;

		private bool _isSpawned;

		private float _scaleUpEndTime;

		private float _currentRemainingTime;

		private float _lastTimeTillExplode;

		private bool _isExploded;

		private ExplodingTrampoline _explodingTrampolineVisual;

		private Vector3 _targetScale;

		private static Changed<MExplodingTrampoline> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MExplodingTrampoline> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MExplodingTrampoline> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 1)]
		[Networked]
		public float Lifetime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NetworkedWeaved(1, 1)]
		[Networked]
		public float Scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(2, 1)]
		public TickTimer TimeTillExplode
		{
			get
			{
				return default(TickTimer);
			}
			set
			{
			}
		}

		public event Action<MExplodingTrampoline> OnTrampolineSpawned
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

		public event Action<MExplodingTrampoline> OnTrampolineDespawned
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

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void LateUpdate()
		{
		}

		private void ResetTrampoline()
		{
		}

		private void TryToggleVisual(bool show)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_PlayWarning(float remainingTime)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_SpawnLocalExplosion()
		{
		}

		public void DespawnManually()
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
		protected unsafe static void Rpc_PlayWarning_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_SpawnLocalExplosion_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
