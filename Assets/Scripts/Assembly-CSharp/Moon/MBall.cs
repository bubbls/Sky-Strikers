using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Runtime;
using Fusion;
using Moon.Arena;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon
{
	[NetworkBehaviourWeaved(38)]
	[RequireComponent(typeof(Hittable), typeof(Rigidbody))]
	[OrderAfter(new Type[] { typeof(NetworkRigidbody) })]
	public class MBall : NetworkBehaviour
	{
		[Serializable]
		[StructLayout((LayoutKind)2, Size = 32)]
		[NetworkStructWeaved(8)]
		public struct BallConfiguration : INetworkStruct
		{
			[FieldOffset(0)]
			public Vector3 SpawnPosition;

			[FieldOffset(12)]
			public BallTagHandlerType TagType;

			[FieldOffset(16)]
			public BallModifier Modifier;

			[FieldOffset(20)]
			public float ProjectionGroundHeight;

			[FieldOffset(24)]
			public NetworkBool AllowOnly3dSfx;

			[FieldOffset(28)]
			public NetworkBool EnableAirWall;
		}

		[Serializable]
		private class BallTagHandlers : DP.Takeaway.Runtime.SerializableDictionary<BallTagHandlerType, BallTagHandlerBase>
		{
		}

		[SerializeField]
		[Header("Ball Modifier")]
		[Space(5f)]
		private BallModifierHandlersManager _ballModifierHandlersManager;

		[SerializeField]
		[Space(5f)]
		private BallTagHandlers _ballTagHandlers;

		[SerializeField]
		[DefaultForProperty("Configuration", 0, 8)]
		private BallConfiguration _Configuration;

		[DefaultForProperty("Velocity", 8, 3)]
		[SerializeField]
		private Vector3 _Velocity;

		[DefaultForProperty("HitInfo", 11, 27)]
		private BallHitData _HitInfo;

		[SerializeField]
		private Collider _collider;

		[SerializeField]
		private NetworkExtrapolator _networkExtrapolator;

		[SerializeField]
		private BallExtraForceApplier _ballExtraForceApplier;

		[SerializeField]
		private float _ballSize;

		[SerializeField]
		private Hitbox _hitbox;

		[SerializeField]
		private bool _useKinematic;

		[SerializeField]
		private Renderer _ballRenderer;

		private BallTagHandlerBase _ballTagHandler;

		private Rigidbody _rigidbody;

		private bool _expectedKinematic;

		private IMessageSubscriber _matchEventsMessageSubscription;

		private CollisionInfo? _collision;

		private bool _hasTagHandler;

		private readonly BallHittableInfoMessageData _cachedBallHittableInfoMessageData;

		private BallHitData _cachedBallHitInfo;

		private HittableHitInfo _cachedHitInfo;

		private bool _cachedIsLatestHit;

		private BallCollisionMessageData _collisionMessageData;

		private static Changed<MBall> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MBall> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MBall> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 8)]
		public BallConfiguration Configuration
		{
			get
			{
				return default(BallConfiguration);
			}
			set
			{
			}
		}

		public Vector3 Position { get; set; }

		[NetworkedWeaved(8, 3)]
		[Networked]
		public Vector3 Velocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[NetworkedWeaved(11, 27)]
		[Networked(OnChanged = "HandleLastHitInfoChanged")]
		private BallHitData HitInfo
		{
			get
			{
				return default(BallHitData);
			}
			set
			{
			}
		}

		private BallHitData PrevHitInfo { get; set; }

		public BallExtraForceApplier ExtraForceApplier => null;

		public float BallRadius => 0f;

		public bool IsSpawned { get; private set; }

		public event Action<PlayerInfo, Vector3, HitSourceID> OnHit
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

		public event Action<PlayerInfo, Vector3, HitSourceID> OnHitByForce
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

		public event Action<PlayerInfo, Vector3, HitSourceID> OnHitByCollision
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

		public event Action<BallTag, HittableHitInfo> OnBallTaggedFromHit
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

		public event Action<CollisionInfo> OnEnteredCollision
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

		public event Action OnSpawned
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

		public event Action OnDespawned
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

		public event Action OnRender
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

		public event Action<PlayerInfo, ArenaGoal> OnGoalEvent
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

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void GetPositionAndVelocity(out Vector3 position, out Vector3 velocity)
		{
			position = default(Vector3);
			velocity = default(Vector3);
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
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

		public override void Render()
		{
		}

		private void HandleOnHit(MHitter hitter, HittableHitInfo hitInfo)
		{
		}

		private Vector3 CalculateHittingForce(MHitter hitter, HittableHitInfo hitInfo, int tick)
		{
			return default(Vector3);
		}

		private void TryHit(MHitter hitter, HittableHitInfo hit)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void Rpc_NotifyBallHitPlayerOwnedCollider(BallHitData ballHitData)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.Proxies)]
		private void RPC_HandleOnCollisionEnter(CollisionInfo collisionInfo)
		{
		}

		[Preserve]
		private static void HandleLastHitInfoChanged(Changed<MBall> changed)
		{
		}

		private BallHitData UpdateHittableInfo(HittableHitInfo hitInfo)
		{
			return default(BallHitData);
		}

		[Rpc(RpcSources.All, RpcTargets.All, InvokeResim = true)]
		private void RPC_Hit(MHitter hitter, HittableHitInfo hitInfo, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		private void BallExtraForceApplier_OnForceRequested(HittableHitInfo hitInfo, ForceMode forceMode, float clampedMagnitude)
		{
		}

		[Rpc]
		private void RPC_NotifyBallHitByForce(BallHitData ballHitData, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		private void BallExtraForceApplier_OnVelocityOverrideRequested(Vector3 velocity)
		{
		}

		private void RaiseOnBallTaggedFromHit(BallTag tagType, HittableHitInfo hitInfo)
		{
		}

		public BallHitData GetHittableInfo()
		{
			return default(BallHitData);
		}

		public BallHitData GetPrevHittableInfo()
		{
			return default(BallHitData);
		}

		private Vector3 GetClosestSurfacePointOnBall(Vector3 pointInBall)
		{
			return default(Vector3);
		}

		public void Teleport(Vector3 position, Quaternion rotation, bool keepVelocity)
		{
		}

		public void ResetVelocity()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 1, 7)]
		protected unsafe static void Rpc_NotifyBallHitPlayerOwnedCollider_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 1, 4)]
		protected unsafe static void RPC_HandleOnCollisionEnter_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 7, 7)]
		protected unsafe static void RPC_Hit_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(4, 7, 7)]
		protected unsafe static void RPC_NotifyBallHitByForce_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
