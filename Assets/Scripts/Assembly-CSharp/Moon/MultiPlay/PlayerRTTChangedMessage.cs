using Fusion;

namespace Moon.MultiPlay
{
	public class PlayerRTTChangedMessage
	{
		public PlayerRef PlayerRef;

		public int RTT;

		public PlayerRTTChangedMessage Reset(PlayerRef playerRef, int rtt)
		{
			return null;
		}
	}
}
