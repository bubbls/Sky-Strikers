using Fusion;
using Moon.Arena;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(1)]
	public class MHubArenaGoalManager : NetworkBehaviour
	{
		[DefaultForProperty("CurrentGoalType", 0, 1)]
		[SerializeField]
		private GoalType _CurrentGoalType;

		[SerializeField]
		private ArenaGoal[] _normalGoals;

		[SerializeField]
		private ArenaGoal[] _ringGoals;

		[SerializeField]
		private ArenaGoal[] _hollowHoops;

		[SerializeField]
		private ArenaGoal[] _volleyballGoals;

		[SerializeField]
		private GameObject _normalGoalsBlockers;

		[SerializeField]
		private GameObject _normalFloor;

		[SerializeField]
		private GameObject _hollowHoopFloor;

		private static Changed<MHubArenaGoalManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaGoalManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaGoalManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 1)]
		[Networked]
		public GoalType CurrentGoalType
		{
			get
			{
				return default(GoalType);
			}
			set
			{
			}
		}

		public override void Spawned()
		{
		}

		public ArenaGoal[] GetArenaGoals()
		{
			return null;
		}

		public void SetGoalType(GoalType goalType)
		{
		}

		private void ToggleGoalsForGoalType(GoalType goalType)
		{
		}

		private void ToggleGoals(ArenaGoal[] goals, bool enable)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_NotifyGoalTypeChanged(GoalType goalType)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyGoalTypeChanged_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
