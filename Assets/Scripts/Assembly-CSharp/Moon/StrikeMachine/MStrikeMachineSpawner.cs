using Fusion;
using UnityEngine;

namespace Moon.StrikeMachine
{
	[NetworkBehaviourWeaved(0)]
	public class MStrikeMachineSpawner : NetworkBehaviour
	{
		[SerializeField]
		private MStrikeMachine _ball;

		private static Changed<MStrikeMachineSpawner> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MStrikeMachineSpawner> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MStrikeMachineSpawner> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
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
