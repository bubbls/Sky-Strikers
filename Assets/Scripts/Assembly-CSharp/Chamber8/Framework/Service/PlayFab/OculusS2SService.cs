using System;
using Chamber8.Framework.Account;
using Chamber8.Framework.Common;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Platform;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	public class OculusS2SService : IS2SService, IInitializer
	{
		public void Initialize()
		{
		}

		public void VerifyOwnership(string skuId, IAccount account, Chamber8.Framework.Platform.Platform platform, Action<bool> onSuccess, Action<Error> onError)
		{
		}
	}
}
