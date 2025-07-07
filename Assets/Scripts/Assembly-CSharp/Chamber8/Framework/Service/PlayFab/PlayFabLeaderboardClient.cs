using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using Moon.Framework.Leaderboard;
using PlayFab;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	public class PlayFabLeaderboardClient : ILeaderboardClient, IInitializer
	{
		private PlayFabClientInstanceAPI _client;

		public void Initialize()
		{
		}

		public void GetLeaderboardAroundMe(string statisticName, int count, Action<IEnumerable<LeaderboardEntry>> onComplete, Action onError)
		{
		}

		public void GetLeaderboard(string statisticName, int count, Action<IEnumerable<LeaderboardEntry>> onComplete, Action onError)
		{
		}

		public void GetMyStatistics(IEnumerable<string> names, Action<List<Statistic>> onComplete, Action onError)
		{
		}
	}
}
