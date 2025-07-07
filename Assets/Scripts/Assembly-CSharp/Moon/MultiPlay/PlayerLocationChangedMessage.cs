using Fusion;

namespace Moon.MultiPlay
{
	public class PlayerLocationChangedMessage
	{
		public PlayerRef PlayerRef;

		public Location PrevLocation;

		public Location Location;
	}
}
