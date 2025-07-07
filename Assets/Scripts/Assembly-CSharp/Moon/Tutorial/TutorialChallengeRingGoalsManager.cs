using System.Collections.Generic;
using Moon.Arena;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialChallengeRingGoalsManager : TutorialChallenge
	{
		[SerializeField]
		[Header("Challenge Custom Config")]
		private List<TutorialFSMManager> _tutorialFSMManagers;

		[SerializeField]
		private List<ArenaGoal> _arenaGoals;

		[SerializeField]
		private List<GameObject> _goalCovers;

		private int _currentGoalCount;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void StartChallenge()
		{
		}

		public override void SucceedChallenge()
		{
		}

		private void TutorialFSMManager_HandleOnTutorialGoaled(ArenaGoal arenaGoal)
		{
		}
	}
}
