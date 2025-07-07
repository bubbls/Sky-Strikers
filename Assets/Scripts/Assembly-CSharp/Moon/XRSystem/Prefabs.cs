using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.XRSystem
{
	[CreateAssetMenu(menuName = "XR System/Prefabs", fileName = "Prefabs")]
	public class Prefabs : SingleScriptableObject<Prefabs, DefaultResourcePathProvider<Prefabs>>
	{
		[SerializeField]
		private GameObject _debugSphere;

		[SerializeField]
		private GameObject _debugLine;

		public GameObject DebugSphere => null;

		public GameObject DebugLine => null;
	}
}
