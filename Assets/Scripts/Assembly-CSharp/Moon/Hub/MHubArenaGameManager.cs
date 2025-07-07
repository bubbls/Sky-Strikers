using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Fusion;
using Moon.Arena;
using Moon.Economy;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(53)]
	public class MHubArenaGameManager : NetworkBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddFreeCurrencyForPlayers_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MHubArenaGameManager _003C_003E4__this;

			public Dictionary<PlayerRef, string> playersForFreeCurrency;

			private PlayerEconomyServer _003CplayerEconomyServer_003E5__2;

			private int _003CrewardAmount_003E5__3;

			private Dictionary<PlayerRef, string>.Enumerator _003C_003E7__wrap3;

			private KeyValuePair<PlayerRef, string> _003Ckvp_003E5__5;

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

		private HubArenaPlayerTracker _hubArenaPlayerTracker;

		private const float MinMatchTimeForReward = 120f;

		private const float WaitTimeAfterAGoal = 7f;

		private const float WaitTimeAfterAGoalFreePlay = 1.5f;

		private const float WaitTimeAfterOneMatch = 8f;

		private const float NewMatchCountDownTime = 5f;

		private const float NextRoundCountDownTime = 3f;

		private const float NextRoundCountDownTimeFreePlay = 1f;

		private const string StaPrepare = "Prepare";

		private const string StaMatch = "Match";

		private const string StaEnd = "End";

		private const string StaGoal = "Goal";

		private const string StaNextRound = "NextRound";

		[DefaultForProperty("CurrentMatchId", 0, 17)]
		private NetworkString<_16> _CurrentMatchId;

		[DefaultForProperty("HubGameSettings", 17, 31)]
		private HubGameSettings _HubGameSettings;

		[DefaultForProperty("IsMatchInProgress", 48, 1)]
		private NetworkBool _IsMatchInProgress;

		[DefaultForProperty("PauseTimer", 49, 1)]
		private TickTimer _PauseTimer;

		[DefaultForProperty("NextMatchTimer", 50, 1)]
		private TickTimer _NextMatchTimer;

		[DefaultForProperty("CurrentMatchController", 51, 2)]
		private MMatchController _CurrentMatchController;

		[SerializeField]
		private HubGameSettings _localGameSettings;

		[SerializeField]
		private MSkyballMatchController _skyballMatchController;

		[SerializeField]
		private MVolleyballMatchController _volleyballMatchController;

		[SerializeField]
		private MHubVoteMachine _voteMachine;

		[SerializeField]
		private MHubArenaPlatformSpawner _platformSpawner;

		[SerializeField]
		private MHubArenaGroundItemsSpawner _groundItemsSpawner;

		[SerializeField]
		private MHubArenaGoalManager _goalManager;

		[SerializeField]
		private HubClassChangeMachine[] _classChangeMachines;

		private readonly CountDownMessageData _countDownMessageData;

		private MFSM _mFsm;

		private float _cacheTimerRemainingTime;

		private int _playerCountAtStartOfMatch;

		private int _lastCountdownTime;

		private int _cachedCountdownTimeInt;

		private float _cachedNextRoundCountdownTime;

		private static Changed<MHubArenaGameManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaGameManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaGameManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 17)]
		private NetworkString<_16> CurrentMatchId
		{
			get
			{
				return default(NetworkString<_16>);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(17, 31)]
		private HubGameSettings HubGameSettings
		{
			get
			{
				return default(HubGameSettings);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(48, 1)]
		private NetworkBool IsMatchInProgress
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		[NetworkedWeaved(49, 1)]
		[Networked]
		private TickTimer PauseTimer
		{
			get
			{
				return default(TickTimer);
			}
			set
			{
			}
		}

		[NetworkedWeaved(50, 1)]
		[Networked]
		private TickTimer NextMatchTimer
		{
			get
			{
				return default(TickTimer);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(51, 2)]
		private MMatchController CurrentMatchController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void HandleOnNewMatchStarted()
		{
		}

		[AsyncStateMachine(typeof(_003CAddFreeCurrencyForPlayers_003Ed__4))]
		private void AddFreeCurrencyForPlayers(Dictionary<PlayerRef, string> playersForFreeCurrency)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_ConfirmFreeCurrency(string playerFabId, NetworkBool success, int amount)
		{
		}

		[ContextMenu("Moon/End Next Match Countdown")]
		private void DebugEndVoteCountdown()
		{
		}

		[ContextMenu("Moon/End Match")]
		private void DebugEndMatch()
		{
		}

		public void EndCurrentMatch()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_EndCurrentMatch()
		{
		}

		public void RestartWithGameSettings(GameSettings gameSettings)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true)]
		private void Rpc_RestartWithGameSettings(HubGameSettings hubGameSettings)
		{
		}

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void SetInitialStateAfterSpawned()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void HandleMatchControllerEvents(MMatchController matchController, bool register)
		{
		}

		private void SyncWithNewGameSettings()
		{
		}

		private void UpdateArenaWithMatchStatus()
		{
		}

		private void HandleDespawn()
		{
		}

		private void StartFreePlay()
		{
		}

		private void RestartMatch(HubGameSettings newSettings)
		{
		}

		private void VoteMachine_OnMinVotesReceived()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, Channel = RpcChannel.Reliable)]
		private void Rpc_NotifyMinVotesReceived()
		{
		}

		private void S_Prepare(MFSM.Phase phase)
		{
		}

		private void MatchController_OnGoalScored()
		{
		}

		private void S_Goal(MFSM.Phase phase)
		{
		}

		private bool T_GoalToCountDown()
		{
			return false;
		}

		private void HandleStateEnterNextRoundCountdownMessage(TickTimer timer)
		{
		}

		private void HandleStateUpdateNextRoundCountdownMessage(TickTimer timer)
		{
		}

		private void S_NextRoundCountDown(MFSM.Phase phase)
		{
		}

		private void S_Match(MFSM.Phase phase)
		{
		}

		private void S_End(MFSM.Phase phase)
		{
		}

		private bool T_GoalToEnd()
		{
			return false;
		}

		private bool T_MatchToEnd()
		{
			return false;
		}

		private bool IsMatchEnd()
		{
			return false;
		}

		private void NotifyAndLogEndMatch(Dictionary<PlayerRef, string> participatingPlayers, TeamNo winningTeam)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_LogMatchEndForParticipatingPlayer(PlayerRef targetPlayer, string sceneName, string matchId, GameSettings gameSettings, bool isWinner)
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
		protected unsafe static void Rpc_ConfirmFreeCurrency_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 7, 1)]
		protected unsafe static void Rpc_EndCurrentMatch_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 7, 1)]
		protected unsafe static void Rpc_RestartWithGameSettings_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(4, 1, 7)]
		protected unsafe static void Rpc_NotifyMinVotesReceived_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(5, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_LogMatchEndForParticipatingPlayer_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
