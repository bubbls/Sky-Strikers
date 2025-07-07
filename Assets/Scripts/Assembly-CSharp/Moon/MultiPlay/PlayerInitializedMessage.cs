using Fusion;

namespace Moon.MultiPlay
{
	public class PlayerInitializedMessage
	{
		public PlayerRef PlayerRef { get; private set; }

		public MPlayer Player { get; private set; }

		public MPlayerContainer PlayerContainer { get; private set; }

		public PlayerInitializedMessage(MPlayer player, MPlayerContainer playerContainer)
		{
		}
	}
}
