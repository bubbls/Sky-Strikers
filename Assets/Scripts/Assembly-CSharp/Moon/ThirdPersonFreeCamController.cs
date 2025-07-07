using System;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon
{
	[RequireComponent(typeof(FreeCamTargetSelector))]
	public class ThirdPersonFreeCamController : GameCamera
	{
		[SerializeField]
		private CinemachineFreeLook _freeLookCamera;

		[Space(5f)]
		[Header("Move & Rotate Actions")]
		[SerializeField]
		private InputActionReference _zoomInputAction;

		[SerializeField]
		private InputActionReference _flippedZoomInputAction;

		[SerializeField]
		private InputActionReference _rotationInputAction;

		[SerializeField]
		private InputActionReference _flippedRotationInputAction;

		[SerializeField]
		private InputActionReference _heightLockedRotationInputAction;

		[SerializeField]
		private InputActionReference _flippedHeightLockedRotationInputAction;

		[Header("Camera Functions Actions")]
		[Space(5f)]
		[SerializeField]
		private InputActionReference _lockHeightAction;

		[SerializeField]
		private InputActionReference _ascendInputAction;

		[SerializeField]
		private InputActionReference _descendInputAction;

		[SerializeField]
		private InputActionReference _reloadSettings;

		[SerializeField]
		private InputActionReference _toggleCollisionInputAction;

		[SerializeField]
		private CinemachineInputProvider _cinemachineInputProvider;

		[SerializeField]
		private float _minZoom;

		[SerializeField]
		private float _maxZoom;

		[SerializeField]
		private float _ascendMultiplier;

		[Space(5f)]
		[SerializeField]
		private FreeCamSettingsController _freeCamSettingsController;

		private FreeCamTargetSelector _targetSelector;

		private CinemachineCollider _cinemachineCollider;

		private FreeCamSettings _freeCamSettings;

		private bool _isHeightLocked;

		private float _currentZoom;

		private float _topRigDistance;

		private float _middleRigDistance;

		private float _bottomRigDistance;

		private float _topRigHeight;

		private float _middleRigHeight;

		private float _bottomRigHeight;

		private float _lastInput;

		private float _targetZoom;

		private float _targetZoomSpeed;

		private float _zoomVelocity;

		private InputAction _currentZoomInputAction;

		public override void Initialize()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void HandleZoom()
		{
		}

		private void HandleAscendDescend()
		{
		}

		private void LockHeightAction_OnPerformed(InputAction.CallbackContext context)
		{
		}

		private void TargetSelector_OnNewTargetSelected(Transform target)
		{
		}

		private void ToggleCollisionInputAction_OnPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void ReloadSettingsAction_OnPerformed(InputAction.CallbackContext ctx)
		{
		}

		private void ApplySettings()
		{
		}

		private void ApplyUpdateInputActions()
		{
		}

		private void ValidateInputSourceAndExecuteAction(InputControl inputControl, Action action)
		{
		}

		private bool ValidateInputSource(InputControl inputControl)
		{
			return false;
		}
	}
}
