using System;

namespace Moon.MultiPlay
{
	[Serializable]
	public class RankedBanConfiguration
	{
		public int Version;

		public int LeaverLevelReductionPeriod;

		public int LeaverLevelReductionPerPeriod;

		public int MaxLeaverLevel;

		public int BanDurationFormulaLinearMultiplier;

		public int BanDurationFormulaExponentialMultiplier;

		public int MaxBanDuration;

		public int MMRReductionPerLeaverLevel;
	}
}
