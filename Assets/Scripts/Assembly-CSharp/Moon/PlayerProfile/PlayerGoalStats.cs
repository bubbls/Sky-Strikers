using System;
using Fusion;
using Moon.Arena;

namespace Moon.PlayerProfile
{
	public class PlayerGoalStats
	{
		public Guid GoalId;

		public PlayerRef Scorer;

		public TeamNo ScoringTeam;

		public int Goals;

		public int OwnGoals;

		public int Assists;

		public int Saves;

		public int Clears;

		public int RocketsFired;

		public int BallHits;

		public float BallSpeed;

		public float ShooterDistance;

		public int Shots;

		public int TargetShots;

		public float DistanceTraveled;

		public int Possession;

		public int EnergyCollectCount;

		public int EnergyCollectFromOpponent;

		public int EnergyConsumedCount;

		public int SmallEnergyCollectedCount;

		public int MiddleEnergyCollectedCount;

		public int BigEnergyCollectedCount;
	}
}
