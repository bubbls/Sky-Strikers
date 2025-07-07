using UnityEngine;

namespace Moon.Player.Ability.Observer
{
	public class ObserverLocomotionPlugin : PlayerLocomotionPlugin
	{
		[SerializeField]
		private float _maxMoveSpeed;

		[SerializeField]
		private float _moveAcceleration;

		[SerializeField]
		private float _moveDeceleration;

		[SerializeField]
		private float _moveDamping;

		[SerializeField]
		private float _moveDeadzone;

		[SerializeField]
		private float _verticalMoveXBlockingThreshold;

		private PlayerLocomotion _locomotion;

		private float _cachedMoveMultiplier;

		private Transform _head;

		private Rigidbody _rigidbody;

		private Vector3 _cachedDirection;

		private Vector3 _targetVelocity;

		private Vector3 _moveVelocity;

		private Vector2 _moveInput;

		private Vector2 _verticalMoveInput;

		private Ray _cachedRay;

		private int _cachedHasColliderHitCount;

		public override void InitializeValues(PlayerLocomotion locomotion)
		{
		}

		public override void Apply(PlayerLocomotion locomotion, float deltaTime)
		{
		}

		public override void HandleXRInput(MXRInputData inputData)
		{
		}

		private void UpdateMovement()
		{
		}

		private bool CheckForColliderInMoveDirection(Vector3 velocity)
		{
			return false;
		}
	}
}
