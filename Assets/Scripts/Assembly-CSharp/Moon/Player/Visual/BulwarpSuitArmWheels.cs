using UnityEngine;

namespace Moon.Player.Visual
{
	public class BulwarpSuitArmWheels : MonoBehaviour
	{
		[SerializeField]
		private PlayerGroundedChecker _groundedChecker;

		[SerializeField]
		private PlayerVisualsVelocityTracker _velocityTracker;

		[SerializeField]
		private Transform _frontLeftWheel;

		[SerializeField]
		private Transform _frontRightWheel;

		[SerializeField]
		private Transform[] _rearWheels;

		[SerializeField]
		private float _wheelSpinMultiplier;

		private Vector3 _curVelocity;

		private float _curSpinSpeed;

		private void LateUpdate()
		{
		}

		private void SpinWheels()
		{
		}
	}
}
