using System;

namespace Chamber8.Framework.Service.Rpc
{
	public interface IRpcServer
	{
		void OnRequestFromClient(Request request, Action<Response?> onComplete);

		void OnBroadcastFromServer(Request request);
	}
}
