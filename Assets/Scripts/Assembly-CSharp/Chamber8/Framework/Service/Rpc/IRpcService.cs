using System;

namespace Chamber8.Framework.Service.Rpc
{
	public interface IRpcService
	{
		void RegisterService(string serviceName, IRpcServer server);

		void UnregisterService(string serviceName, IRpcServer server);

		void SendRequestToServer(Request request, Action<Response> onComplete);

		void BroadcastToAllClients(Request request);
	}
}
