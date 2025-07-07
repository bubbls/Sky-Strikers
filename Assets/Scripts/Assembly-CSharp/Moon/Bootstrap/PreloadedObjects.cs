using UnityEngine;

namespace Moon.Bootstrap
{
	[DefaultExecutionOrder(-30)]
	public class PreloadedObjects : MonoBehaviour
	{
		[SerializeField]
		private GameObject[] _objects;

		[SerializeField]
		private GameObject[] _editorOnlyObjects;

		private void Awake()
		{
		}

		private void InstantiateObjectList(in GameObject[] gameObjects, Transform parent)
		{
		}
	}
}
