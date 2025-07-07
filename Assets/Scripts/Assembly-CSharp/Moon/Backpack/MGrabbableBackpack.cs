using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using Fusion;
using Moon.AI.VisualScripting;
using Moon.Economy;
using Moon.Interaction;
using Moon.Player.Visual;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Backpack
{
	[NetworkBehaviourWeaved(11)]
	[OrderAfter(new Type[]
	{
		typeof(MPlayer),
		typeof(HitboxManager)
	})]
	[SimulationBehaviour(Stages = SimulationStages.Forward)]
	public class MGrabbableBackpack : MGrabbable
	{
		public enum BackpackState
		{
			OnBack = 0,
			Grabbed = 1,
			Opened = 2
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTrySpawnItemInHandAsync_003Ed__76 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BackpackItemSlot slot;

			public MGrabbableBackpack _003C_003E4__this;

			public MGrabInteractor hand;

			private TaskAwaiter _003C_003Eu__1;

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

		private const string BackpackReason = "Backpack";

		[DefaultForProperty("State", 1, 1)]
		private BackpackState _State;

		[SerializeField]
		[DefaultForProperty("ItemInteractingHand", 2, 2)]
		private MGrabInteractor? _ItemInteractingHand;

		[DefaultForProperty("DropPosition", 4, 3)]
		private Vector3 _DropPosition;

		[DefaultForProperty("DropRotation", 7, 4)]
		private Quaternion _DropRotation;

		[Header("Slots")]
		[SerializeField]
		private BackpackItemSlotsController _itemSlotsController;

		[SerializeField]
		private float _slotDetectRange;

		[Space(7f)]
		[Header("Backpack Hitbox")]
		[SerializeField]
		private Trigger _backpackToggleTrigger;

		[SerializeField]
		private GameObject _backpackHandleHitboxRoot;

		[SerializeField]
		private Hitbox _backpackHandleHitbox;

		[SerializeField]
		private OverlapShapeDesc _backpackHandleOSD;

		[SerializeField]
		private OverlapShapeDesc _backpackPutBackAreaOSD;

		[SerializeField]
		private BackpackDelayedGrabbableTrigger _backpackBodyGrabTrigger;

		[Header("Haptic")]
		[SerializeField]
		private float _hapticDuration;

		[SerializeField]
		private float _hapticAmp;

		[Header("Transform")]
		[SerializeField]
		private Transform _pivot;

		private NetworkTransform _pivotNetworked;

		[Header("Sounds")]
		[SerializeField]
		private SoundInfo? _takeOutBackpackSoundInfo;

		[SerializeField]
		private SoundInfo? _putBackBackpackSoundInfo;

		[SerializeField]
		private SoundInfo? _grabHandleSoundInfo;

		[SerializeField]
		private SoundInfo? _slotChosenSoundInfo;

		[SerializeField]
		private SoundInfo? _grabSlotItemSoundInfo;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private BackpackItemSlot? _lastGrabbingSlot;

		private PlayerEconomy _playerEconomy;

		private Transform? _headPivot;

		private PlayerBackpackVisual? _backpackVisual;

		private static Changed<MGrabbableBackpack> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabbableBackpack> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabbableBackpack> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "HandleBackpackStateChanged")]
		[NetworkedWeaved(1, 1)]
		private BackpackState State
		{
			get
			{
				return default(BackpackState);
			}
			set
			{
			}
		}

		[Networked(OnChanged = "HandleItemInteractingHandChanged")]
		[NetworkedWeaved(2, 2)]
		public MGrabInteractor? ItemInteractingHand
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
		[NetworkedWeaved(4, 3)]
		private Vector3 DropPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[NetworkedWeaved(7, 4)]
		[Networked]
		private Quaternion DropRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public IReadOnlyList<BackpackItemSlot> Slots => null;

		public BackpackItemSlot? HoveringSlot { get; private set; }

		public BackpackItemSlot? GrabbingSlot { get; private set; }

		public Transform FollowPivot { get; private set; }

		public BackpackState GetState()
		{
			return default(BackpackState);
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void ResetFollowPivot()
		{
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public void InitializeBeforeSpawn()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandlePlayerLeaveBackpackOnGroundArea(Collider other)
		{
		}

		private int HandlePlayerInventoryUpdated(IMessage<object> message)
		{
			return 0;
		}

		public void UpdatePositions(Transform headPivot)
		{
		}

		public override void Render()
		{
		}

		public void ScheduleRendering(PlayerVisualsController playerVisualsController)
		{
		}

		private void UpdateFollowPivot_GrabbedAndOnBack(Transform headPivot)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void SetHoveringSlot(BackpackItemSlot? slot)
		{
		}

		private void CheckInteractingHandHovering()
		{
		}

		[Preserve]
		private static void HandleItemInteractingHandChanged(Changed<MGrabbableBackpack> changed)
		{
		}

		private void RaiseItemInteractingHandChanged(MGrabInteractor? prevItemInteractingHand)
		{
		}

		private bool TryAssignItemInteractingHand()
		{
			return false;
		}

		public override bool CanBeGrabbedByInteractor(MGrabInteractor interactor)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CTrySpawnItemInHandAsync_003Ed__76))]
		private void TrySpawnItemInHandAsync(BackpackItemSlot slot, MGrabInteractor hand)
		{
		}

		private void SpawnItemInHand(string friendlyId, string stackId, bool isLeft)
		{
		}

		private bool ServerIsInBackpackArea(Vector3 position)
		{
			return false;
		}

		private void HandleInteractingHandReleased(MGrabInteractor interactingHand, MGrabbable oldGrabbableObject)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority)]
		private void Rpc_RequestDespawnItem(MGrabbableBackpackItem grabbableBackpackItem)
		{
		}

		[Preserve]
		private static void HandleBackpackStateChanged(Changed<MGrabbableBackpack> changed)
		{
		}

		private void RaiseBackpackStateChanged(BackpackState oldState)
		{
		}

		public void PutBackpackBack(bool withHaptic)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_PutBackpackBack()
		{
		}

		protected override void HandleOnReleaseInternal()
		{
		}

		protected override void HandleOnGrabbedInternal()
		{
		}

		private void GrabSlot(BackpackItemSlot? slot)
		{
		}

		private void GrabHoveringSlot()
		{
		}

		private bool DropItemInSlot(MGrabbableBackpackItem itemToDrop, BackpackItemSlot targetSlot)
		{
			return false;
		}

		private void TransferItemBetweenSlots(BackpackItemSlot fromSlot, BackpackItemSlot toSlot)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority)]
		private void Rpc_SpawnItemInHand(bool isLeft, BackpackItemNetworkStruct itemNetworkStruct, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		private MGrabbableBackpackItem? ServerSpawnItem(PlayerRef playerRef, bool isLeft, BackpackItemNetworkStruct itemNetworkStruct)
		{
			return null;
		}

		private static MGrabInteractor GetTargetInteractor(PlayerRef playerRef, bool isLeft)
		{
			return null;
		}

		private void PlaySound(SoundInfo? soundInfo)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 2, 1)]
		[Preserve]
		protected unsafe static void Rpc_RequestDespawnItem_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 2, 1)]
		protected unsafe static void Rpc_PutBackpackBack_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(3, 2, 1)]
		[Preserve]
		protected unsafe static void Rpc_SpawnItemInHand_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
