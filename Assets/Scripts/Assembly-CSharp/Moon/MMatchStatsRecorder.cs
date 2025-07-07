using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.Framework.Leaderboard;
using Moon.Leaderboard;
using Moon.MultiPlay;
using Moon.PlayerProfile;
using PlayFab.ServerModels;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon
{
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = SimulationModes.Server)]
	[NetworkBehaviourWeaved(489)]
	public class MMatchStatsRecorder : NetworkBehaviour
	{
		private class PlayerMatchSessionData
		{
			public PlayerAbilityStatsHandler AbilityStatsHandler;

			public PlayerMatchStatsHandler MatchStatsHandler;

			public PlayerDistanceStatsHandler DistanceStatsHandler;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFetchPlayerRankedBanData_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public string playFabId;

			private TaskAwaiter<Dictionary<string, UserDataRecord>?> _003C_003Eu__1;

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

		private const string BanDataKey = "BanData";

		[SerializeField]
		private AnimationCurve _shotDefinitionCurve;

		[SerializeField]
		private List<PlayerTimeOnGroundStat> _playerTimeOnGroundStats;

		[SerializeField]
		private List<PlayerPositionStat> _playerPositionStats;

		[SerializeField]
		[Header("Arena Goals")]
		private Transform _teamOneArenaGoalLine;

		[SerializeField]
		private Transform _teamTwOArenaGoalLine;

		[SerializeField]
		private ArenaTeamArea _teamOneArea;

		[SerializeField]
		private ArenaTeamArea _teamTwoArea;

		[Header("Match Summary Board")]
		[SerializeField]
		private MatchSummaryBoardManager _matchSummaryBoardManager;

		private static readonly Dictionary<string, PlayerMatchSessionData> _playersMatchSessionData;

		private static readonly Dictionary<string, RankedPlayerBanData> _playersRankedBanData;

		private readonly Stopwatch _matchStopwatch;

		private readonly Stopwatch _matchRealTimeStopwatch;

		private IMessageSubscriber[] _subscribers;

		private bool _isRankedMatch;

		private ILeaderboard _leaderboard;

		[DefaultForProperty("LastMatchPlayersStatisticsList", 0, 489)]
		private PlayerLastMatchStatistics[] _LastMatchPlayersStatisticsList;

		private static string _teamOneId;

		private static string _teamTwoId;

		private static Changed<MMatchStatsRecorder> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MMatchStatsRecorder> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MMatchStatsRecorder> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "HandleOnLastMatchPlayersStatisticsListChanged")]
		[Capacity(6)]
		[NetworkedWeaved(0, 489)]
		private NetworkLinkedList<PlayerLastMatchStatistics> LastMatchPlayersStatisticsList => default(NetworkLinkedList<PlayerLastMatchStatistics>);

		private void Awake()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void OnEnable()
		{
		}

		private int HandleOnPlayerInitialized(IMessage<PlayerInitializedMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private void OnDisable()
		{
		}

		public static void SetMatchPlayersData(List<MPlayer> mPlayers)
		{
		}

		[AsyncStateMachine(typeof(_003CFetchPlayerRankedBanData_003Ed__29))]
		public static void FetchPlayerRankedBanData(string playFabId)
		{
		}

		public static void CacheTeamInfoData(string teamOneId, string teamTwoId)
		{
		}

		private static void SetMatchPlayerData(MPlayer mPlayer)
		{
		}

		private static void CreatePlayerRankingMatchSessionData(PlayerRef playerRef, PlayerInfo playerInfo, string playerPlayFabId)
		{
		}

		private int HandleOnPlayerAction(IMessage<PlayerActionMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerPossessionChanged(IMessage<object> message)
		{
			return 0;
		}

		private int HandleOnPlayerAbilityInflicted(IMessage<PlayerAbilityMessageData> message)
		{
			return 0;
		}

		private int HandleOnPlayerEnergyCollected(IMessage<PlayerEnergyCollectedMessage> message)
		{
			return 0;
		}

		private int HandleOnOtherPlayerLocationChanged(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerAmmoStatusChanged(IMessage<PlayerAmmoStatusChangedMessage> message)
		{
			return 0;
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void HandleOnPrepareMatch()
		{
		}

		private void HandleOnStartMatch()
		{
		}

		private void HandleOnCelebrateGoal(GoalMessageData goalMessageData)
		{
		}

		private void HandleOnEndMatch(MatchEndMessageData matchEndMessageData)
		{
		}

		private void HandleLeaderboardUpdateError(string source, int code, string message)
		{
		}

		[Preserve]
		private static void HandleOnLastMatchPlayersStatisticsListChanged(Changed<MMatchStatsRecorder> changed)
		{
		}

		private void NotifyPlayersLastMatchStatsUpdated()
		{
		}

		private int HandleOnPlayerLastMatchStatsUpdated(IMessage<PlayerLastMatchStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerAdded(IMessage<PlayerAddedMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerRemoved(IMessage<PlayerRemovedMessage> message)
		{
			return 0;
		}

		private bool CanRecord()
		{
			return false;
		}

		private bool CanUploadStats()
		{
			return false;
		}

		private bool TryGetPlayerMatchSessionData(PlayerRef playerRef, out PlayerMatchSessionData playerMatchSessionData)
		{
			playerMatchSessionData = null;
			return false;
		}

		private void UpdateRankedBanData(string playFabId)
		{
		}

		private bool TryReduceLeaverLevel(string playFabId, out int updatedLeaverLevel)
		{
			updatedLeaverLevel = default(int);
			return false;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
