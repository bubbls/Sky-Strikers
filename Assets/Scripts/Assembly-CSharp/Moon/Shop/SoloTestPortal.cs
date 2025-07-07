using UnityEngine;

namespace Moon.Shop
{
	public class SoloTestPortal : MonoBehaviour
	{
		[SerializeField]
		private SoloTestPortal _targetTeleportPoint;

		[SerializeField]
		private bool _teleportExitBehind;

		[SerializeField]
		private bool _teleportExitFront;

		[SerializeField]
		private bool _singleTransfer;

		private bool _isEnabled;

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void EnablePortal(bool enable)
		{
		}

		private void Teleport(Transform head)
		{
		}

		private bool IsSameDirection(Transform head, Transform targetTransform)
		{
			return false;
		}
	}
}
