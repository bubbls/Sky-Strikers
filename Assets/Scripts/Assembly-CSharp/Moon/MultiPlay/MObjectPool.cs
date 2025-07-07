using System.Collections.Generic;
using Chamber8.Framework.Common;
using Fusion;
using UnityEngine.Pool;

namespace Moon.MultiPlay
{
	public class MObjectPool : SingleMonoBehaviour<MObjectPool, OnPlayingNoResourceSingleMonoBehaviourSettings>, INetworkObjectPool
	{
		private class PoolReference
		{
			public ObjectPool<NetworkObject> Pool;
		}

		public struct Status
		{
			public PoolStatus PoolStatus;

			public Dictionary<string, PoolStatus> PoolStatusDetails;
		}

		public struct PoolStatus
		{
			public int CountActive;

			public int CountAll;

			public int CountInactive;
		}

		private readonly Dictionary<NetworkObject, PoolReference> _objectPool;

		private readonly Dictionary<NetworkObject, PoolReference> _instancePoolLookup;

		private readonly Dictionary<string, PoolStatus> _poolStatusDetails;

		private ObjectPool<NetworkObject> GetPool(NetworkObject prefab)
		{
			return null;
		}

		public NetworkObject AcquireInstance(NetworkRunner runner, NetworkPrefabInfo info)
		{
			return null;
		}

		public void ReleaseInstance(NetworkRunner runner, NetworkObject instance, bool isSceneObject)
		{
		}

		public Status GetStatus()
		{
			return default(Status);
		}
	}
}
