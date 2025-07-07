using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(1)]
	public class ArenaEyeManager : NetworkBehaviour
	{
		[DefaultForProperty("Interval", 0, 1)]
		private TickTimer _Interval;

		[SerializeField]
		private Transform _spawnPoint;

		[Header("Initial Delay (seconds)")]
		[SerializeField]
		private float _initialSpawnDelay;

		[Header("Interval (seconds)")]
		[SerializeField]
		private int _minInterval;

		[SerializeField]
		private int _maxInterval;

		[SerializeField]
		[Header("Spawn Single Pumpkin Interval (seconds)")]
		private float _spawnSinglePumpkinInterval;

		[Header("Amount")]
		[SerializeField]
		private int _minAmount;

		[SerializeField]
		private int _maxAmount;

		[Range(0f, 0.5f)]
		[Header("Area")]
		[SerializeField]
		private float _limitAnglePercentage;

		[Header("Pumpkin")]
		[SerializeField]
		private ArenaEyePumpkinBouncer _pumpkinBouncerPrefab;

		[Header("Eye")]
		[SerializeField]
		private ArenaEyeStateMachine _eyeStateMachine;

		private Vector3[] _directions;

		private bool _canSpawn;

		private int _currentPumpkinAmount;

		private int _explodedPumpkins;

		private int _currentPumpkinIndex;

		private float _currentSpawnSinglePumpkinTimer;

		private bool _startFreePlay;

		private bool _celebratingGoal;

		private bool _startMatch;

		private bool _startSpawnTears;

		private bool _canSpawnSiplets;

		private bool _isActive;

		private bool _justSpawned;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private readonly Dictionary<NetworkId, ArenaEyePumpkinBouncer> _pumpkins;

		private static Changed<ArenaEyeManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<ArenaEyeManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<ArenaEyeManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 1)]
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void Spawned()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void SpawnSinglePumpkin()
		{
		}

		[Rpc]
		private void RPC_HandleOnBeforeSpawnPumpkin()
		{
		}

		[Rpc]
		private void RPC_HandleOnStopSpawnPumpkin()
		{
		}

		private void HandleOnPumpkinSpawned(ArenaEyePumpkin pumpkin)
		{
		}

		private void HandleOnPumpkinDespawned(ArenaEyePumpkin pumpkin, bool despawnManually)
		{
		}

		private void GenerateRandomDirections()
		{
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private static bool CheckIfEventEnded()
		{
			return false;
		}

		private void ChangeEyeState(ArenaEyeStateMachine.EyeState newState)
		{
		}

		private void StartEyeSpawningPumpkins()
		{
		}

		private void PrepareForEye()
		{
		}

		private void DespawnAllCurrentPumpkins()
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
		protected unsafe static void RPC_HandleOnBeforeSpawnPumpkin_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 7, 7)]
		protected unsafe static void RPC_HandleOnStopSpawnPumpkin_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
