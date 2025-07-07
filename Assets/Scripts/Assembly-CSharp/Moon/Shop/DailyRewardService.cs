using System;
using System.Net;
using Chamber8.Framework.Common;
using PlayFab;
using UnityEngine.Scripting;

namespace Moon.Shop
{
	[Preserve]
	public class DailyRewardService : IInitializer
	{
		private PlayFabCloudScriptInstanceAPI _cloudScriptInstanceAPI;

		public void Initialize()
		{
		}

		public void GetDailyReward(Action<DailyRewardConfig> onSuccess, Action<HttpStatusCode, string> onError)
		{
		}

		public void GetDailyRewardInfo(Action<DailyRewardInfo> onSuccess, Action<HttpStatusCode, string> onError)
		{
		}

		public void ClaimDailyRewards(Action<ClaimDailyRewardsResult> onSuccess, Action<HttpStatusCode, string> onError)
		{
		}
	}
}
