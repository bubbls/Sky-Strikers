using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

namespace Moon
{
	public class PlayerHandOffsetHandler : MonoBehaviour
	{
		[Serializable]
		private class XRControllerOffsets
		{
			public string ControllerName;

			public Vector3 PositionOffset;

			public Vector3 RotationOffset;
		}

		[SerializeField]
		private Transform _targetHandFollowReference;

		[SerializeField]
		private Transform _offsetReference;

		[SerializeField]
		private Transform _rangeLimitReference;

		[SerializeField]
		private float _maxRange;

		[Space(5f)]
		[SerializeField]
		private XRControllerOffsets[] _openXrOffsets;

		[SerializeField]
		private InputActionReference _rotateHandsUpAction;

		[SerializeField]
		private InputActionReference _rotateHandsDownAction;

		[SerializeField]
		private bool _isRightController;

		private XRNode _xrNode;

		private Transform _transform;

		private Vector3 _cachedFollowRotationOffset;

		private Vector3 _cachedPositionOffset;

		private Vector3 _targetHandPosition;

		private float _distanceFromHandRangeCenter;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void ModifyRotationOffset(float xOffset, float yOffset, float zOffset)
		{
		}

		private void SetRotationOffset(UnityEngine.XR.InputDevice inputDevice)
		{
		}

		private void InputDevices_OnDeviceConnected(UnityEngine.XR.InputDevice device)
		{
		}
	}
}
