using Fusion;
using Moon.Arena;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(5)]
	public abstract class MHubArenaFieldObjectSpawner : NetworkBehaviour
	{
		private const float DespawnDelay = 2f;

		[SerializeField]
		[DefaultForProperty("FieldObject", 0, 2)]
		private MHubArenaFieldObject _FieldObject;

		[SerializeField]
		private float _animateInDuration;

		[SerializeField]
		private float _animateOutDuration;

		[DefaultForProperty("OldFieldObject", 2, 2)]
		private MHubArenaFieldObject _OldFieldObject;

		[DefaultForProperty("DespawnTimer", 4, 1)]
		private TickTimer _DespawnTimer;

		[SerializeField]
		private GameObjectLODGroup _sharedLodGroup;

		private GameObjectLODListener[] _registeredLodListeners;

		private static Changed<MHubArenaFieldObjectSpawner> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaFieldObjectSpawner> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaFieldObjectSpawner> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 2)]
		[Networked]
		public MHubArenaFieldObject FieldObject
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(2, 2)]
		private MHubArenaFieldObject OldFieldObject
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
		private TickTimer DespawnTimer
		{
			get
			{
				return default(TickTimer);
			}
			set
			{
			}
		}

		public override void Spawned()
		{
		}

		public void Spawn(GameSettings gameSettings)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_NotifyFieldObjectSpawnStateChanged(MHubArenaFieldObject fieldObject, bool isSpawned)
		{
		}

		private void UpdateRegisteredLOD(MHubArenaFieldObject fieldObject, bool isSpawned)
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public void Despawn()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		protected abstract bool ShouldChangeFieldObject(GameSettings gameSettings);

		protected abstract bool TryGetPrefabToSpawn(GameSettings gameSettings, out GameObject prefab, out Transform spawnPoint);

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 1, 7)]
		protected unsafe static void Rpc_NotifyFieldObjectSpawnStateChanged_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
