using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(5)]
	public class MBallSpawner : NetworkBehaviour
	{
		[Serializable]
		public class BallTypePair
		{
			public BallType BallType;

			public BallModifier BallModifier;

			public MBall BallPrefab;

			public BallSpawningIndicator BallSpawningIndicator;
		}

		private const float MinRemainingTimeToDestroyObjectsAroundBall = 0.2f;

		[SerializeField]
		private BallTypePair[] _ballTypePairs;

		[SerializeField]
		[DefaultForProperty("CurrentBallType", 0, 1)]
		private BallType _CurrentBallType;

		[SerializeField]
		[DefaultForProperty("CurrentBallModifier", 1, 1)]
		private BallModifier _CurrentBallModifier;

		[DefaultForProperty("SpawningIndicatorPos", 2, 3)]
		private Vector3 _SpawningIndicatorPos;

		private MBall _ball;

		private MBall _ballPrefab;

		private BallSpawningIndicator _spawningIndicatorPrefab;

		private BallSpawningIndicator _spawningIndicator;

		private bool _waitingForRespawn;

		private bool _destroyedObjects;

		[SerializeField]
		private MBall.BallConfiguration _curBallConfiguration;

		private static Changed<MBallSpawner> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MBallSpawner> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MBallSpawner> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 1)]
		[Networked]
		public BallType CurrentBallType
		{
			get
			{
				return default(BallType);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(1, 1)]
		public BallModifier CurrentBallModifier
		{
			get
			{
				return default(BallModifier);
			}
			private set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(2, 3)]
		private Vector3 SpawningIndicatorPos
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		private TickTimer RespawnTimer { get; set; }

		public MBall Ball => null;

		public MBall.BallConfiguration CurBallConfiguration => default(MBall.BallConfiguration);

		public event Action<MBall> OnBallSpawned
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

		public event Action<MBall> OnBallEnteredDeadZone
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

		public void DespawnBall()
		{
		}

		public void UpdateSpawnerPosition(Vector3 position)
		{
		}

		public void Respawn(BallType ballType, float respawnDelay)
		{
		}

		public void Respawn(BallType ballType, MBall.BallConfiguration ballConfiguration, float respawnDelay, Vector3 position)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		[ContextMenu("Respawn")]
		private void Respawn()
		{
		}

		private void SpawnBall()
		{
		}

		protected virtual void Ball_OnEnteredCollision(CollisionInfo collisionInfo)
		{
		}

		protected void NotifyBallEnteredDeadzone()
		{
		}

		private void DestroyItemsAroundBall()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_NotifyWaitingForRespawn(BallType ballType, Vector3 spawningIndicatorPos, float respawnDelay)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_NotifyRespawnComplete()
		{
		}

		private void SetBallType(BallType ballType)
		{
		}

		private void SetPrefabs(BallType ballType)
		{
		}

		private void ShowSpawningIndicator(Vector3 spawningIndicatorPos, float respawnDelay)
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
		protected unsafe static void Rpc_NotifyWaitingForRespawn_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyRespawnComplete_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
