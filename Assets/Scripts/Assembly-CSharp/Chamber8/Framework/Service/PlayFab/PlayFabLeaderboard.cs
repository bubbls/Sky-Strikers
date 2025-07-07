using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using Moon.Framework.Leaderboard;
using PlayFab;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	public class PlayFabLeaderboard : ILeaderboard, IInitializer
	{
		private PlayFabServerInstanceAPI _server;

		public void Initialize()
		{
		}

		public void WriteStatistics(string playFabId, IEnumerable<Statistic> statistics, Action onComplete, Action<int, string> onError, bool keepZeroValues = false)
		{
		}

		public void GetStatistics(string playFabId, IEnumerable<string> names, Action<List<Statistic>> onComplete, Action onError)
		{
		}
	}
}
