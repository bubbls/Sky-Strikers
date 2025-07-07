using Fusion;

namespace Moon.AI.VisualScripting
{
	public interface INetworkTask : IGameObjectAccessor
	{
		void Spawned();

		void OnRenderPlayer(NetworkBehaviour networkBehaviour);

		void OnStateAuthorityUpdate(NetworkBehaviour networkBehaviour);

		void OnPlayerUpdate(NetworkBehaviour networkBehaviour);
	}
}
