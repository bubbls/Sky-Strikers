using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.MultiPlay
{
	[RequireComponent(typeof(NetworkSceneManager))]
	public class NetworkSceneManagerRef : SingleMonoBehaviour<NetworkSceneManagerRef, DefaultSingleMonoBehaviourSettings<NetworkSceneManagerRef>>
	{
		public NetworkSceneManager SceneManager => null;
	}
}
