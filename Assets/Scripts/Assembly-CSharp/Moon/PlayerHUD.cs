using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using Moon.Profiler;
using TMPro;
using UnityEngine;

namespace Moon
{
	public class PlayerHUD : MonoBehaviour
	{
		[SerializeField]
		private Camera _hudCamera;

		[SerializeField]
		private TMP_Text _textCornerStatus;

		[SerializeField]
		private TMP_Text _textDebugInfo;

		private WaitingMessage _statusMessage;

		private HashSet<IMessageSubscriber> _subscribers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleMatchmakingStatusUpdate(IMessage<object> message)
		{
			return 0;
		}

		private int HandleEnableProfilerLogMessage(IMessage<ProfilerLogMessage> message)
		{
			return 0;
		}

		private void UpdateMatchmakingStatus()
		{
		}

		private void Update()
		{
		}
	}
}
