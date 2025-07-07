using System;
using System.Collections.Generic;
using DP.Takeaway.Sound;
using Moon.Player.Pad;

namespace Moon.Player
{
	[Serializable]
	public class NotificationMessage
	{
		public NotificationPad.NotificationType notificationType;

		public NotificationPad.NotificationLabel notificationLabel;

		public PlayerPadAppID TargetAppId;

		public string message;

		public int priority;

		public float keepTime;

		public SoundInfo soundInfo;

		public NotificationPad.NotificationTimerType timerType;

		public List<CurrencyNotificationDetails> CurrencyDetails;

		public IPlayerPadAppOpenData AppOpenData;
	}
}
