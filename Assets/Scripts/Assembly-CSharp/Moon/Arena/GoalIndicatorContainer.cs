using UnityEngine;
using UnityEngine.UI;

namespace Moon.Arena
{
	public class GoalIndicatorContainer : MonoBehaviour
	{
		[SerializeField]
		private int _targetMaxGoalCount;

		[SerializeField]
		private Graphic[] _indicators;

		public int TargetMaxGoalCount => 0;

		public void UpdateMaxGoalsScoreViewForTeam(int teamScore, int maxGoalCount, float goalIndicatorInactiveAlpha)
		{
		}

		public void DisableMaxGoalIndicators()
		{
		}
	}
}
