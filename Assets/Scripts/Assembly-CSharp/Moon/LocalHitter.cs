using UnityEngine;

namespace Moon
{
	public class LocalHitter : MonoBehaviour
	{
		[SerializeField]
		private bool _isLeft;

		private Collider _collider;

		public bool IsLeft => false;

		private void Awake()
		{
		}

		public void ToggleCollider(bool enable)
		{
		}
	}
}
