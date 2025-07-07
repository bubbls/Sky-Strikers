using Chamber8.Framework.Messaging;

namespace Moon.Arena
{
	public class CrowdMatchActionEventsResponseChecker : CrowdResponseChecker
	{
		private IMessageSubscriber[] _messageSubscribers;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		private int HandleOnMatchActionEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerActionEvent(IMessage<PlayerActionMessage> message)
		{
			return 0;
		}
	}
}
