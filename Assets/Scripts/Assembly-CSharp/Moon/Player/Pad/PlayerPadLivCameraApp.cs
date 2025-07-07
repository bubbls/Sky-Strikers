using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadLivCameraApp : PlayerPadApp
	{
		[SerializeField]
		private UIButton _placeCameraButton;

		[SerializeField]
		private float _placedOffsetFromPlayer;

		[SerializeField]
		private TMP_Text _recordingStatusText;

		[SerializeField]
		private TMP_Text _recordingDurationText;

		[SerializeField]
		private Color _recordingDurationColor;

		private bool _isRecording;

		public override PlayerPadAppID AppID => default(PlayerPadAppID);

		protected override void InitializeInternal()
		{
		}

		public override void Dispose()
		{
		}

		private void LIVController_OnLivControllerInitialized()
		{
		}

		private void SetupApp()
		{
		}

		private void LateUpdate()
		{
		}

		private void HandleRecordingStateChanged(bool recordingState)
		{
		}

		protected override void HandleAppAboutToOpenInternal(IPlayerPadAppOpenData appOpenData)
		{
		}

		protected override void HandleAppAboutToCloseInternal()
		{
		}

		private void PlaceCameraButton_OnButtonPressed()
		{
		}
	}
}
