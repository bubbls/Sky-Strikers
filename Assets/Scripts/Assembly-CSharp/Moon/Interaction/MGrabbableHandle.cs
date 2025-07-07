using Fusion;
using UnityEngine;

namespace Moon.Interaction
{
	[NetworkBehaviourWeaved(20)]
	public class MGrabbableHandle : NetworkTransform
	{
		private static Changed<MGrabbableHandle> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MGrabbableHandle> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MGrabbableHandle> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public Vector3 Position => default(Vector3);

		public void SetPosition(Vector3 position)
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
