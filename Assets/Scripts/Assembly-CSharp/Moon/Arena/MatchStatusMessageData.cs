namespace Moon.Arena
{
	public class MatchStatusMessageData : IMessageData
	{
		public bool IsMatchInProgress { get; }

		public MatchStatusMessageData(bool isMatchInProgress)
		{
		}
	}
}
