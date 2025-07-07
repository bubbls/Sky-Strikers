using Fusion;

namespace Moon.GameActivity
{
	public class EventCurrencyChangedMessage
	{
		public PlayerRef PlayerRef;

		public int PreviousAmount;

		public int Amount;
	}
}
