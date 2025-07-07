using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chamber8.Framework.Service.PlayFab
{
	public interface IPlayFabAccountService
	{
		void Login(Action onComplete, Action onError);

		LinkedPlayFabAccount GetLoggedInAccount();

		Task<string> GetPhotonAuthToken(CancellationToken cancellationToken, string appId, bool forceRefresh = false);
	}
}
