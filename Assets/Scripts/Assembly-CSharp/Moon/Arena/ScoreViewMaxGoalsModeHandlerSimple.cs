using DP.Takeaway.Utils;
using TMPro;
using UnityEngine;

namespace Moon.Arena
{
	public class ScoreViewMaxGoalsModeHandlerSimple : ScoreViewMaxGoalsHandlerBase
	{
		[SerializeField]
		private TMP_Text _infoText;

		[SerializeField]
		private float _goalIndicatorInactiveAlpha;

		[SerializeField]
		private GoalIndicatorContainer[] _teamOneIndicatorContainers;

		[SerializeField]
		private GoalIndicatorContainer[] _teamTwoIndicatorContainers;

		private bool _isViewActive;

		private Cooldown _cooldown;

		public override void Initialize()
		{
		}

		public override void Dispose()
		{
		}

		public override void HandleOnViewEntered(object viewData)
		{
		}

		private void UpdateMaxGoalsScoreViewForTeam(in GoalIndicatorContainer[] goalIndicatorContainers, int teamScore, int maxGoalCount)
		{
		}

		private void DisableMaxGoalIndicators(in GoalIndicatorContainer[] goalIndicatorContainers)
		{
		}

		private void LateUpdate()
		{
		}

		public override void HandleOnViewExited()
		{
		}
	}
}
