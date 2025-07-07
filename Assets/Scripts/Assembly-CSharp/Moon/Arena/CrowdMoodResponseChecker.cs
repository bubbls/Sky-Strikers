using Chamber8.Framework.Messaging;
using UnityEngine;

namespace Moon.Arena
{
	public class CrowdMoodResponseChecker : CrowdResponseChecker
	{
		[SerializeField]
		private Vector2 _cheerTriggerTime;

		[SerializeField]
		private Vector2 _malcontentTriggerTime;

		[SerializeField]
		private float _minTimeBetweenCheerAndMalcontent;

		private float _curTime;

		private bool _canCheckCrowdMood;

		private float _nextCheerSfxTriggerTime;

		private float _nextMalcontentSfxTriggerTime;

		private IMessageSubscriber[] _messageSubscribers;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		private void LateUpdate()
		{
		}

		private void RestartMoodChecks()
		{
		}

		private void StopMoodCheck()
		{
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerActionEvent(IMessage<PlayerActionMessage> message)
		{
			return 0;
		}

		private int HandleOnMatchActionEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private void TryRestartCheerDelay()
		{
		}

		private int HandleCrowdResponseTriggered(IMessage<object> message)
		{
			return 0;
		}
	}
}
