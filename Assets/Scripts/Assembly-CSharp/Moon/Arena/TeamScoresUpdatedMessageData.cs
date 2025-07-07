namespace Moon.Arena
{
	public struct TeamScoresUpdatedMessageData : IMessageData
	{
		public TeamScore TeamOneScore { get; private set; }

		public TeamScore TeamTwoScore { get; private set; }

		public TeamScoresUpdatedMessageData(TeamScore teamOneScore, TeamScore teamTwoScore)
		{
			TeamOneScore = default(TeamScore);
			TeamTwoScore = default(TeamScore);
		}

		public void Reset(TeamScore teamOneScore, TeamScore teamTwoScore)
		{
		}
	}
}
