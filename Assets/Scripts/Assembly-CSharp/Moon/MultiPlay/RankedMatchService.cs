using System;
using System.Net;
using Chamber8.Framework.Common;
using PlayFab;
using PlayFab.CloudScriptModels;
using UnityEngine.Scripting;

namespace Moon.MultiPlay
{
	[Preserve]
	public class RankedMatchService : IInitializer
	{
		private const string PlayFabIds = "PlayFabIds";

		private const string RankedPlayerSessionDataContainerJson = "RankedPlayerSessionDataContainerJson";

		private PlayFabCloudScriptInstanceAPI _cloudScriptServerInstanceAPI;

		private PlayFabCloudScriptInstanceAPI _cloudScriptPlayerInstanceAPI;

		public void Initialize()
		{
		}

		public void RegisterRankedMatchPlayers(RankedPlayerSessionDataContainer playerSessionDataContainer)
		{
		}

		public void UnregisterRankedMatchPlayers()
		{
		}

		private string GetPlayFabIdsString()
		{
			return null;
		}

		public void CheckIfPlayerIsEligibleForRankedMatch(Action<HttpStatusCode, RankedPlayerEligibilityResult> callback)
		{
		}

		public void GetPlayerRankedStatus(Action<HttpStatusCode, RankedPlayerEligibilityResult> callback)
		{
		}

		private static void HandleRankedEligibilityResult(ExecuteFunctionResult cloudScriptResult, Action<HttpStatusCode, RankedPlayerEligibilityResult> callback)
		{
		}
	}
}
