using System.Collections.Generic;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Arena;
using Moon.Framework.Leaderboard;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon
{
	public class PlayerDistanceStatsHandler : PlayerStatsHandler
	{
		private class PlayerDistanceStat
		{
			public int DistBallPossession;

			public int DistBallNoPossession;

			public int DistNearestTeammate;

			public int DistRecordCnt;

			public int TotalMostBack;

			public int TotalMostForward;

			public int TimeClosetBall;

			public int TimeFarthestBall;

			public int TimeBehindBall;

			public int TimeFrontBall;
		}

		private PlayerDistanceStat _distanceStat;

		private bool _inPossession;

		private readonly Cooldown _cooldown;

		private Vector3 _goalDirection;

		private Vector3 _ownGoalPos;

		private Vector3 _optGoalPos;

		private bool _canTrackStats;

		public PlayerDistanceStatsHandler(PlayerRef playerRef, string playFabId, PlayerInfo playerInfo)
			: base(default(PlayerRef), null, default(PlayerInfo))
		{
		}

		public override void StartTracking()
		{
		}

		public override void StopTracking()
		{
		}

		public override void HandleFixedNetworkUpdate()
		{
		}

		public override void HandlePlayerPossessionChanged(TeamNo teamNo)
		{
		}

		private void InitGoalDirection()
		{
		}

		public override void OnMatchPrepare()
		{
		}

		public override void OnMatchStarted()
		{
		}

		public List<Statistic> OperateStatsListOnMatchCompleted()
		{
			return null;
		}

		public void NotifyStatsUpdatedOnMatchCompleted()
		{
		}
	}
}
