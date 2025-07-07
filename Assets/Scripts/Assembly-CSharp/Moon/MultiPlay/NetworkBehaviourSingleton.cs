using Fusion;

namespace Moon.MultiPlay
{
	[NetworkBehaviourWeaved(0)]
	public abstract class NetworkBehaviourSingleton<T> : NetworkBehaviour where T : NetworkBehaviourSingleton<T>
	{
		private static Changed<NetworkBehaviourSingleton<>> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<NetworkBehaviourSingleton<>> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<NetworkBehaviourSingleton<>> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected static T Instance { get; private set; }

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
