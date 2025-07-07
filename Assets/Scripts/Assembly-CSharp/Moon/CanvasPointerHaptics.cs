using UnityEngine;

namespace Moon
{
	public class CanvasPointerHaptics : MonoBehaviour
	{
		[SerializeField]
		private PhysicalUICanvasPointer _canvasPointer;

		[SerializeField]
		private bool _isLeftHand;

		[Header("Haptics")]
		[Space(5f)]
		[SerializeField]
		private HapticImpulse _pressedHaptic;

		[SerializeField]
		private HapticImpulse _releasedHaptic;

		[SerializeField]
		private HapticImpulse _clickHaptic;

		private void Start()
		{
		}

		private void HandlePress(GameObject pressedObject)
		{
		}

		private void HandleRelease(GameObject releasedObject)
		{
		}

		private void HandleClick(GameObject clickedObject)
		{
		}

		private bool IsObjectValid(GameObject obj)
		{
			return false;
		}
	}
}
