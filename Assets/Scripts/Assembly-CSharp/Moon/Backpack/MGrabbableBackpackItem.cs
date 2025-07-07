using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Sound;
using Fusion;
using Moon.Bootstrap;
using Moon.Interaction;
using Moon.MultiPlay;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Backpack
{
	[NetworkBehaviourWeaved(112)]
	[OrderAfter(new Type[]
	{
		typeof(MPlayer),
		typeof(NetworkExtrapolator)
	})]
	public class MGrabbableBackpackItem : MGrabbable
	{
		public enum DespawnReason
		{
			None = 0,
			Collected = 1,
			ConsumedByPlayer = 2,
			ConsumedByOther = 3,
			CollectedToBackpack = 4
		}

		private enum HitResult
		{
			None = 0,
			Player = 1,
			Other = 2
		}

		[Serializable]
		private class Effect
		{
			[Header("特效")]
			public GameObject? Fx;

			[Header("特效播放后多久回收")]
			public float FxReleaseDuration;

			[Header("声音")]
			public SoundInfo? Sfx;

			public void Play(Vector3 position, AudioSource? audioSource)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestToConsume_003Ed__92 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MGrabbableBackpackItem _003C_003E4__this;

			private string _003CfriendlyId_003E5__2;

			private string _003CstackId_003E5__3;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private const string TemporaryReason = "Temporary";

		private const string GrabReason = "Grab";

		private const string DespawnIntentReason = "DespawnIntent";

		[SerializeField]
		[DefaultForProperty("ItemData", 1, 99)]
		private BackpackItemNetworkStruct _ItemData;

		[SerializeField]
		[DefaultForProperty("SpawnParameters", 100, 7)]
		private ItemSpawnParameters _SpawnParameters;

		[DefaultForProperty("DespawnRequested", 107, 1)]
		private DespawnReason _DespawnRequested;

		private DespawnReason _despawnIntent;

		[DefaultForProperty("MyHandIsHovered", 108, 1)]
		private NetworkBool _MyHandIsHovered;

		[DefaultForProperty("IsVisible", 109, 1)]
		private NetworkBool _IsVisible;

		private readonly HashSet<string> _hideReasons;

		private TickTimer _autoCollectionTimer;

		[DefaultForProperty("AutoDespawnTimer", 110, 1)]
		private TickTimer _AutoDespawnTimer;

		private TickTimer _despawnDelayTimer;

		private TickTimer _temporaryDisableTimer;

		private readonly HashSet<string> _disablePhysicsReasons;

		[DefaultForProperty("ItemHitResult", 111, 1)]
		private HitResult _ItemHitResult;

		[SerializeField]
		private Hitbox _hitbox;

		[SerializeField]
		private Rigidbody _rigidbody;

		[SerializeField]
		private GrabbableBackpackItemVisual _visual;

		[InfoBox("配置后，声音位置跟着AudioSource走; 不配置则声音停留在触发效果的地方", EInfoBoxType.Normal)]
		[Header("音源")]
		[SerializeField]
		private AudioSource? _audioSource;

		[Header("Effects")]
		[Header("抓取时效果")]
		[SerializeField]
		private Effect? _fxGrab;

		[SerializeField]
		[Header("与玩家碰撞时的效果")]
		private Effect? _fxCollidePlayer;

		[SerializeField]
		[Header("与场景碰撞时的效果")]
		private Effect? _fxCollideOther;

		[Header("消耗时效果(玩家)")]
		[SerializeField]
		private Effect? _fxConsumedByPlayer;

		[Header("消耗时效果")]
		[SerializeField]
		private Effect? _fxConsumedByOther;

		[Header("回收时效果")]
		[SerializeField]
		private Effect? _fxCollected;

		[Header("Auto Despawn (延时消耗)")]
		[InfoBox("3秒爆炸的手雷可以设置延迟消耗=3，并且关闭碰撞消耗", EInfoBoxType.Normal)]
		[SerializeField]
		private float _autoConsumeDurationAfterRelease;

		[SerializeField]
		[Header("Consume On Collide (碰撞时消耗)")]
		private bool _consumeOnCollide;

		[Header("Allow Collides Player (允许与玩家碰撞)")]
		[InfoBox("开启时，优先检查玩家；若关闭，则只与物理模型发生碰撞。", EInfoBoxType.Normal)]
		[SerializeField]
		private bool _allowCollidePlayer;

		[Header("Auto Collection (回收，不触发消耗)")]
		[InfoBox("此处只回收，不触发道具消耗，用作性能控制，不允许物品一直存在于场内", EInfoBoxType.Normal)]
		[SerializeField]
		private float _autoCollectionDuration;

		private IMessageSubscriber[]? _subscribers;

		private Transform _itemTransform;

		private bool _isGrabbedOnce;

		private bool _isConsuming;

		private bool _isConsumed;

		private Quaternion _localRotationToInteractor;

		private Vector3 _lastRenderingPosition;

		private bool _hasStateAuthority;

		private bool _hasInputAuthority;

		private static Changed<MGrabbableBackpackItem> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabbableBackpackItem> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabbableBackpackItem> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(1, 99)]
		[Networked]
		public BackpackItemNetworkStruct ItemData
		{
			get
			{
				return default(BackpackItemNetworkStruct);
			}
			private set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(100, 7)]
		public ItemSpawnParameters SpawnParameters
		{
			get
			{
				return default(ItemSpawnParameters);
			}
			private set
			{
			}
		}

		[Networked(OnChanged = "HandleDespawnRequested")]
		[NetworkedWeaved(107, 1)]
		private DespawnReason DespawnRequested
		{
			get
			{
				return default(DespawnReason);
			}
			set
			{
			}
		}

		[Networked(OnChanged = "HandleMyHandIsHoveredChanged")]
		[NetworkedWeaved(108, 1)]
		private NetworkBool MyHandIsHovered
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		[NetworkedWeaved(109, 1)]
		[Networked(OnChanged = "HandleIsVisibleChanged")]
		private NetworkBool IsVisible
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(110, 1)]
		private TickTimer AutoDespawnTimer
		{
			get
			{
				return default(TickTimer);
			}
			set
			{
			}
		}

		[Networked(OnChanged = "HandleCollidingChanged")]
		[NetworkedWeaved(111, 1)]
		private HitResult ItemHitResult
		{
			get
			{
				return default(HitResult);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void Initialize(BackpackItemNetworkStruct itemData, ItemSpawnParameters parameters)
		{
		}

		private void OnEnable()
		{
		}

		private int HandlePlayerRemoved(IMessage<PlayerRemovedMessage> message)
		{
			return 0;
		}

		private void OnDisable()
		{
		}

		public override void Spawned()
		{
		}

		private void SetAutoCollectionTimer()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void ToggleSelectIndicator(bool enable)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void UpdateGrabbingPositionRotation()
		{
		}

		private void PerformHitCheck()
		{
		}

		private void RaiseHittingPlayer(List<LagCompensatedHit> hits)
		{
		}

		private void RaiseHittingOtherPhyX(List<LagCompensatedHit> hits)
		{
		}

		[Preserve]
		private static void HandleCollidingChanged(Changed<MGrabbableBackpackItem> changed)
		{
		}

		private void RaiseIsVisibleChanged()
		{
		}

		private void RaiseMyHandIsHoveredChanged()
		{
		}

		[Preserve]
		private static void HandleIsVisibleChanged(Changed<MGrabbableBackpackItem> changed)
		{
		}

		[Preserve]
		private static void HandleMyHandIsHoveredChanged(Changed<MGrabbableBackpackItem> changed)
		{
		}

		[Preserve]
		private static void HandleDespawnRequested(Changed<MGrabbableBackpackItem> changed)
		{
		}

		private void RaiseCollidingChanged()
		{
		}

		private void TryConsumeOnCollide(bool byPlayer)
		{
		}

		private void PlayDespawnEffects(DespawnReason despawnReason)
		{
		}

		public void DespawnThis(DespawnReason reason)
		{
		}

		public override void Render()
		{
		}

		private (Vector3, Quaternion?) GetLocalGrabOffsetAndRotation()
		{
			return default((Vector3, Quaternion?));
		}

		protected override void HandleOnGrabbedInternal()
		{
		}

		protected override void HandleOnReleaseInternal()
		{
		}

		private Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}

		[AsyncStateMachine(typeof(_003CRequestToConsume_003Ed__92))]
		private void RequestToConsume()
		{
		}

		private void EnableVisibility(string reason)
		{
		}

		private void DisableVisibility(string reason)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority)]
		public void Rpc_EnablePhysics(string reason)
		{
		}

		public void EnablePhysics(string reason)
		{
		}

		public void DisablePhysics(string reason)
		{
		}

		private void TogglePhysicsInternal(bool enable)
		{
		}

		public void TemporaryDisableInteractionAndVisibility(TimeSpan duration)
		{
		}

		private void DisableInteractionAndVisibility(string reason)
		{
		}

		public void RecoverTemporaryDisabledInteractionAndVisibility()
		{
		}

		private void ResetDisabledInteractionAndVisibility()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 2, 1)]
		protected unsafe static void Rpc_EnablePhysics_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
