using Fusion;
using Moon.MultiPlay;

namespace Moon.Arena
{
	public class GoalMessageData : IMessageData
	{
		private const double MinTimeForAssist = 8.0;

		public MBall Ball { get; }

		public ArenaGoal GoalObject { get; }

		public BallHitData ScoringBallHitData { get; }

		public BallHitData PreviousBallHitData { get; }

		public TeamNo ScoringTeam { get; }

		public bool IsOwnGoal { get; }

		public int MatchScoreTime { get; }

		public double ServerScoreTime { get; }

		public float BallSpeed { get; }

		public float ShooterDistance { get; }

		public bool AllowGlobalEffects { get; }

		public PlayerRef ScoringPlayer { get; }

		public PlayerRef AssistingPlayer { get; }

		public GoalMessageData(MBall ball, ArenaGoal goalObject, BallHitData scoringBallHitData, BallHitData previousBallHitData, TeamNo scoringTeam)
		{
		}

		public GoalMessageData(MBall ball, ArenaGoal goalObject, bool allowGlobalEffects, BallHitData scoringBallHitData, BallHitData previousBallHitData, int matchScoreTime, double serverScoreTime, float ballSpeed)
		{
		}
	}
}
