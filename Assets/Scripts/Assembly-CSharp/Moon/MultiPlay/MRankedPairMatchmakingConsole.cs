using System;
using Chamber8.Framework.Messaging;
using Chamber8.Framework.Service.PlayFab;
using Fusion;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.Framework.Base;
using Moon.Hub;
using Moon.Leaderboard;
using Moon.Player;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.MultiPlay
{
	[NetworkBehaviourWeaved(1153)]
	public class MRankedPairMatchmakingConsole : NetworkBehaviour
	{
		private const int MaxParties = 5;

		private const int ShowBannedNotificationMessageDuration = 3;

		[DefaultForProperty("RankedPairMatchmakingSlotOne", 0, 70)]
		private RankedPairMatchmakingSlotNetworkData _RankedPairMatchmakingSlotOne;

		[DefaultForProperty("RankedPairMatchmakingSlotTwo", 70, 70)]
		private RankedPairMatchmakingSlotNetworkData _RankedPairMatchmakingSlotTwo;

		[SerializeField]
		private float _pairMatchmakingTimerDuration;

		[SerializeField]
		private RankedRegionSelectionBoard _regionSelectionBoard;

		[SerializeField]
		private LocalPlayerCheckVolume _localPlayerCheckVolume;

		[SerializeField]
		[Header("UI")]
		private RankedPairMatchmakingConsoleVisual _visual;

		[Header("Notification")]
		[SerializeField]
		private NotificationMessage _notificationMessage;

		private IMessageSubscriber _playerStatsUpdateSubscriber;

		private IMessageSubscriber[] _clientSubscribers;

		private IMessageSubscriber[] _serverSubscribers;

		private PlayFabAccountService _accountService;

		[DefaultForProperty("PairMatchmakingTimer", 140, 1)]
		private TickTimer _PairMatchmakingTimer;

		[DefaultForProperty("PairConsoleState", 141, 1)]
		private PairConsoleState _PairConsoleState;

		[DefaultForProperty("RankedPairPlayersDictionary", 142, 1011)]
		private SerializableDictionary<int, RankedPairPlayersNetworkData> _RankedPairPlayersDictionary;

		private float _currentPairMatchmakingTimer;

		private float _currentConnectorFillAmount;

		private int _rankedPairMmrDifferenceThreshold;

		private bool _isLocalClientStatsUpdated;

		private bool _isSpawned;

		private bool _isCheckingEligibility;

		private static Changed<MRankedPairMatchmakingConsole> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MRankedPairMatchmakingConsole> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MRankedPairMatchmakingConsole> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "HandleOnRankedPairMatchmakingSlotOneChanged")]
		[NetworkedWeaved(0, 70)]
		private RankedPairMatchmakingSlotNetworkData RankedPairMatchmakingSlotOne
		{
			get
			{
				return default(RankedPairMatchmakingSlotNetworkData);
			}
			set
			{
			}
		}

		[Networked(OnChanged = "HandleOnRankedPairMatchmakingSlotTwoChanged")]
		[NetworkedWeaved(70, 70)]
		private RankedPairMatchmakingSlotNetworkData RankedPairMatchmakingSlotTwo
		{
			get
			{
				return default(RankedPairMatchmakingSlotNetworkData);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(140, 1)]
		private TickTimer PairMatchmakingTimer
		{
			get
			{
				return default(TickTimer);
			}
			set
			{
			}
		}

		[NetworkedWeaved(141, 1)]
		[Networked(OnChanged = "HandlePairConsoleStateChanged")]
		private PairConsoleState PairConsoleState
		{
			get
			{
				return default(PairConsoleState);
			}
			set
			{
			}
		}

		[Networked]
		[Capacity(5)]
		[NetworkedWeaved(142, 1011)]
		private NetworkDictionary<int, RankedPairPlayersNetworkData> RankedPairPlayersDictionary => default(NetworkDictionary<int, RankedPairPlayersNetworkData>);

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private int HandleOnPlayerRemoved(IMessage<PlayerRemovedMessage> message)
		{
			return 0;
		}

		private void SetPartyToEmpty(int index)
		{
		}

		private void TryUpdatePairingSlotsState()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LocalPlayerCheckVolume_OnChanged(bool hasPlayer)
		{
		}

		private RankedPairMatchmakingSlotNetworkData GenerateLocalSlotNetworkData(LinkedPlayFabAccount loggedInAccount, bool hasPlayer)
		{
			return default(RankedPairMatchmakingSlotNetworkData);
		}

		private int HandleOnLocalPlayerStatisticsUpdated(IMessage<PlayerStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private void TrySetConsoleOnline()
		{
		}

		private void CheckIfPlayerInArea()
		{
		}

		private void Visual_HandleOnCancelRankedPairMatchmakingInQueue()
		{
		}

		public override void Render()
		{
		}

		private void IsEligibleToDoPairRank(Action<bool> callback)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_AddPlayerToRankedPairMatchmakingSlot(RankedPairMatchmakingSlotNetworkData slotNetworkStruct)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_RemovePlayerFromRankedPairMatchmakingSlot(RankedPairMatchmakingSlotNetworkData slotNetworkStruct)
		{
		}

		[Preserve]
		private static void HandleOnRankedPairMatchmakingSlotOneChanged(Changed<MRankedPairMatchmakingConsole> changed)
		{
		}

		private void NotifyRankedPairMatchmakingSlotOneChanged()
		{
		}

		[Preserve]
		private static void HandleOnRankedPairMatchmakingSlotTwoChanged(Changed<MRankedPairMatchmakingConsole> changed)
		{
		}

		private void NotifyRankedPairMatchmakingSlotTwoChanged()
		{
		}

		private bool IsPairMmrValid(int playerOneRankMmr, int playerTwoRankMmr)
		{
			return false;
		}

		[Preserve]
		private static void HandlePairConsoleStateChanged(Changed<MRankedPairMatchmakingConsole> changed)
		{
		}

		private void NotifyPairConsoleStateChanged()
		{
		}

		private string GetMultiPlayEntityId()
		{
			return null;
		}

		private void ShowNotification(string message)
		{
		}

		private static void Log(string message)
		{
		}

		private static void LogError(string message)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.Proxies, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_NotifyStartPairMatchmaking(string creatorEntityId, string joinEntityId, string creatorPlayFabId, string joinerPlayFabId)
		{
		}

		private int HandleOnRankedPairMatchmakingTicketCreated(IMessage<RankedPairMatchmakingTicketCreatedMessage> message)
		{
			return 0;
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_NotifyRankedPairMatchmakingTicketCreated(string ticketId, string creatorId)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.Proxies, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_RequestJoinMatchmakingTicket([RpcTarget] PlayerRef playerRef, string ticketId)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_NotifyMatchmakingTicketJoined()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.Proxies, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_RequestStartPollingTicket([RpcTarget] PlayerRef playerRef)
		{
		}

		private int HandleOnMatchFound(IMessage<PairRankedMatchFoundMessage> message)
		{
			return 0;
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_OnMatchFound(PlayerRef creatorPlayerRef, string roomName, string sessionId, FieldType fieldType, string teamId, PlayFabRegion playFabRegion)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.Proxies, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_ConnectToRankedMatchSession([RpcTarget] PlayerRef playerRef, RankedPairMatchFoundNetworkData pairMatchFoundNetworkData)
		{
		}

		private int HandleOnCancelMatchmaking(IMessage<object> message)
		{
			return 0;
		}

		private void HandleLocalPlayerRequestCancelMatchmaking()
		{
		}

		private void TryCancelRankedPairPlayersInQueue()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_NotifyRankedPairMatchmakingCancelledFromPlayer(PlayerRef playerRef)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.Proxies, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_CancelRankedPairMatchmakingInQueue([RpcTarget] PlayerRef playerRef)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_AddPlayerToRankedPairMatchmakingSlot_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_RemovePlayerFromRankedPairMatchmakingSlot_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(3, 1, 4)]
		[Preserve]
		protected unsafe static void Rpc_NotifyStartPairMatchmaking_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(4, 7, 1)]
		protected unsafe static void Rpc_NotifyRankedPairMatchmakingTicketCreated_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(5, 1, 4)]
		[Preserve]
		protected unsafe static void Rpc_RequestJoinMatchmakingTicket_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(6, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_NotifyMatchmakingTicketJoined_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(7, 1, 4)]
		[Preserve]
		protected unsafe static void Rpc_RequestStartPollingTicket_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(8, 7, 1)]
		protected unsafe static void Rpc_OnMatchFound_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(9, 1, 4)]
		protected unsafe static void Rpc_ConnectToRankedMatchSession_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(10, 7, 1)]
		protected unsafe static void Rpc_NotifyRankedPairMatchmakingCancelledFromPlayer_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(11, 1, 4)]
		[Preserve]
		protected unsafe static void Rpc_CancelRankedPairMatchmakingInQueue_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
