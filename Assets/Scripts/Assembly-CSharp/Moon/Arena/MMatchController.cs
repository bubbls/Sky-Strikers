using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(2)]
	public abstract class MMatchController : NetworkBehaviour
	{
		[SerializeField]
		private MMatchModeController[] _modeControllers;

		[SerializeField]
		[DefaultForProperty("CurrentMatchModeController", 0, 2)]
		private MMatchModeController _CurrentMatchModeController;

		private static Changed<MMatchController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MMatchController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MMatchController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 2)]
		public MMatchModeController CurrentMatchModeController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action OnGoalScored
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

		public abstract void ResetForMatch(GameSettings gameSettings);

		public abstract void Initialize();

		protected abstract bool IsMatchControllerActive();

		public bool IsMatchEnd()
		{
			return false;
		}

		public virtual void SyncToSharedData()
		{
		}

		protected void SetCurrentMatchModeController<T>() where T : MMatchModeController
		{
		}

		protected void ClearMatchModeController()
		{
		}

		public abstract void StopMatchController();

		public virtual void HandlePrepareState(MFSM.Phase phase, float prepareStateRemainingTime)
		{
		}

		public abstract void HandleNextRoundCountdown(MFSM.Phase phase, float remainingTime);

		public abstract void HandleMatchState(MFSM.Phase phase);

		public abstract void HandleMatchEndState(MFSM.Phase phase);

		protected void RaiseOnGoalScored()
		{
		}

		public abstract GoalMessageData GetLastGoalInfo();

		public abstract TeamNo GetWinnerInfo();

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
