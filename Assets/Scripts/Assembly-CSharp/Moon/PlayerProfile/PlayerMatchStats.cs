using System.Collections.Generic;
using Moon.Arena;

namespace Moon.PlayerProfile
{
	public class PlayerMatchStats
	{
		public string MatchId;

		public List<PlayerGoalInfo> GoalsScored;

		public int TotalPlayTime;

		public int RealTotalPlayTime;

		public int TotalAllPlayersPossessionTime;

		public bool ScoredMostGoals;

		public int BuzzardBeaters;

		public MatchResult MatchResult;

		public TeamNo TeamNo;

		public int EnergyCount;

		public int EnergyCollectFromOpponent;

		public int EnergyConsumedCount;

		public int MyTeamGoals;

		public int OpponentTeamGoals;
	}
}
