using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Sound;
using Fusion;
using Moon.Arena;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(46)]
	public class MHubArenaPortalsController : MHubArenaFieldObject, IElementReaderWriter<MHubArenaPortal>
	{
		private const string HubPointsName = "HubArenaPortalPoints";

		private const int MaxPortals = 8;

		[DefaultForProperty("Interval", 2, 1)]
		private TickTimer _Interval;

		[SerializeField]
		[DefaultForProperty("ActivePortals", 3, 43)]
		private MHubArenaPortal[] _ActivePortals;

		[SerializeField]
		private MHubArenaPortal _portalPrefab;

		[SerializeField]
		private SoundInfo _playerTeleportedSfx;

		[SerializeField]
		private SoundInfo _ballTeleportedSfx;

		[SerializeField]
		private int _minPortals;

		[SerializeField]
		private int _maxPortals;

		[SerializeField]
		private float _portalLifetime;

		[SerializeField]
		private float _intervalBetweenPortals;

		[SerializeField]
		private float _initialSpawnDelay;

		private bool _isConfigured;

		private bool _canSpawn;

		private IMessageSubscriber _messageSubscriber;

		private HubArenaPortalPoints _hubArenaPortalPoints;

		private static Changed<MHubArenaPortalsController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaPortalsController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaPortalsController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(2, 1)]
		private TickTimer Interval
		{
			get
			{
				return default(TickTimer);
			}
			set
			{
			}
		}

		[Capacity(10)]
		[NetworkedWeaved(3, 43)]
		[Networked]
		public NetworkLinkedList<MHubArenaPortal> ActivePortals => default(NetworkLinkedList<MHubArenaPortal>);

		public override void Spawned()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		protected override void AnimateIn(float duration)
		{
		}

		protected override void AnimateOut(float duration)
		{
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void StartSpawningPortalsTimer()
		{
		}

		private void SpawnPortals()
		{
		}

		private void SpawnPortal(Vector3 position, Quaternion rotation)
		{
		}

		private void Portal_OnPortalUsed(MHubArenaPortal portal, int portalTravellerLayer)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_PlayTeleportedSfx(int layer, Vector3 teleportToPoint)
		{
		}

		private void Portal_OnPortalSpawned(MHubArenaPortal portal)
		{
		}

		private void Portal_OnPortalDespawned(MHubArenaPortal portal)
		{
		}

		private void DespawnAllPortals()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		unsafe MHubArenaPortal IElementReaderWriter<MHubArenaPortal>.Read(byte* data, int index)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		unsafe ref MHubArenaPortal IElementReaderWriter<MHubArenaPortal>.ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		unsafe void IElementReaderWriter<MHubArenaPortal>.Write(byte* data, int index, MHubArenaPortal val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		int IElementReaderWriter<MHubArenaPortal>.GetElementWordCount()
		{
			return 0;
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 1, 7)]
		protected unsafe static void Rpc_PlayTeleportedSfx_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
