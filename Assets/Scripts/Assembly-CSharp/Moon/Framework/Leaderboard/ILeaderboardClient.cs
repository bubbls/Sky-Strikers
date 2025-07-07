using System;
using System.Collections.Generic;

namespace Moon.Framework.Leaderboard
{
	public interface ILeaderboardClient
	{
		void GetMyStatistics(IEnumerable<string> names, Action<List<Statistic>> onComplete, Action onError);

		void GetLeaderboardAroundMe(string statisticName, int count, Action<IEnumerable<LeaderboardEntry>> onComplete, Action onError);

		void GetLeaderboard(string statisticName, int count, Action<IEnumerable<LeaderboardEntry>> onComplete, Action onError);
	}
}
