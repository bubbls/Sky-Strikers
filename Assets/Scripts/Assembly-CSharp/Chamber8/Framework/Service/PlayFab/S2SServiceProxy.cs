using System;
using System.Collections.Generic;
using Chamber8.Framework.Account;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Platform;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	public class S2SServiceProxy : IS2SService
	{
		private static Dictionary<Chamber8.Framework.Platform.Platform, IS2SService> _s2sServices;

		public static bool TryAdd(Chamber8.Framework.Platform.Platform platform, IS2SService s2sService)
		{
			return false;
		}

		public void VerifyOwnership(string skuId, IAccount account, Chamber8.Framework.Platform.Platform platform, Action<bool> onSuccess, Action<Error> onError)
		{
		}
	}
}
