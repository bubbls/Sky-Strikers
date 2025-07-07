using Fusion;

namespace Moon.AI.VisualScripting
{
	public abstract class MTask : MDriverAccessor, INetworkTask, IGameObjectAccessor
	{
		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public virtual void Spawned()
		{
		}

		public virtual void OnRenderPlayer(NetworkBehaviour networkBehaviour)
		{
		}

		public virtual void OnStateAuthorityUpdate(NetworkBehaviour networkBehaviour)
		{
		}

		public virtual void OnPlayerUpdate(NetworkBehaviour networkBehaviour)
		{
		}
	}
}
