using UnityEngine;

namespace Moon.Shop.Common
{
	public class VRPhysicsButtonCanPressTrigger : MonoBehaviour
	{
		[SerializeField]
		private GameObject _interactionGameObject;

		[SerializeField]
		private BoxCollider _canPressTrigger;

		[SerializeField]
		private BoxCollider _pressAreaTrigger;

		public bool CanPress { get; private set; }

		public void ToggleCanPressTrigger(bool enable)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
