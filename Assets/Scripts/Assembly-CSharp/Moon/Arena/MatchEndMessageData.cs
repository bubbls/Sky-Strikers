namespace Moon.Arena
{
	public class MatchEndMessageData : IMessageData
	{
		public TeamNo WinningTeam { get; }

		public bool IsForfeit { get; }

		public MatchEndMessageData(TeamNo winningTeam, bool isForfeit = false)
		{
		}
	}
}
