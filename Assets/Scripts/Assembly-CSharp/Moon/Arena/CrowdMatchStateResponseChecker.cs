using Chamber8.Framework.Messaging;

namespace Moon.Arena
{
	public class CrowdMatchStateResponseChecker : CrowdResponseChecker
	{
		private IMessageSubscriber _messageSubscriber;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}
	}
}
