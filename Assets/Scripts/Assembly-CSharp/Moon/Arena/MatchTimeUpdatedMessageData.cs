namespace Moon.Arena
{
	public class MatchTimeUpdatedMessageData : IMessageData
	{
		public float ElapsedTime;

		public float OvertimeElapsedTime;

		public GameSettings GameSettings;

		public MatchTimeUpdatedMessageData()
		{
		}

		public MatchTimeUpdatedMessageData(float elapsedTime, float overtimeElapsedTime, GameSettings gameSettings)
		{
		}

		public void Reset(float elapsedTime, float overtimeElapsedTime, GameSettings gameSettings)
		{
		}
	}
}
