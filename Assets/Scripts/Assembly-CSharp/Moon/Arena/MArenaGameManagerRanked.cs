using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Bootstrap;
using Moon.Economy;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(68)]
	public class MArenaGameManagerRanked : MGameManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddFreeCurrencyForPlayers_003Ed__98 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MArenaGameManagerRanked _003C_003E4__this;

			public TeamNo winningTeam;

			public bool isForfeit;

			public string currentMatchId;

			private PlayerEconomyServer _003CplayerEconomyServer_003E5__2;

			private IEnumerator<MGameData.PlayerData> _003C_003E7__wrap2;

			private MGameData.PlayerData _003Cplayer_003E5__4;

			private int _003Camount_003E5__5;

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

		private const int WaitingForPlayersTime = 180;

		public const int TeamPreparationCountdownTime = 60;

		private const int TeamEnterArenaCountdownTime = 15;

		private const int WaitTimeAfterAGoal = 7;

		private const int WaitTimeAfterOneMatch = 8;

		private const int NewMatchCountDownTime = 5;

		private const int NextRoundCountDownTime = 3;

		public const int CloseArenaCountdownTime = 120;

		private const string StaWaitForPlayers = "WaitForPlayers";

		private const string StaTeamSetup = "TeamSetup";

		private const string StaTeamPrepare = "TeamPrepare";

		private const string StaTeamEnterArena = "TeamEnterArena";

		private const string StaPrepare = "Prepare";

		private const string StaMatch = "Match";

		private const string StaEnd = "End";

		private const string StaGoal = "Goal";

		private const string StaNextRound = "NextRound";

		private const string StaArenaClosing = "ArenaClosing";

		private const string StaArenaClosed = "ArenaClosed";

		private const string BulwarpDefaultPlaceableAreaId = "Default";

		private const string BulwarpPreMatchPlaceableAreaId = "RankedPreMatch";

		[DefaultForProperty("GameSettings", 1, 13)]
		private GameSettings _GameSettings;

		[DefaultForProperty("CurrentMatchId", 14, 17)]
		private NetworkString<_16> _CurrentMatchId;

		[DefaultForProperty("TeamOneId", 31, 17)]
		private NetworkString<_16> _TeamOneId;

		[DefaultForProperty("TeamTwoId", 48, 17)]
		private NetworkString<_16> _TeamTwoId;

		[DefaultForProperty("PauseTimer", 65, 1)]
		private TickTimer _PauseTimer;

		[DefaultForProperty("WinningTeam", 66, 1)]
		private TeamNo _WinningTeam;

		[DefaultForProperty("IsMatchForfeit", 67, 1)]
		private NetworkBool _IsMatchForfeit;

		[SerializeField]
		private MSkyballMatchController _skyballMatchController;

		[SerializeField]
		private MArenaDoorsController _arenaDoorsController;

		[SerializeField]
		private GameObject _arenaPlayerAirWalls;

		[SerializeField]
		private RankedArenaSoundPlayer _rankedArenaSoundPlayer;

		[SerializeField]
		private ArenaStateScreensController _arenaStateScreensController;

		private readonly List<MPlayer> _cachedPlayers;

		private TeamScoresUpdatedMessageData _messageData;

		private readonly CountDownMessageData _countDownMessageData;

		private MFSM _mFsm;

		private float _cacheTimerRemainingTime;

		private IMessageSubscriber[] _clientMessageSubscribers;

		private IMessageSubscriber[] _serverMessageSubscribers;

		private static Changed<MArenaGameManagerRanked> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MArenaGameManagerRanked> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MArenaGameManagerRanked> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(1, 13)]
		[Networked]
		private GameSettings GameSettings
		{
			get
			{
				return default(GameSettings);
			}
			set
			{
			}
		}

		[NetworkedWeaved(14, 17)]
		[Networked]
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
		[NetworkedWeaved(31, 17)]
		private NetworkString<_16> TeamOneId
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
		[NetworkedWeaved(48, 17)]
		private NetworkString<_16> TeamTwoId
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
		[NetworkedWeaved(65, 1)]
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

		[Networked]
		[NetworkedWeaved(66, 1)]
		private TeamNo WinningTeam
		{
			get
			{
				return default(TeamNo);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(67, 1)]
		private NetworkBool IsMatchForfeit
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		protected override void SetInitialStateAfterSpawned()
		{
		}

		protected override void HandleDespawnInternal()
		{
		}

		private bool IsRankedSessionActive()
		{
			return false;
		}

		private void HandleMatchControllerEvents(MMatchController matchController, bool register)
		{
		}

		private void RestartMatch()
		{
		}

		private void S_WaitForPlayers(MFSM.Phase phase)
		{
		}

		private void S_TeamSetup(MFSM.Phase phase)
		{
		}

		private void RegisterAndPreservePlayers(List<MPlayer> cachedPlayers)
		{
		}

		private void SetUpTeams(RankedTeamSetUpHelper.MmrPlayer[] mmrPlayers, List<MPlayer> cachedPlayers)
		{
		}

		private void AssignTeamsForLocalServer(RankedTeamSetUpHelper.MmrPlayer[] mmrPlayers, List<MPlayer> cachedPlayers, TeamNo teamNo)
		{
		}

		private void S_TeamPreparation(MFSM.Phase phase)
		{
		}

		private void S_TeamEnterArena(MFSM.Phase phase)
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

		private void S_NextRoundCountDown(MFSM.Phase phase)
		{
		}

		private void S_Match(MFSM.Phase phase)
		{
		}

		private void S_End(MFSM.Phase phase)
		{
		}

		private void SetWinnerInfo()
		{
		}

		private void S_ArenaClosing(MFSM.Phase phase)
		{
		}

		private void S_ArenaClosed(MFSM.Phase phase)
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

		private void EnableDoorForState()
		{
		}

		private void OpenShuttleDoorForLocalPlayerTeam()
		{
		}

		private int HandleLocalPlayerTeamChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private int HandleGeneralMessage(IMessage<GeneralMessage> message)
		{
			return 0;
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerRemoved(IMessage<PlayerRemovedMessage> message)
		{
			return 0;
		}

		private static RankedPlayerSessionData GenerateRankedPlayerSessionDataFromPreservedData(string playFabId, ServerPersistentData.PreservedArenaPlayerData preservedPlayer)
		{
			return null;
		}

		private void HandleBulwarpRestrictionAreaForState()
		{
		}

		private void TogglePlayerAirWalls(bool enable)
		{
		}

		private void UpdateBulwarpPlaceablesArea()
		{
		}

		[AsyncStateMachine(typeof(_003CAddFreeCurrencyForPlayers_003Ed__98))]
		private void AddFreeCurrencyForPlayers(TeamNo winningTeam, string currentMatchId, bool isForfeit)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, Channel = RpcChannel.Reliable, InvokeResim = true)]
		private void Rpc_ConfirmFreeCurrency(NetworkString<_16> playerFabId, NetworkBool success, int amount)
		{
		}

		private void ServerSharedData_OnMatchmakingPlayersChanged(ServerSharedData.Change change)
		{
		}

		private void TryChangeStateBasedOnPlayers()
		{
		}

		private bool HasEnoughPlayersToKeepMatchActive(out int teamOneCount, out int teamTwoCount)
		{
			teamOneCount = default(int);
			teamTwoCount = default(int);
			return false;
		}

		[ContextMenu("Moon/End Cur Timer")]
		private void DebugEndCurTimer()
		{
		}

		[ContextMenu("Moon/Skip Waiting For Players")]
		private void DebugSkipWaitingForPlayers()
		{
		}

		[ContextMenu("Moon/End Match")]
		private void DebugEndMatch()
		{
		}

		private void ArenaDoorsController_OnPlayerExitDoorControlledAreas()
		{
		}

		private void TryUpdatePlayerNameHiding()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(2, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_ConfirmFreeCurrency_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
