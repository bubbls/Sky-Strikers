using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(7)]
	public class MSkyballMatchController : MTeamBasedBallMatchControllerBase
	{
		[SerializeField]
		private Transform _ballSpawnerPoint;

		[DefaultForProperty("LastGoalBallSpeed", 6, 1)]
		private float _LastGoalBallSpeed;

		private static Changed<MSkyballMatchController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MSkyballMatchController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MSkyballMatchController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(6, 1)]
		[Networked]
		private float LastGoalBallSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override bool IsMatchControllerActive()
		{
			return false;
		}

		protected override void HandleOnGoalScoredInternal(MBall ball, int goalIndex, TeamNo scoringTeam)
		{
		}

		public override GoalMessageData GetLastGoalInfo()
		{
			return null;
		}

		protected override void SpawnBall(float ballSpawnDelay)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
