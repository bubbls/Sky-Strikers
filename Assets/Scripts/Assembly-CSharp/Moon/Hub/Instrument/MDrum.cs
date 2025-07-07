using Fusion;

namespace Moon.Hub.Instrument
{
	[NetworkBehaviourWeaved(0)]
	public class MDrum : MInstrument
	{
		private static readonly HapticImpulse HapticImpulse;

		private static Changed<MDrum> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MDrum> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MDrum> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void TrackingAnalytics()
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
