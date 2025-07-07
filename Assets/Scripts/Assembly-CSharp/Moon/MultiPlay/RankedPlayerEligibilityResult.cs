using System;

namespace Moon.MultiPlay
{
	[Serializable]
	public class RankedPlayerEligibilityResult
	{
		public RankedPlayerEligibility Eligibility;

		public int RemainingBanDurationInSeconds;

		public RankedPlayerSessionData PlayerSessionData;
	}
}
