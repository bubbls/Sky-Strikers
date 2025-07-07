using System;
using System.Collections.Generic;
using System.Net;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using Fusion;
using Fusion.Sockets.Stun;
using JetBrains.Annotations;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.Class;
using Moon.Framework.Analytics;
using Moon.Hub;
using Moon.Leaderboard;
using Moon.Mission;
using Moon.MultiPlay;
using Moon.Shop;

namespace Moon.Analytics
{
	public class AnalyticsHelper : Singleton<AnalyticsHelper>
	{
		public class TierObject
		{
			public int tier;

			public string bundleId;

			public int freeCurrency;
		}

		public class PrizeObject
		{
			public string BundleId;

			public int Num;

			public PrizeObject(string bundleId, int num)
			{
			}
		}

		private const string FirstPaidTimeKey = "FirstPaidTime";

		private const string DateFormat = "yyyy/MM/dd";

		private IAnalyticsService _analyticsService;

		private int _rttMin;

		private int _rttMax;

		private int _rttAvg;

		private SimulationConfig.Topologies _topology;

		private NATType _natType;

		private DateTime _enterShopTime;

		private DateTime _enterClassChangingRoomTime;

		private DateTime _loggedInTime;

		private int _attractionActualHubBarDuration;

		private int _attractionActualHubBathDuration;

		private int _attractionActualHubArenaDuration;

		public int RTT => 0;

		protected override void Initialize()
		{
		}

		private int OnLocalPlayerLocationChanged(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		private int OnLocalPlayerInfoChanged(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private int OnLocalPlayerStatisticsUpdated(IMessage<PlayerStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		public void LogConnected(SimulationConfig.Topologies photonTopology, NATType photonNATType)
		{
		}

		public void LogRTT(int minInt, int maxInt, int avgInt)
		{
		}

		public void LogMatchStart(string matchId, MatchType matchType, Mode gameSettingsMode, bool isCompetitive)
		{
		}

		public void LogClientError(ClientErrorCode lastErrorCode)
		{
		}

		public void LogShutdownWithError(ShutdownReason shutdownReason, SimulationConfig.Topologies photonTopology, NATType photonNATType)
		{
		}

		private string GetShopDuration()
		{
			return null;
		}

		private double GetActualShopDuration()
		{
			return 0.0;
		}

		private string GetClassRoomDuration()
		{
			return null;
		}

		private double GetActualClassRoomDuration()
		{
			return 0.0;
		}

		private string GetDurationLoggedIn()
		{
			return null;
		}

		private double GetActualDurationLoggedIn()
		{
			return 0.0;
		}

		private void LogClassRoomVisit()
		{
		}

		private void LogShopVisit()
		{
		}

		private static void GetSuperProperties(out Dictionary<string, object> superProperties)
		{
			superProperties = null;
		}

		private Dictionary<string, object> FillCommonShopParameters(Dictionary<string, object> parameters)
		{
			return null;
		}

		public void FlushLogs()
		{
		}

		public void LogPayButtonClick(string currency, float targetPrice, string formattedTargetPrice, int coins)
		{
		}

		public void LogPaySucceeded(string transactionID, string skuId, string currency, float paidAmount, string formattedTargetPrice, int coins, int coinsBalance)
		{
		}

		public void LogPayFailed(string transactionID, string skuID, string failureCategory, string failureType)
		{
		}

		public void LogShopGoodsTryOn(string goodsID, int coins, string goodsName, string goodsCategory)
		{
		}

		public void LogShopGoodsTryOn(string goodsID, Dictionary<string, int> prices, string goodsName, string goodsCategory)
		{
		}

		public void LogShopGoodsBuyNowClick(string goodsID, int coins, string goodsName, string goodsCategory)
		{
		}

		public void LogShopGoodsBuy(string goodsID, int coins, string goodsName, string goodsCategory, string currencyFriendlyId, string orderSource)
		{
		}

		private static int GetBalance(string currencyFriendlyId)
		{
			return 0;
		}

		public void LogShopGoodsBuySucceeded(string goodsID, int coins, string goodsName, string goodsCategory, string currencyFriendlyId, string orderSource)
		{
		}

		public void LogShopGoodsBuyFailed(string goodsID, string failureType, string orderSource)
		{
		}

		public void LogPlayerLoggedIn(string uuid, bool isNewAccount, DateTime createdTime, string ageGroup, string newUserJourneyGroup)
		{
		}

		public void LogTutorialStep(string step, string suitClass, int completedDuration)
		{
		}

		public void LogSessionStart()
		{
		}

		public void LogSessionEnd()
		{
		}

		public void LogCurrencyGain(string currencyName, int gainAmount, int balance, string source, string suitClass = "")
		{
		}

		public void LogCurrencyExchange(string currencyFrom, int amountFrom, string currencyTo, int amountTo)
		{
		}

		public void LogNewTask(MissionRecordList recordList)
		{
		}

		public void LogCompleteTask(string bundleId, string taskBoardId, int numFreeCurrencies, int numActivePoints, int completionDuration)
		{
		}

		public void LogCompleteAllTasks(string taskBoardId, IEnumerable<string> bundleIdList, int completionDuration)
		{
		}

		public void LogClaimTaskReward(IEnumerable<string> bundleIdList, int activePointsGain, int activePointsBalance, int freeCurrenciesGain, int freeCurrenciesBalance, int progressionTier)
		{
		}

		public void LogClaimTaskProgressionReward(List<TierObject> tierObjectList, int freeCurrenciesGain, int freeCurrenciesBalance)
		{
		}

		public void LogDrawPrizeSucceeded(int freeCurrenciesSpent, int freeCurrenciesBalance, Rarity prizeCategory, List<PrizeObject> prizeObjectList)
		{
		}

		public void LogDrawPrizeClick(int freeCurrencyCost, int freeCurrenciesBalance)
		{
		}

		public void LogDrawPrizeFailed(HttpStatusCode failureType)
		{
		}

		public void LogEnterScene(string sceneName)
		{
		}

		public void LogGameEnd(string sceneName, bool isWinner, GameSettings gameSettings, string matchId, bool isCompetitive, string teamId = "")
		{
		}

		public void LogClassPresetButtonPressed(PlayerVisualsPresetSlotFunctionButton.State state)
		{
		}

		public void LogClassDeleteButtonPressed()
		{
		}

		public void LogClassRoomButtonPressed(string buttonName, string sourceName)
		{
		}

		public void LogClassTrySelect(PlayerCustomizationSlotType slotDataSlotType, string themeName)
		{
		}

		private IDictionary<string, object> FillClassRoomParameters(Dictionary<string, object> parameters)
		{
			return null;
		}

		public void LogServerMatchVoteResults(string matchId, HubGameSettings optionOne, HubGameSettings optionTwo, int totalVotes, bool didOptionOneWin)
		{
		}

		private void AddGameSettingsParams(string prefix, HubGameSettings hubGameSettings, ref Dictionary<string, object> refDict)
		{
		}

		public void LogServerGameEnd(string sceneName, string matchId, HubGameSettings hubGameSettings, int actualMatchDuration, int startingParticipants, int endParticipants, int teamOneScore, int teamTwoScore, TeamNo winningTeam, int totalWinners, int totalLosers)
		{
		}

		private static IList<string> GetAllowedClasses(AllowedClasses enumValue)
		{
			return null;
		}

		public void LogHubServerChanged(bool isRandomPublic, string playfabRegion)
		{
		}

		public void LogAttractionVisit(string area)
		{
		}

		public void SetAttractionActualHubBarDuration(int duration)
		{
		}

		public void SetAttractionActualHubArenaDuration(int duration)
		{
		}

		public void SetAttractionActualHubBathAreaDuration(int duration)
		{
		}

		private string GetAttractionDuration(int duration)
		{
			return null;
		}

		private void FillCasualHubParameters(Dictionary<string, object> parameters)
		{
		}

		public void LogHubInteraction(string area, string facilityId, int coinsConsumed = 0)
		{
		}

		public void LogSetGameTag(string tagListName, string tagName, bool isCompleted)
		{
		}

		public void LogHofVisit()
		{
		}

		public void LogRankedMatchSearchButtonPressed()
		{
		}

		public void LogRankedMatchSearchResult(int searchTime, int totalFlowTime, string result)
		{
		}

		public void LogServerRankedMatchTeams(RankedTeamInfo teamOneInfo, RankedTeamInfo teamTwoInfo)
		{
		}

		public void LogServerRankedMatchSummary(string matchId, string teamOnId, string teamTwoId, int teamOneGoals, int teamTwoGoals, int endParticipants, TeamNo winningTeam, bool isForfeit, bool teamOneHasParty, bool teamTwoHasParty)
		{
		}

		public void LogServerRankedMatchWaitResult(int totalPlayersEntered, bool didStartMatch, int waitTime)
		{
		}

		public void LogServerError(string source, int? code, [CanBeNull] string info)
		{
		}

		public void LogServerRankedBanAdded(string playFabId, int leaverLevel)
		{
		}

		public void LogServerRankedBanLevelReduce(string playFabId, int leaverLevel)
		{
		}
	}
}
