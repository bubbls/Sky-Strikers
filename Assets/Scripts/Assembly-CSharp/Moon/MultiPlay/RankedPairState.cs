namespace Moon.MultiPlay
{
	public enum RankedPairState : byte
	{
		Empty = 0,
		Preparing = 1,
		InQueue = 2,
		FoundMatch = 3,
		Cooldown = 4
	}
}
