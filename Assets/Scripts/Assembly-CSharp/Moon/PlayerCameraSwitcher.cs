using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Moon
{
	public class PlayerCameraSwitcher : MonoBehaviour
	{
		[Serializable]
		private struct GameCameraConfig
		{
			public GameCameraType CameraType;

			public GameCamera GameCamera;
		}

		[SerializeField]
		private GameCameraConfig[] _gameCameras;

		[SerializeField]
		private InputActionReference _enableFirstPersonCameraAction;

		[SerializeField]
		private InputActionReference _enableFreeLookCameraAction;

		[SerializeField]
		private InputActionReference _enableFreeThirdPersonCameraAction;

		[SerializeField]
		private InputActionReference _nextCameraAction;

		[SerializeField]
		private InputActionReference _previousCameraAction;

		[SerializeField]
		private FreeCamSettingsController _freeCamSettingsController;

		private int _curCameraIndex;

		public void Initialize()
		{
		}

		private void NextCameraAction_OnPerformed(InputAction.CallbackContext _)
		{
		}

		private void PreviousCameraAction_OnPerformed(InputAction.CallbackContext _)
		{
		}

		private void HandleInputAction(InputAction.CallbackContext ctx, GameCameraType targetGameCameraType)
		{
		}

		private void SwitchCamera(GameCameraType cameraType)
		{
		}
	}
}
