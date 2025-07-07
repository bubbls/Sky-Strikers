using System;
using UnityEngine;

namespace Moon
{
	[Serializable]
	public class FreeCamSettings
	{
		public enum InputSource
		{
			All = 0,
			KeyboardAndMouse = 1,
			Gamepad = 2
		}

		private const float FreeCamMoveSpeedLimit = 60f;

		private const float FreeCamMoveAccelerationLimit = 20f;

		private const float FreeCamMoveDecelerationLimit = 20f;

		private const float FreeCamMoveDampingLimit = 350f;

		private const float FreeCamLookSpeedLimit = 60f;

		private const float FreeCamLookAccelerationLimit = 20f;

		private const float FreeCamLookDecelerationLimit = 20f;

		private const float FreeCamLookDampingLimit = 350f;

		private const float DeadZoneLimit = 1f;

		private const float ThirdPersonZoomSpeedLimit = 10f;

		private const float ThirdPersonZoomAccelerationLimit = 10f;

		private const float ThirdPersonZoomDecelerationLimit = 10f;

		private const float ThirdPersonYSensitivityBase = 0.025f;

		private const float ThirdPersonXSensitivityBase = 6.5f;

		private const float ThirdPersonXSensitivityLimit = 50f;

		private const float ThirdPersonYSensitivityLimit = 50f;

		public InputSource ActiveInputSource;

		[Header("Free Cam Movement")]
		public float FreeCamMaxMoveSpeed;

		public float FreeCamMoveAcceleration;

		public float FreeCamMoveDeceleration;

		public float FreeCamMoveDeadZone;

		public float FreeCamMoveDamping;

		[Header("Free Cam Rotation")]
		[Space(5f)]
		public float FreeCamMaxLookSpeed;

		public float FreeCamLookAcceleration;

		public float FreeCamLookDeceleration;

		public float FreeCamLookDamping;

		public float FreeCamLookDeadZone;

		[Space(5f)]
		[Header("Third Person")]
		public float ThirdPersonZoomSpeed;

		public float ThirdPersonZoomAcceleration;

		public float ThirdPersonZoomDeceleration;

		public float ThirdPersonXSensitivity;

		public float ThirdPersonYSensitivity;

		public bool ThirdPersonSwapZoomAndRotate;

		public float GetFreeCamMaxMoveSpeed()
		{
			return 0f;
		}

		public float GetFreeCamMoveAcceleration()
		{
			return 0f;
		}

		public float GetFreeCamMoveDeceleration()
		{
			return 0f;
		}

		public float GetMoveDeadZone()
		{
			return 0f;
		}

		public float GetFreeCamMoveDamping()
		{
			return 0f;
		}

		public float GetFreeCamLookDeadZone()
		{
			return 0f;
		}

		public float GetFreeCamMaxLookSpeed()
		{
			return 0f;
		}

		public float GetFreeCamLookAcceleration()
		{
			return 0f;
		}

		public float GetFreeCamLookDeceleration()
		{
			return 0f;
		}

		public float GetFreeCamLookDamping()
		{
			return 0f;
		}

		public float GetThirdPersonZoomSpeed()
		{
			return 0f;
		}

		public float GetThirdPersonZoomAcceleration()
		{
			return 0f;
		}

		public float GetThirdPersonZoomDeceleration()
		{
			return 0f;
		}

		public float GetThirdPersonXSensitivity()
		{
			return 0f;
		}

		public float GetThirdPersonYSensitivity()
		{
			return 0f;
		}
	}
}
