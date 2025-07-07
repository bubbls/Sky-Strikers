using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon
{
	public class FreeCamController : GameCamera, ITeleportable
	{
		[SerializeField]
		[Header("Move & Rotate Actions")]
		private InputActionReference _lookInputAction;

		[SerializeField]
		private InputActionReference _moveInputAction;

		[SerializeField]
		[Header("Camera Functions Actions")]
		[Space(5f)]
		private InputActionReference _ascendInputAction;

		[SerializeField]
		private InputActionReference _descendInputAction;

		[SerializeField]
		private InputActionReference _toggleHeightLockInputAction;

		[SerializeField]
		private InputActionReference _toggleCollisionInputAction;

		[SerializeField]
		private InputActionReference _toggleLocalPlayerVisualsInputAction;

		[SerializeField]
		private InputActionReference _reloadSettings;

		[SerializeField]
		private SphereCollider _sphereCollider;

		[SerializeField]
		private float _rollRemoveSpeed;

		[Space(5f)]
		[SerializeField]
		private FreeCamSettingsController _freeCamSettingsController;

		private FreeCamSettings _freeCamSettings;

		private Rigidbody _rigidbody;

		private Vector2 _moveInput;

		private Vector2 _rotationInput;

		private Vector3 _cachedDirection;

		private Vector3 _targetVelocity;

		private Vector3 _targetPosition;

		private Vector3 _moveVelocity;

		private Vector3 _currentEulerAngles;

		private Vector3 _targetAngularVelocity;

		private Vector3 _targetRotation;

		private Vector3 _angularVelocity;

		private Ray _cachedRay;

		private float _currentPitch;

		private float _currentYaw;

		private float _ascendInput;

		private float _accelerationMod;

		private float _targetLookSensitivityFactor;

		private bool _heightLockEnabled;

		private bool _isPlayerVisible;

		private int _cachedHasColliderHitCount;

		public override void Initialize()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void FixedUpdate()
		{
		}

		private void UpdateMovement()
		{
		}

		private bool CheckForColliderInMoveDirection(Vector3 velocity)
		{
			return false;
		}

		private void UpdateRotation()
		{
		}

		private void UpdateInput()
		{
		}

		private void ToggleHeightLockInputAction_OnPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void ToggleCollisionInputAction_OnPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void ToggleLocalPlayerVisualsInputAction_OnPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void ReloadSettingsAction_OnPerformed(InputAction.CallbackContext ctx)
		{
		}

		private bool ValidateInputSource(InputControl inputControl)
		{
			return false;
		}

		private void ValidateInputSourceAndExecuteAction(InputControl inputControl, Action action)
		{
		}

		public Vector3 GetTeleportableTransformPosition()
		{
			return default(Vector3);
		}

		public void Teleport(Transform thisPlace, Transform otherPlace, bool keepVelocity = false, bool freezeAfterTeleport = false)
		{
		}

		private void CalculateTeleportPosition(Transform thisPlace, Transform otherPlace, out Vector3 targetPos, out Quaternion targetRot)
		{
			targetPos = default(Vector3);
			targetRot = default(Quaternion);
		}
	}
}
