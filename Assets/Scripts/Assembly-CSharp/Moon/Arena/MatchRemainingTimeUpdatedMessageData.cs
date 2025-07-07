namespace Moon.Arena
{
	public class MatchRemainingTimeUpdatedMessageData : IMessageData
	{
		public float RemainingTime { get; private set; }

		public int RemainingTimeInt { get; private set; }

		public MatchRemainingTimeUpdatedMessageData()
		{
		}

		public MatchRemainingTimeUpdatedMessageData(float remainingTime)
		{
		}

		public void Reset(float remainingTime)
		{
		}
	}
}
