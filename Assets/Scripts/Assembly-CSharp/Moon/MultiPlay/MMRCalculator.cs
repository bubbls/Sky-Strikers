using JetBrains.Annotations;
using Moon.PlayerProfile;

namespace Moon.MultiPlay
{
	public static class MMRCalculator
	{
		private const string ClassName = "MMRCalculator";

		private const string LocalConfigName = "MMRTablesGenerator";

		public static void CalculateMMR(int currentMMR, MatchResult matchResult, out MMRCalculateResultData resultData)
		{
			resultData = null;
		}

		private static void CalculateMMRFromTable(int currentMMR, MatchResult matchResult, out int newMMR, out int changeDifference)
		{
			newMMR = default(int);
			changeDifference = default(int);
		}

		public static void CalculateMMR(int currentMMR, MatchResult matchResult, bool isLeaver, int leaverLevel, out int newMMR, out int changeDifference)
		{
			newMMR = default(int);
			changeDifference = default(int);
		}

		private static MMRScalingTable LoadMMRScalingTable()
		{
			return null;
		}

		public static void CalculateMMR(MMRScalingTable table, int currentMMR, MatchResult matchResult, ref MMRCalculateResultData resultData)
		{
		}

		public static void GetMMRLevel(int currentMMR, out int level, out MMRLevelInfo curLevelInfo, [CanBeNull] out MMRLevelInfo nextLevelInfo)
		{
			level = default(int);
			curLevelInfo = null;
			nextLevelInfo = null;
		}

		private static MMRLevelsTable LoadMMRLevelsTable()
		{
			return null;
		}

		public static void GetMMRLevel(int currentMMR, MMRLevelsTable levelsTable, out int level, out MMRLevelInfo curLevelInfo, [CanBeNull] out MMRLevelInfo nextLevelInfo)
		{
			level = default(int);
			curLevelInfo = null;
			nextLevelInfo = null;
		}

		public static void GetMMRGroupInfo(string mmrTitle, out string groupName, out int index, out int minMMR, out bool isMaxGroup)
		{
			groupName = null;
			index = default(int);
			minMMR = default(int);
			isMaxGroup = default(bool);
		}

		private static MMRGroupsInfoTable LoadMMRGroupsInfoTable()
		{
			return null;
		}

		public static void PreventMMRGroupDemotion(int originalMmr, int newMmr, out int resultMmr)
		{
			resultMmr = default(int);
		}
	}
}
