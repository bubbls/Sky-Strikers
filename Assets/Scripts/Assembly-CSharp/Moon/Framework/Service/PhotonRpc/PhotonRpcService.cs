using System;
using System.Collections.Generic;
using Chamber8.Framework.Service.Rpc;
using Fusion;
using UnityEngine.Scripting;

namespace Moon.Framework.Service.PhotonRpc
{
	[Preserve]
	internal class PhotonRpcService : IRpcService
	{
		private class RequestEntry
		{
			public Guid RequestId;

			public Action<Response> OnComplete;
		}

		private MPhotonRpcRunner _runner;

		private readonly Dictionary<string, List<RequestEntry>> _requests;

		private readonly Dictionary<string, IRpcServer> _servers;

		public void SetRunner(MPhotonRpcRunner runner)
		{
		}

		public void RegisterService(string serviceName, IRpcServer server)
		{
		}

		public void UnregisterService(string serviceName, IRpcServer server)
		{
		}

		public void SendRequestToServer(Request request, Action<Response> onComplete)
		{
		}

		public void BroadcastToAllClients(Request request)
		{
		}

		private void BroadcastInternal(Request request)
		{
		}

		private void SendRequestToServerInternal(Request request, Action<Response> onComplete)
		{
		}

		private void HandleRequestFromClient(PlayerRef playerRef, Request request)
		{
		}

		private void HandleResponse(Response response)
		{
		}

		private void HandleBroadcastFromServer(Request request)
		{
		}
	}
}
