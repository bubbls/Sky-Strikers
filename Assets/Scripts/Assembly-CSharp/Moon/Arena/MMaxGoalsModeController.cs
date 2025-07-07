using DP.Takeaway.Utils;
using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(1)]
	public class MMaxGoalsModeController : MMatchModeController
	{
		private readonly Cooldown _cooldown;

		[SerializeField]
		private MTeamScoreTracker _scoreTracker;

		private static Changed<MMaxGoalsModeController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MMaxGoalsModeController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MMaxGoalsModeController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void ExecutePrepareState(MFSM.Phase phase)
		{
		}

		public override void ExecuteMatchState(MFSM.Phase phase)
		{
		}

		public override bool IsMatchEnd()
		{
			return false;
		}

		public override void ExecuteMatchEndState(MFSM.Phase phase)
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
