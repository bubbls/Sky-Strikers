using UnityEngine;

namespace Moon.Player.Visual
{
	public class RotateByVelocity : MonoBehaviour
	{
		[SerializeField]
		private float _moveForwardAngle;

		[SerializeField]
		private float _moveBackwardAngle;

		[SerializeField]
		private float _idleAngle;

		[SerializeField]
		private float _idleThreshold;

		[SerializeField]
		private float _rotationSpeed;

		[SerializeField]
		private PlayerVisualsVelocityTracker _velocityTracker;

		[SerializeField]
		private Transform[] _transToRotate;

		private Vector3 _velocity;

		private Vector3 _worldVelocity;

		private Quaternion _currentRotation;

		private Quaternion _targetRotation;

		private float _targetAngle;

		private void LateUpdate()
		{
		}
	}
}
