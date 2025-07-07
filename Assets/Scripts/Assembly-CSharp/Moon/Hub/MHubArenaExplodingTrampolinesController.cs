using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using UnityEngine;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(38)]
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Server | SimulationModes.Host))]
	public class MHubArenaExplodingTrampolinesController : MHubArenaFieldObject, IElementReaderWriter<MExplodingTrampoline>
	{
		private const int TrampolineLimit = 8;

		[DefaultForProperty("Interval", 2, 1)]
		private TickTimer _Interval;

		[DefaultForProperty("ActiveTrampolines", 3, 35)]
		[SerializeField]
		private MExplodingTrampoline[] _ActiveTrampolines;

		[SerializeField]
		private Transform _spawnPoint;

		[Header("Initial Delay (seconds)")]
		[SerializeField]
		private float _initialSpawnDelay;

		[SerializeField]
		[Header("Interval (seconds)")]
		private int _minInterval;

		[SerializeField]
		private int _maxInterval;

		[Header("Spawn Single Trampoline Interval (seconds)")]
		[SerializeField]
		private float _spawnSingleTrampolineInterval;

		[SerializeField]
		private Vector2 _trampolineLifetime;

		[Header("Amount")]
		[SerializeField]
		private int _minAmount;

		[Header("Area")]
		[SerializeField]
		private float _xRadius;

		[SerializeField]
		private float _zRadius;

		[SerializeField]
		private float _minAngleVariation;

		[SerializeField]
		private float _groundPos;

		[SerializeField]
		[Header("Pumpkin")]
		private MExplodingTrampoline _mExplodingTrampolinePrefab;

		private Vector3[] _spawnPositions;

		private bool _canSpawn;

		private int _currentTrampolineAmount;

		private int _explodedTrampolines;

		private int _currentTrampolineIndex;

		private float _currentSpawnSingleTrampolineTimer;

		private IMessageSubscriber _messageSubscriber;

		private static Changed<MHubArenaExplodingTrampolinesController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaExplodingTrampolinesController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaExplodingTrampolinesController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(2, 1)]
		[Networked]
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

		[NetworkedWeaved(3, 35)]
		[Networked]
		[Capacity(8)]
		public NetworkLinkedList<MExplodingTrampoline> ActiveTrampolines => default(NetworkLinkedList<MExplodingTrampoline>);

		public override void Spawned()
		{
		}

		protected override void AnimateIn(float duration)
		{
		}

		protected override void AnimateOut(float duration)
		{
		}

		private void OnDisable()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void SpawnTrampoline()
		{
		}

		private void HandleOnTrampolineSpawned(MExplodingTrampoline trampoline)
		{
		}

		private void HandleOnTrampolineDespawned(MExplodingTrampoline trampoline)
		{
		}

		private void GenerateRandomDirections()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void StartEyeSpawningPumpkins()
		{
		}

		private void PrepareForSpawning()
		{
		}

		private void DespawnAllCurrentPumpkins()
		{
		}

		[ContextMenu("Moon/Respawn Trampolines")]
		private void RespawnTrampolines()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		unsafe MExplodingTrampoline IElementReaderWriter<MExplodingTrampoline>.Read(byte* data, int index)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		unsafe ref MExplodingTrampoline IElementReaderWriter<MExplodingTrampoline>.ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		unsafe void IElementReaderWriter<MExplodingTrampoline>.Write(byte* data, int index, MExplodingTrampoline val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		int IElementReaderWriter<MExplodingTrampoline>.GetElementWordCount()
		{
			return 0;
		}
	}
}
