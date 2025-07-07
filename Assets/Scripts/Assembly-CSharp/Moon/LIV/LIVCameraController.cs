using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DP.Takeaway.Sound;
using Liv.Lck;
using Liv.Lck.Recorder;
using Moon.Player;
using TMPro;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVCameraController : MonoBehaviour
	{
		[Header("Options")]
		[SerializeField]
		private bool _modifyRenderLayerAndCullingMasks;

		[SerializeField]
		private string _tabletRenderingLayer;

		[SerializeField]
		private List<GameObject> _gameObjectsToHideFromSelfieCamera;

		[SerializeField]
		private CameraTrackDescriptor _sdTrackDescriptor;

		[SerializeField]
		private CameraTrackDescriptor _hdTrackDescriptor;

		[SerializeField]
		private Transform _hmdTransform;

		[SerializeField]
		[Header("Camera Modes")]
		private LIVCameraModeController _livCameraModeController;

		[Header("Selfie Camera")]
		[SerializeField]
		private LIVCamera _selfieCamera;

		[Header("First Person Camera")]
		[SerializeField]
		private LIVCamera _firstPersonCamera;

		[SerializeField]
		[Header("Third Person Camera")]
		private LIVCamera _thirdPersonCamera;

		[SerializeField]
		[Header("Camera Operations")]
		private LIVIconButton _toggleOrientationButton;

		[SerializeField]
		private LIVIconButton _toggleMicrophoneButton;

		[SerializeField]
		private LIVMicrophoneVolume _livMicrophoneVolume;

		[SerializeField]
		private LIVIconButton _toggleSDHDButton;

		[SerializeField]
		private TMP_Text _resolutionText;

		[SerializeField]
		private LIVRecordButton _recordButton;

		[SerializeField]
		private GameObject _lckMonitor;

		[Header("Output")]
		[SerializeField]
		private LIVOutputPanel _outputPanel;

		[Header("Notification")]
		[SerializeField]
		private NotificationMessage _notificationMessage;

		[Header("Recoding Audio")]
		[SerializeField]
		private float _gameAudioGain;

		[SerializeField]
		private float _microphoneGain;

		[Header("Sounds")]
		[SerializeField]
		private SoundInfo _recordingStartSoundInfo;

		[SerializeField]
		private SoundInfo _recordingStopSoundInfo;

		private const string SDDisplayText = "720p 30Hz";

		private const string HDDisplayText = "1080p 60Hz";

		private LckService _lckService;

		private CameraTrackDescriptor _currentTrackDescriptor;

		private CameraResolutionDescriptor _verticalModeResolutionDescriptor;

		private LckResult<TimeSpan> _recordingTimespanResult;

		private LIVCameraMode _currentCameraMode;

		private bool _isHorizontalMode;

		private bool _isMicrophoneActive;

		private bool _isSDMode;

		private int _hours;

		private int _minutes;

		private int _seconds;

		private bool _isRecording;

		private double _recordingTotalSeconds;

		private bool _isStoppedManually;

		public bool IsActivated { get; private set; }

		public TimeSpan RecordingTimeSpan { get; private set; }

		public bool IsRecording
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action<bool> OnRecordingStateChanged
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

		public void Initialize()
		{
		}

		public void ToggleActivateCamera(bool isActivated)
		{
		}

		private void ToggleDefaultSelfieCameraMode(bool enable)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnCameraButtonPressed()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandleOnToggleSDHDButtonPressed()
		{
		}

		private void HandleOnCameraModeChanged(LIVCameraMode cameraMode)
		{
		}

		private void Update()
		{
		}

		private void SetTabletLayer()
		{
		}

		private void SetActiveLckCamera(LIVCamera livCamera)
		{
		}

		private void OnRecordingStoppedExternally(LckResult result)
		{
		}

		private void OnRecordingSaved(LckResult<RecordingData> result)
		{
		}

		public void TryStopRecording()
		{
		}

		private void HandleOnRecordButtonPressed()
		{
		}

		private void HandleOnToggleMicrophoneButtonPressed()
		{
		}

		private void HandleOnToggleOrientationButtonPressed()
		{
		}
	}
}
