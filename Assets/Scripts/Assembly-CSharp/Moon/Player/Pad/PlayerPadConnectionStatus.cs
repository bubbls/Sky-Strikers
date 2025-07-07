using System;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadConnectionStatus : MonoBehaviour
	{
		[Serializable]
		private class ConnectionStatusVisual
		{
			public ConnectionManager.Status Status;

			public GameObject Icon;
		}

		[SerializeField]
		private ConnectionStatusVisual[] _connectionStatusVisuals;

		[SerializeField]
		private TMP_Text _statusText;

		private IMessageSubscriber _messageSubscriber;

		private float _messageEndTime;

		private float _messageStartTime;

		private string _latestMatchmakingMessage;

		private NotificationMessage _notificationMessage;

		private bool _hasUpdatableMessage;

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private int HandleNotificationMessage(IMessage<NotificationMessage> message)
		{
			return 0;
		}

		private void ConnectionManager_OnConnectionStatusChanged(ConnectionManager.Status status, ShutdownReason shutdownReason)
		{
		}

		private void ApplyStatusVisuals(ConnectionManager.Status status)
		{
		}

		private void ToggleStatusIcon(ConnectionManager.Status status)
		{
		}

		private void SetTextToCurrentConnectionStatus()
		{
		}
	}
}
