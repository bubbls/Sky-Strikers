using System.Collections.Generic;

namespace Moon.Bootstrap
{
	public struct SipletsSettings
	{
		public int EachPickupProduce;

		public int MaxContribution;

		public string EndDate;

		public List<int> RewardRanks;

		public string GetTimeLeft()
		{
			return null;
		}

		public string GetMaxContributionString()
		{
			return null;
		}

		public int GetRank(int leaderboardPosition)
		{
			return 0;
		}
	}
}
