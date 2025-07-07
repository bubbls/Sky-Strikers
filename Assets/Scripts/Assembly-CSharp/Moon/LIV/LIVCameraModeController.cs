using System;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVCameraModeController : MonoBehaviour
	{
		public Action<LIVCameraMode> OnCameraModeChanged;

		[Header("Selfie Mode")]
		[SerializeField]
		private LIVCameraModeToggle _selfieToggle;

		[SerializeField]
		private GameObject _selfieSettings;

		[SerializeField]
		[Header("First Person Mode")]
		private LIVCameraModeToggle _firstPersonToggle;

		[SerializeField]
		private GameObject _firstPersonSettings;

		[SerializeField]
		[Header("Third Person Mode")]
		private LIVCameraModeToggle _thirdPersonToggle;

		[SerializeField]
		private GameObject _thirdPersonSettings;

		public void SetSelfieCameraModeActive()
		{
		}

		public void DisableAllCameraModes()
		{
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

		private void HandleOnToggled(LIVCameraMode cameraMode)
		{
		}
	}
}
