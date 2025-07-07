using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Game;
using Moon.Arena;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialClassPath : MonoBehaviour
	{
		[SerializeField]
		private TutorialFSMManager _tutorialFsmManager;

		[SerializeField]
		private TutorialClassSelectionGate _tutorialClassSelectionGate;

		[SerializeField]
		private TutorialPassGate _shootGoalPassGate;

		[SerializeField]
		private Trigger _completeTrigger;

		[SerializeField]
		private Transform _teleportPoint;

		public event Action OnCompleted
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

		private void TutorialFsmManager_HandleOnTutorialGoaled(ArenaGoal _)
		{
		}

		private void HandleOnCompleted(Collider other)
		{
		}

		private void Reset()
		{
		}

		protected virtual void HandleOnReset()
		{
		}
	}
}
