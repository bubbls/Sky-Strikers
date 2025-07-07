using UnityEngine;
using UnityEngine.UI;

namespace Moon.Arena
{
	[RequireComponent(typeof(BoxCollider))]
	public class DynamicVisibleArea : MonoBehaviour
	{
		private Renderer[] _renderers;

		private Graphic[] _graphics;

		private Transform _target;

		public Transform target => null;

		private void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}
	}
}
