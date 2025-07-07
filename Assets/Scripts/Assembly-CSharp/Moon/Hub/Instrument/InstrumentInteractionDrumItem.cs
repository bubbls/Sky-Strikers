using UnityEngine;

namespace Moon.Hub.Instrument
{
	public class InstrumentInteractionDrumItem : InstrumentInteractionItem
	{
		protected override bool CanInteract(Collider other)
		{
			return false;
		}
	}
}
