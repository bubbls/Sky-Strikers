using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(34)]
	public class MArenaGameManager : MGameManager
	{
		private const float WaitTimeAfterAGoal = 7f;

		private const float WaitTimeAfterOneMatch = 8f;

		private const float NewMatchCountDownTime = 5f;

		private const float NextRoundCountDownTime = 3f;

		private const float SummaryDuration = 120f;

		private const string StaPrepare = "Prepare";

		private const string StaMatch = "Match";

		private const string StaEnd = "End";

		private const string StaGoal = "Goal";

		private const string StaNextRound = "NextRound";

		private const string StaSummary = "Summary";

		[DefaultForProperty("GameSettings", 1, 13)]
		private GameSettings _GameSettings;

		[DefaultForProperty("CurrentMatchId", 14, 17)]
		private NetworkString<_16> _CurrentMatchId;

		[DefaultForProperty("PauseTimer", 31, 1)]
		private TickTimer _PauseTimer;

		[DefaultForProperty("CurrentMatchController", 32, 2)]
		private MMatchController _CurrentMatchController;

		[SerializeField]
		private GameSettings _localGameSettings;

		[SerializeField]
		private MSkyballMatchController _skyballMatchController;

		[SerializeField]
		private MatchSummaryBoardManager _matchSummaryBoardManager;

		[SerializeField]
		private MArenaDoorsController _arenaDoorsController;

		[SerializeField]
		private GameObject _arenaPlayerAirWalls;

		private TeamScoresUpdatedMessageData _messageData;

		private readonly CountDownMessageData _countDownMessageData;

		private MFSM _mFsm;

		private float _cacheTimerRemainingTime;

		private readonly List<MPlayer> _cachedPlayers;

		private IMessageSubscriber[] _subscribers;

		private static Changed<MArenaGameManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MArenaGameManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MArenaGameManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(1, 13)]
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

		[NetworkedWeaved(31, 1)]
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

		[Networked]
		[NetworkedWeaved(32, 2)]
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

		private void Awake()
		{
		}

		private int HandleMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void OnDisable()
		{
		}

		protected override void SetInitialStateAfterSpawned()
		{
		}

		private int HandleOnPlayerInitialized(IMessage<PlayerInitializedMessage> message)
		{
			return 0;
		}

		protected override void HandleDespawnInternal()
		{
		}

		private void HandleMatchControllerEvents(MMatchController matchController, bool register)
		{
		}

		[ContextMenu("Moon/Restart Match")]
		private void DebugRestartMatch()
		{
		}

		private void RestartMatch(GameSettings newSettings)
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

		private void S_Summary(MFSM.Phase phase)
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

		private void HandleNewMatch(GameSettings newSettings)
		{
		}

		private void ToggleSceneShuttleHubConsole(bool toggle)
		{
		}

		private void EnableDoorForState()
		{
		}

		private void HandleBulwarpRestrictionAreaForState()
		{
		}

		private void TogglePlayerAirWalls(bool enable)
		{
		}

		[ContextMenu("Moon/End Cur Timer")]
		private void DebugEndCurTimer()
		{
		}

		[ContextMenu("Moon/End Match")]
		private void DebugEndMatch()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
