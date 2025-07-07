namespace Moon
{
	public class GeneralMessage
	{
		public string ID { get; private set; }

		public IMessageData MessageData { get; private set; }

		public void Reset(string id, IMessageData messageData = null)
		{
		}
	}
}
