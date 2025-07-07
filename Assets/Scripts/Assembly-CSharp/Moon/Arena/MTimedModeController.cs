using DP.Takeaway.Utils;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Arena
{
	[NetworkBehaviourWeaved(3)]
	public class MTimedModeController : MMatchModeController
	{
		private const int TimedModeFinalPhaseTime = 10;

		[DefaultForProperty("OvertimeElapsedTime", 1, 1)]
		private float _OvertimeElapsedTime;

		[DefaultForProperty("InOvertime", 2, 1)]
		private NetworkBool _InOvertime;

		[SerializeField]
		private MTeamScoreTracker _scoreTracker;

		private int _inTimedModeFinalPhaseTime;

		private readonly MatchRemainingTimeUpdatedMessageData _matchRemainingTimeUpdatedMessageData;

		private readonly Cooldown _cooldown;

		private int _remainingTime;

		private static Changed<MTimedModeController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MTimedModeController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MTimedModeController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(1, 1)]
		private float OvertimeElapsedTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Networked(OnChanged = "OnInOvertimeChanged")]
		[NetworkedWeaved(2, 1)]
		private NetworkBool InOvertime
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		public override void SyncToSharedData()
		{
		}

		public override void ExecutePrepareState(MFSM.Phase phase)
		{
		}

		public override void ExecuteMatchState(MFSM.Phase phase)
		{
		}

		protected override void RaiseOnTimeChanged()
		{
		}

		public override void ExecuteMatchEndState(MFSM.Phase phase)
		{
		}

		[Preserve]
		private static void OnInOvertimeChanged(Changed<MTimedModeController> changed)
		{
		}

		public override bool IsMatchEnd()
		{
			return false;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
