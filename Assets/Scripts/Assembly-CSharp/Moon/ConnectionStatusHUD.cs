using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class ConnectionStatusHUD : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private TMP_Text _textConnStatus;

		[SerializeField]
		private TMP_Text _versionInfoText;

		[SerializeField]
		private TMP_Text _textConnProgress;

		[SerializeField]
		private GameObject _observerCamera;

		[SerializeField]
		private TMP_FontAsset defaultFont;

		private static bool _isConnected;

		private static string _text;

		private WaitingMessage _waitingMessage;

		private readonly List<IMessageSubscriber> _subscribers;

		private void Start()
		{
		}

		public void ListenMessage()
		{
		}

		private int HandleConnProgressReported(IMessage<ConnProgressMessage> message)
		{
			return 0;
		}

		private void OnDestroy()
		{
		}

		private int HandleReportErrorMessage(IMessage<ReportErrorMessage> message)
		{
			return 0;
		}

		private int HandleConnChangedMessage(IMessage<ConnChangedMessage> message)
		{
			return 0;
		}

		private void LateUpdate()
		{
		}

		private static string GetPhotonConnStatusDisplayText(ConnectionManager.Status status)
		{
			return null;
		}

		private static string GetConnectedText()
		{
			return null;
		}

		private static string GetRandomText(IEnumerable<string> texts)
		{
			return null;
		}

		private static string GetPhotonConnProgressDisplayText(ConnectionManager.Progress progress)
		{
			return null;
		}

		private static string GetClientStatusDisplayText(ClientSharedData.Status status)
		{
			return null;
		}
	}
}
