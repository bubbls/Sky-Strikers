using Fusion;
using UnityEngine;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(2)]
	public class MHubArenaPlatformGroup : MHubArenaFieldObject
	{
		[SerializeField]
		private GameObject[] _platforms;

		private Collider[] _colliders;

		private bool _isInitialized;

		private static Changed<MHubArenaPlatformGroup> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaPlatformGroup> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaPlatformGroup> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void TryInitialize()
		{
		}

		protected override void AnimateIn(float duration)
		{
		}

		protected override void AnimateOut(float duration)
		{
		}

		private void TogglePlatforms(bool enable)
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
