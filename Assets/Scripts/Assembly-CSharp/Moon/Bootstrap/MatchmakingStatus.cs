namespace Moon.Bootstrap
{
	public enum MatchmakingStatus
	{
		None = 0,
		ConnectingToPublic = 1,
		ConnectedToPublic = 2,
		ConnectionToPublicFailed = 3,
		ConnectionToPublicCancelled = 4,
		ConnectingToPrivate = 5,
		ConnectedToPrivate = 6,
		ConnectionToPrivateFailed = 7,
		ConnectionToPrivateCancelled = 8,
		ServerNotFound = 9,
		Cancelling = 10,
		ConnectingToRanked = 11,
		ConnectionToRankedFailed = 12,
		ConnectionToRankedCancelled = 13
	}
}
