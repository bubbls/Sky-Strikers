using System;
using System.Collections.Generic;

namespace Moon.Framework.Leaderboard
{
	public interface ILeaderboard
	{
		void WriteStatistics(string playFabId, IEnumerable<Statistic> statistics, Action onComplete, Action<int, string> onError, bool keepZeroValues = false);

		void GetStatistics(string playFabId, IEnumerable<string> names, Action<List<Statistic>> onComplete, Action onError);
	}
}
