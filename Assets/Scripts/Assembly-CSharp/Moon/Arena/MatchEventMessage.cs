namespace Moon.Arena
{
	public class MatchEventMessage
	{
		public string ID { get; private set; }

		public IMessageData MessageData { get; private set; }

		public MatchEventMessage(string id, IMessageData messageData = null)
		{
		}

		public void Reset(string id, IMessageData messageData)
		{
		}
	}
}
