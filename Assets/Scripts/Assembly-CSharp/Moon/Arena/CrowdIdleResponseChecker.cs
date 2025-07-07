using Chamber8.Framework.Messaging;

namespace Moon.Arena
{
	public class CrowdIdleResponseChecker : CrowdResponseChecker
	{
		private IMessageSubscriber _messageSubscriber;

		private bool _matchStartedAlready;

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
