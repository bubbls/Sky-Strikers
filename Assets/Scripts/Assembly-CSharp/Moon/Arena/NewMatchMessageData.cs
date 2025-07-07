namespace Moon.Arena
{
	public class NewMatchMessageData : IMessageData
	{
		public GameSettings GameSettings { get; }

		public NewMatchMessageData(GameSettings gameSettings)
		{
		}
	}
}
