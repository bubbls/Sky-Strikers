namespace Moon
{
	public class PlayerActionMessage
	{
		public PlayerActionType PlayerAction { get; private set; }

		public IMessageData MessageData { get; private set; }

		public void Reset(PlayerActionType playerAction, IMessageData messageData)
		{
		}
	}
}
