using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using Moon.Economy;
using TMPro;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class NotificationPad : MonoBehaviour
	{
		public enum NotificationType
		{
			None = 0,
			Connection = 1,
			GameMaster = 2,
			Currency = 3
		}

		public enum NotificationLabel
		{
			Temporary = 0,
			Permanent = 1,
			OnlyVoice = 2
		}

		public enum NotificationTimerType
		{
			None = 0,
			Countdown = 1,
			CountUp = 2
		}

		public enum ShowRequestResult
		{
			Show = 0,
			SfxOnly = 1,
			Ignore = 2
		}

		public delegate ShowRequestResult CanShowNotification(NotificationMessage message);

		private enum State
		{
			Hide = 0,
			Show = 1
		}

		[SerializeField]
		private float _messageKeepTime;

		[SerializeField]
		private GameObject _visualRoot;

		[SerializeField]
		private TMP_Text _infoText;

		[SerializeField]
		private Image _notificationTimerFillImage;

		[SerializeField]
		private Color _notificationTimerFillImageColorInteractable;

		[SerializeField]
		private Color _notificationTimerFillImageColorNormal;

		[SerializeField]
		private GameObject _notificationTimerInstructions;

		[SerializeField]
		private NotificationPadCurrencyDisplay _currencyDisplay;

		[SerializeField]
		private float _transferTime;

		[SerializeField]
		private NotificationMessage _defaultCurrencyMessage;

		public CanShowNotification RequestShowNotificationDelegate;

		private PlayerEconomy _playerEconomy;

		private readonly ObjectPool<NotificationItem> _objectPool;

		private IMessageSubscriber[] _subscribers;

		private int _soundId;

		private List<NotificationItem> _itemQueue;

		private bool _itemChanged;

		private State _currentState;

		private NotificationMessage _cachedMessage;

		private bool _canProcessMessages;

		private Dictionary<PlayerEconomyConstants.CurrencyType, int> _currencyDict;

		private bool _isShowingTimedNotification;

		public NotificationItem CurrentItem { get; private set; }

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private void StagingLoadingController_OnLoadingComplete()
		{
		}

		private void GameOption_OnOptionsSaved(GameOption.Options options)
		{
		}

		public void TryHideNotificationPad()
		{
		}

		private void SetInitialBalance()
		{
		}

		private int HandleNotificationMessage(IMessage<NotificationMessage> message)
		{
			return 0;
		}

		private void ProcessMessage(NotificationMessage message)
		{
		}

		private int HandlePlayerInitialInventoryFetched(IMessage<object> arg)
		{
			return 0;
		}

		private int HandlePlayerBalanceChanged(IMessage<object> arg)
		{
			return 0;
		}

		private void LateUpdate()
		{
		}

		private void RefreshDisplay()
		{
		}

		private void AddItem(NotificationItem item)
		{
		}

		private void ReleaseItem(NotificationItem item)
		{
		}

		private void ClearItem(NotificationMessage message)
		{
		}

		private NotificationItem PopItem()
		{
			return null;
		}

		private void ChangeState(State targetState)
		{
		}
	}
}
