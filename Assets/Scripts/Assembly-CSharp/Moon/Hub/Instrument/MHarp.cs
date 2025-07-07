using Fusion;

namespace Moon.Hub.Instrument
{
	[NetworkBehaviourWeaved(0)]
	public class MHarp : MInstrument
	{
		private static readonly HapticImpulse HapticImpulse;

		private bool _hasInteractedWithHandle;

		private static Changed<MHarp> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHarp> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHarp> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
		{
		}

		public void SetHasInteractedHandle(bool hasInteractedHandle)
		{
		}

		protected override bool CustomInteractionInteracted()
		{
			return false;
		}

		protected override void TrackingAnalytics()
		{
		}

		public void UpdatePitchValue(float pitchValue)
		{
		}

		protected override HapticImpulse GetHapticImpulse()
		{
			return null;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
