using UnityEngine;

namespace Moon.Hub.Instrument
{
	public class InstrumentInteractionHarpItem : InstrumentInteractionItem
	{
		protected override bool CanInteract(Collider other)
		{
			return false;
		}

		public void UpdatePitchValue(float pitchValue)
		{
		}
	}
}
