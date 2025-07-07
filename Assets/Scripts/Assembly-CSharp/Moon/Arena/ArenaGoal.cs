using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaGoal : MonoBehaviour
	{
		private enum ArenaGoalState
		{
			WaitForGoal = 0,
			Goal = 1,
			OtherGetGoal = 2
		}

		[SerializeField]
		private Transform _fxOffset;

		[SerializeField]
		private ArenaGoalTrigger _trigger;

		[SerializeField]
		private Transform _heatSeekerTarget;

		[SerializeField]
		private bool _useFxOffsetPosForGoalEffect;

		[SerializeField]
		private TeamNo _teamNo;

		private ArenaGoalState _arenaGoalState;

		public Transform HeatSeekerTarget => null;

		public Transform FXOffset => null;

		public bool UseFxOffsetPosForGoalEffect => false;

		public TeamNo TeamNo => default(TeamNo);

		public event Action<ArenaGoal, MBall> OnGoal
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

		private void OnDisable()
		{
		}

		private void WaitForGoal(Collider colliderEntered)
		{
		}

		public void ResetGoal()
		{
		}
	}
}
