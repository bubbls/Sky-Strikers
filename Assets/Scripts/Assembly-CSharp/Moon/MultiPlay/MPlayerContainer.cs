using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.Leaderboard;
using Moon.MultiPlay.Aoi;
using Moon.Player;
using Moon.PlayerProfile;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.MultiPlay
{
	[OrderBefore(new Type[] { typeof(MPlayer) })]
	[NetworkBehaviourWeaved(78)]
	[SimulationBehaviour(Stages = SimulationStages.Forward)]
	public class MPlayerContainer : NetworkBehaviour
	{
		[StructLayout((LayoutKind)2, Size = 292)]
		[NetworkStructWeaved(73)]
		private struct PlayerReportedData : INetworkStruct
		{
			[FieldOffset(0)]
			public PlayerVisualsConfig VisualsConfig;

			[FieldOffset(56)]
			public NetworkString<_32> PlayerName;

			[FieldOffset(188)]
			public int PlayerNo;

			[FieldOffset(192)]
			public NetworkString<_16> PlayFabId;

			[FieldOffset(260)]
			public UnreliableInventory UnreliableInventory;

			[FieldOffset(264)]
			public FlagFrameConfiguration FlagFrameConfiguration;
		}

		[Serializable]
		private class PlayerNotification
		{
			public bool localPlayerIsGameMaster;

			public NotificationMessage messageSetting;
		}

		private const int ConnectionTimeout = 30;

		[SerializeField]
		private List<PlayerNotification> _notifications;

		[SerializeField]
		[DefaultForProperty("PlayerInfo", 0, 77)]
		private PlayerInfo _PlayerInfo;

		[SerializeField]
		[DefaultForProperty("RTT", 77, 1)]
		private int _RTT;

		private PlayerInputData _inputData;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private readonly Cooldown _cooldown;

		private readonly PlayerRTTChangedMessage _rttChangedMessage;

		private readonly PlayerInfoChangedMessage _playerInfoChangedMessage;

		private IPlayerProfileService _playerProfilerService;

		private float _lastInputTime;

		private float _timeSinceLastInput;

		private bool _isSpawned;

		private static Changed<MPlayerContainer> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerContainer> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerContainer> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 77)]
		[Networked(OnChanged = "HandlePlayerInfoChangedMessage")]
		public PlayerInfo PlayerInfo
		{
			get
			{
				return default(PlayerInfo);
			}
			private set
			{
			}
		}

		[Networked(OnChanged = "HandlePlayerRTTChangedMessage")]
		[NetworkedWeaved(77, 1)]
		public int RTT
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public bool IsSpeakerEnabled => false;

		public MPlayer.PlayerSpeakerVolume SpeakerVolume => default(MPlayer.PlayerSpeakerVolume);

		public override void Spawned()
		{
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private int HandlePlayerBalanceChanged(IMessage<object> _)
		{
			return 0;
		}

		private int HandlePlayerInventoryUpdated(IMessage<object> _)
		{
			return 0;
		}

		public void SetIsGameMaster(NetworkBool isGameMaster)
		{
		}

		private void SyncLocalPlayerData()
		{
		}

		private static string GetDisplayName(string titleInfoDisplayName)
		{
			return null;
		}

		private void ReportLocalPlayerData(PlayerReportedData data)
		{
		}

		private PlayerInfo MakePlayerInfoFromReportedData(PlayerReportedData data)
		{
			return default(PlayerInfo);
		}

		private void SyncLocalPlayerUnreliableInventory()
		{
		}

		private void SyncCurrentPlayerVisuals()
		{
		}

		private void SyncMatchMakingPlayerInfo()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void RPC_SyncMatchMakingPlayerInfo(string entityId, string teamId, bool isInParty, LatencyFusion latencyFusion, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		public void EnableSpeaker(bool enable)
		{
		}

		public void SetSpeakerVolume(MPlayer.PlayerSpeakerVolume volume)
		{
		}

		public void TunePlayerNo(bool tuneUp)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true, TickAligned = false)]
		private void RPC_TunePlayerNo(bool tuneUp)
		{
		}

		public void SetTeamNo(TeamNo teamNo)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true, TickAligned = false)]
		private void Rpc_SetTeamNo(TeamNo teamNo, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		private void SetTeamNoInternal(TeamNo teamNo)
		{
		}

		public void SetPlayerNo(int playerNo)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority, InvokeResim = true, TickAligned = false)]
		private void Rpc_SetPlayerNo(int playerNo)
		{
		}

		private void SetPlayerNoInternal(int playerNo)
		{
		}

		private void OnInput(NetworkRunner runner, NetworkInput input)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void LateUpdate()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		[Preserve]
		private static void HandlePlayerInfoChangedMessage(Changed<MPlayerContainer> changed)
		{
		}

		private void NotifyPlayerInfoChanged(PlayerInfo oldPlayerInfo, PlayerInfo playerInfo)
		{
		}

		[Preserve]
		private static void HandlePlayerRTTChangedMessage(Changed<MPlayerContainer> changed)
		{
		}

		private void NotifyRTTChanged(int rtt)
		{
		}

		public void SetInterestInPlayer(PlayerRef playerRef, bool isInterested, bool allowVoiceChat)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.InputAuthority, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_NotifyInterestInPlayerChanged(PlayerRef playerRef, bool isInterested, bool allowVoiceChat)
		{
		}

		private void NotifyOnBeforePlayerInfoChange(PlayerInfo newPlayerInfo)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true, TickAligned = false)]
		public void RPC_SetPlayerInfo(PlayerInfo playerInfo)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true, TickAligned = false)]
		public void RPC_SetPlayerLocation(Location location)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.InputAuthority)]
		private void Rpc_PlayerStatisticsUpdated([RpcTarget] PlayerRef playerRef)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.All, InvokeResim = true, TickAligned = false)]
		public void RPC_KickPlayer(PlayerRef playerRef)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		public RpcInvokeInfo RPC_SetPlayerVisionFlag(NetworkVisionFlag flag)
		{
			return default(RpcInvokeInfo);
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority, InvokeResim = true, TickAligned = false, Channel = RpcChannel.Unreliable)]
		private void RPC_SetPlayerRTT(int rtt)
		{
		}

		public void SetInitialConfig(ConnectionToken connectionToken, PlayerVisualsConfig visualsConfig, TeamNo teamNo, bool isGameMaster)
		{
		}

		private void SendGameMasterNotification(PlayerInfo playerInfo)
		{
		}

		private string TruncateString(string input, int maxLength)
		{
			return null;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 7, 1)]
		protected unsafe static void RPC_SyncMatchMakingPlayerInfo_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 7, 1)]
		protected unsafe static void RPC_TunePlayerNo_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 7, 1)]
		protected unsafe static void Rpc_SetTeamNo_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(4, 2, 1)]
		[Preserve]
		protected unsafe static void Rpc_SetPlayerNo_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(5, 1, 2)]
		[Preserve]
		protected unsafe static void Rpc_NotifyInterestInPlayerChanged_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(6, 7, 1)]
		protected unsafe static void RPC_SetPlayerInfo_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(7, 7, 1)]
		protected unsafe static void RPC_SetPlayerLocation_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(8, 1, 2)]
		[Preserve]
		protected unsafe static void Rpc_PlayerStatisticsUpdated_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(9, 7, 7)]
		[Preserve]
		protected unsafe static void RPC_KickPlayer_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(10, 7, 7)]
		[Preserve]
		protected unsafe static void RPC_SetPlayerVisionFlag_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(11, 2, 1)]
		[Preserve]
		protected unsafe static void RPC_SetPlayerRTT_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
