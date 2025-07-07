using Fusion;
using UnityEngine;

namespace Moon.Interaction
{
	[NetworkBehaviourWeaved(1)]
	public class MAttachableGrabbable : MGrabbable
	{
		[SerializeField]
		private NetworkRigidbody _networkRigidbody;

		private static Changed<MAttachableGrabbable> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MAttachableGrabbable> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MAttachableGrabbable> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleOnGrabbedInternal()
		{
		}

		protected override void HandleOnReleaseInternal()
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
