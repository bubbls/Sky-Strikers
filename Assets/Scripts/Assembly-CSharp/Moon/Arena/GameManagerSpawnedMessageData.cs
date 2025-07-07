namespace Moon.Arena
{
	public struct GameManagerSpawnedMessageData : IMessageData
	{
		public bool IsMatchInProgress { get; private set; }

		public GameManagerSpawnedMessageData(bool isMatchInProgress)
		{
			IsMatchInProgress = false;
		}
	}
}
