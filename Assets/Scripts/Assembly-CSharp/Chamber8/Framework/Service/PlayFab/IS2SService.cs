using System;
using Chamber8.Framework.Account;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Platform;

namespace Chamber8.Framework.Service.PlayFab
{
	public interface IS2SService
	{
		void VerifyOwnership(string skuId, IAccount account, Chamber8.Framework.Platform.Platform platform, Action<bool> onSuccess, Action<Error> onError);
	}
}
