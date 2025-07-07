namespace Moon.MultiPlay
{
	public enum RankedMatchmakingStatus
	{
		None = 0,
		Preparing = 1,
		Searching = 2,
		Cancelling = 3,
		FoundMatch = 4,
		Cancelled = 5,
		NextSearchCooldown = 6,
		AlreadyInMatch = 7,
		RejoiningExistingMatch = 8,
		Banned = 9,
		PrepareError = 10
	}
}
