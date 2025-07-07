using System.Collections.Generic;
using Fusion;

namespace Moon.AI.VisualScripting
{
	public abstract class MOnNetworkMessageReceived : MDriverAccessor
	{
		protected delegate void NetworkDataHandler(NetworkObject networkObject, NetworkData data, RpcInfo rpcInfo);

		private readonly Dictionary<int, NetworkDataHandler> _msgHandlers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected void SetMessageHandler(int messageId, NetworkDataHandler handler)
		{
		}

		private void HandleNetworkMessageReceived(NetworkObject networkObject, byte[] data, RpcInfo rpcInfo, RpcSources rpcSources)
		{
		}
	}
}
