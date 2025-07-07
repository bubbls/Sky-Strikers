using System;
using System.Runtime.CompilerServices;
using Liv.Lck;
using Liv.Lck.Recorder;
using Liv.Lck.Smoothing;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVCamera : MonoBehaviour
	{
		[SerializeField]
		private LIVCameraMode _cameraMode;

		[SerializeField]
		private LckCamera _lckCamera;

		[SerializeField]
		private LckStabilizer _lckStabilizer;

		[SerializeField]
		private RectTransform _monitorRectTransform;

		[Header("Operations")]
		[SerializeField]
		private LIVIncreaseDecreaseButton _fovIncreaseDecreaseButton;

		[SerializeField]
		private LIVIncreaseDecreaseButton _smoothnessIncreaseDecreaseButton;

		[SerializeField]
		private LIVIncreaseDecreaseButton _distanceIncreaseDecreaseButton;

		[SerializeField]
		private LIVButton _flipButton;

		[SerializeField]
		[Header("Third Person Config")]
		private float _thirdPersonDistanceMultiplier;

		[SerializeField]
		private float _thirdPersonHeightAngle;

		private CameraTrackDescriptor _currentTrackDescriptor;

		private bool _isHorizontalMode;

		private bool _justTransitioned;

		private bool _isSelfieFront;

		private float _thirdPersonDistance;

		private bool _isThirdPersonFront;

		private bool _isThirdPersonFrontPrev;

		private const float MonitorScale = 0.00025f;

		public string CameraId => null;

		public event Action OnCameraButtonPressed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void ToggleActivation(bool isActive)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnFOVValueChanged(float fovValue)
		{
		}

		private void HandleOnSmoothnessValueChanged(float smoothnessValue)
		{
		}

		private void HandleOnFlipButtonPressed()
		{
		}

		private void HandleOnDistanceValueChanged(float distanceValue)
		{
		}

		public void Initialize(CameraTrackDescriptor currentTrackDescriptor, bool isHorizontalMode)
		{
		}

		public void SetTabletLayer(int tabletLayer)
		{
		}

		public void SetCameraActive()
		{
		}

		public void SetSelfieCameraOrientation(Vector3 position, Vector3 rotation)
		{
		}

		private void ProcessFOV(float fovValue)
		{
		}

		private void ProcessSmoothness(float smoothnessValue)
		{
		}

		public void ProcessSelfieFlip()
		{
		}

		public void ProcessFirstPersonCameraPosition(Transform hmdTransform)
		{
		}

		private void ProcessThirdPersonFlip()
		{
		}

		public void ProcessThirdPersonCameraPosition(Transform hmdTransform)
		{
		}

		public void ToggleOrientation(CameraTrackDescriptor currentTrackDescriptor, bool isHorizontalMode)
		{
		}

		private void SetMonitorScale()
		{
		}

		private float CalculateCorrectFOV(float incomingVerticalFOV)
		{
			return 0f;
		}
	}
}
