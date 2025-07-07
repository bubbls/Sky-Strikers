namespace Moon
{
	public class PlayerLocomotionMessage
	{
		public PlayerLocomotionActionType LocomotionAction { get; private set; }

		public IMessageData MessageData { get; private set; }

		public void Reset(PlayerLocomotionActionType locomotionAction, IMessageData messageData = null)
		{
		}
	}
}
