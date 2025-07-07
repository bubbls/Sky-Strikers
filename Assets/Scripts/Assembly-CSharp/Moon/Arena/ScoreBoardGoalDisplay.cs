using UnityEngine;

namespace Moon.Arena
{
	public class ScoreBoardGoalDisplay : MonoBehaviour
	{
		[SerializeField]
		private ScoreBoardGoalDisplayElement[] _elementsOne;

		[SerializeField]
		private ScoreBoardGoalDisplayElement[] _elementsTwo;

		public void SetGoal(int teamOneGoal, int teamTwoGoal, int maxCount)
		{
		}

		private void SetGoal(ScoreBoardGoalDisplayElement[] elements, int count, int maxCount)
		{
		}
	}
}
