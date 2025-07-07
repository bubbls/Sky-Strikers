using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using Moon.Framework.Service.PlayFab.CloudScript;
using PlayFab;
using UnityEngine.Scripting;

namespace Moon.Mission
{
	[Preserve]
	public class LotteryService : IInitializer
	{
		private class ResponseActions
		{
			public Action<PrizePool> OnSuccess;

			public Action OnError;
		}

		private class PendingRequest
		{
			public string MachineId;

			public readonly List<ResponseActions> ActionsList;
		}

		private const string ArgMachineId = "MachineId";

		private PlayFabCloudScriptInstanceAPI _cloudScriptInstanceAPI;

		private readonly Dictionary<string, PendingRequest> _pendingRequests;

		public void Initialize()
		{
		}

		public void GetPrizePool(string machineId, Action<PrizePool> onSuccess, Action onError)
		{
		}

		private void InvokeError(string machineId)
		{
		}

		private void InvokeSuccess(string machineId, PrizePool prizePool)
		{
		}

		public void DrawPrize(string machineId, Action<Prize> onSuccess, Action<CloudScriptResp<Prize>> onError)
		{
		}
	}
}
