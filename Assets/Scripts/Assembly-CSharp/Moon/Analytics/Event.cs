namespace Moon.Analytics
{
	public static class Event
	{
		public const string Connected = "connected";

		public const string MatchStart = "match_start";

		public const string ClientError = "client_error";

		public const string ShutdownWithError = "shutdown_with_error";

		public const string Tutorial = "tutorial";

		public const string GameEnd = "gameEnd";

		public const string SetGameTag = "setGameTag";

		public const string UserLoggedIn = "userLoggedIn";

		public const string ShopVisit = "shopVisit";

		public const string PayButtonClick = "payButtonClick";

		public const string PaySucceeded = "paySucceeded";

		public const string PayFailed = "payFailed";

		public const string ShopGoodsTryOn = "shopGoodsTryOn";

		public const string ShopGoodsBuyNowClick = "shopGoodsBuyNowClick";

		public const string ShopGoodsBuy = "shopGoodsBuy";

		public const string ShopGoodsBuySucceeded = "shopGoodsBuySucceeded";

		public const string ShopGoodsBuyFailed = "shopGoodsBuyFailed";

		public const string Session = "session";

		public const string SessionSummary = "sessionSummary";

		public const string SessionSummaryFirst = "sessionSummaryFirst";

		public const string CurrencyGain = "currencyGain";

		public const string CurrencyExchange = "currencyExchange";

		public const string HubServerChanged = "hubServerChange";

		public const string AttractionVisit = "attractionVisit";

		public const string HubInteraction = "hubInteraction";

		public const string HOFVisit = "hofVisit";

		public const string RankedMatchSearchButton = "rankedMatchSearchButtonPressed";

		public const string RankedMatchSearchResult = "rankedMatchSearchResult";

		public const string RankedMatchTeams = "rankedMatchTeams";

		public const string RankedMatchSummary = "rankedMatchSummary";

		public const string RankedMatchWaitResult = "rankedMatchWaitResult";

		public const string ClassRoomVisit = "classRoomVisit";

		public const string ClassPresetButtonPressed = "classPresetBtnPressed";

		public const string ClassPresetDeleteButtonPressed = "classPresetDeleteBtnPressed";

		public const string ClassRoomButtonPressed = "classRoomBtnPressed";

		public const string ClassTrySelect = "trySelect";

		public const string NewTask = "newTask";

		public const string CompleteTask = "completeTask";

		public const string CompleteAllTasks = "completeAllTasks";

		public const string ClaimTaskReward = "claimTaskReward";

		public const string ClaimTaskProgressionReward = "claimTaskProgressionReward";

		public const string DrawPrizeSucceeded = " drawPrizeSucceeded";

		public const string DrawPrizeClick = "drawPrizeClick";

		public const string DrawPrizeFailed = "drawPrizeFailed";

		public const string EnterScene = "enterScene";

		public const string ServerMatchVotingResult = "serverMatchVotingResult";

		public const string ServerGameEnd = "serverGameEnd";

		public const string ServerError = "serverError";

		public const string ServerRankedBanAdded = "serverRankedBanAdded";

		public const string ServerRankedLeaverLevelReduced = "serverRankedLeaverLevelReduced";
	}
}
