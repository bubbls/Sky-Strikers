using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaGoalListener : MonoBehaviour
	{
		[SerializeField]
		private ArenaGoal[] _goals;

		public event Action<MBall, int, TeamNo> OnGoalScored
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void ArenaGoal_OnGoal(ArenaGoal goal, MBall ball)
		{
		}

		private void OnDisable()
		{
		}

		public ArenaGoal GetGoalAtIndex(int index)
		{
			return null;
		}

		public void ResetGoals()
		{
		}
	}
}
