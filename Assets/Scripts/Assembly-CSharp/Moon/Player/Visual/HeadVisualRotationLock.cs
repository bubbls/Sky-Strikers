using UnityEngine;

namespace Moon.Player.Visual
{
	public class HeadVisualRotationLock : MonoBehaviour
	{
		[SerializeField]
		private Transform _headModel;

		[SerializeField]
		private Vector3 _minLocalRotation;

		[SerializeField]
		private Vector3 _maxLocalRotation;

		private Quaternion _currentRotation;

		private Quaternion _targetRotation;

		private float _currentAngleX;

		private float _currentAngleZ;

		private void LateUpdate()
		{
		}

		public void ForceUpdate()
		{
		}

		private static float GetClampedAngle(float angle, float min, float max)
		{
			return 0f;
		}
	}
}
