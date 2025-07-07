using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.AI.VisualScripting
{
	public class MUtils : MonoBehaviour
	{
		[Preserve]
		public static NetworkId GetDefaultNetworkId()
		{
			return default(NetworkId);
		}

		[Preserve]
		public static PlayerRef GetPlayerRefNone()
		{
			return default(PlayerRef);
		}

		[Preserve]
		public static NetworkObject GetNetworkObject(GameObject gameObject)
		{
			return null;
		}

		[Preserve]
		public static NetworkId GetNetworkId(GameObject gameObject)
		{
			return default(NetworkId);
		}
	}
}
