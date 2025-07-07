using UnityEngine;

namespace Moon.Framework.Base
{
	[DefaultExecutionOrder(-1)]
	public class EnableInTestMode : MonoBehaviour
	{
		[SerializeField]
		private GameObject[] _gameObjects;

		private void Awake()
		{
		}
	}
}
