using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPad : SingleMonoBehaviour<PlayerPad, DefaultSingleMonoBehaviourSettings<PlayerPad>>
	{
		public const string PlayerPadInteractableTag = "PlayerPadInteractable";

		[SerializeField]
		private GameObject _padObj;

		[SerializeField]
		private float _appOpenDuration;

		[SerializeField]
		private float _appCloseDuration;

		[SerializeField]
		private PlayerPadHomeScreen _homeScreen;

		[SerializeField]
		private PlayerPadTopBar _topBar;

		[SerializeField]
		private PlayerPadAppAndIconPairData[] _fixedAppAndIconPairs;

		[SerializeField]
		private NotificationPad _notificationPad;

		[SerializeField]
		private Transform _onPadNotificationsPoint;

		[SerializeField]
		private Transform _offPadNotificationsPivot;

		[SerializeField]
		private Transform _offPadNotificationsPoint;

		[SerializeField]
		private PlayerPadInputController _padInputController;

		private PlayerPadApp _currentApp;

		private Transform _followTarget;

		private Transform _notificationPadFollowTarget;

		private Transform _notificationPadLookAtTarget;

		private bool _isInitialized;

		private bool _isShowingPad;

		public bool IsShowingPad => false;

		public Vector3 PadPosition => default(Vector3);

		public void TryInitializePad(Transform followTarget, Transform notificationPadFollowTarget, Transform notificationPadLookAtTarget)
		{
		}

		private void OnDestroy()
		{
		}

		private NotificationPad.ShowRequestResult HandleRequestShowNotificationDelegate(NotificationMessage message)
		{
			return default(NotificationPad.ShowRequestResult);
		}

		private void LateUpdate()
		{
		}

		private void SyncToFollowTarget()
		{
		}

		private void HandleIconPressed(PlayerPadAppIcon icon)
		{
		}

		private void OpenAppFromIcon(PlayerPadAppIcon icon, IPlayerPadAppOpenData appOpenData)
		{
		}

		private void PadInputController_OnHomeButtonPressed()
		{
		}

		private void CloseCurrentApp()
		{
		}

		private void TogglePad(bool enable)
		{
		}

		public void HandleMenuButtonPressed()
		{
		}
	}
}
