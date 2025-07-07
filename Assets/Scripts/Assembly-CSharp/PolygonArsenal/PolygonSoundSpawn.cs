using UnityEngine;

namespace PolygonArsenal
{
	public class PolygonSoundSpawn : MonoBehaviour
	{
		public GameObject prefabSound;

		public bool destroyWhenDone;

		public bool soundPrefabIsChild;

		[Range(0.01f, 10f)]
		public float pitchRandomMultiplier;

		private void Start()
		{
		}
	}
}
