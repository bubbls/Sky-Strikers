using Fusion;

namespace Moon.MultiPlay
{
	public class PlayerInfoChangedMessage
	{
		public PlayerRef PlayerRef;

		public PlayerInfo OldPlayerInfo;

		public PlayerInfo PlayerInfo;

		public void Reset(PlayerRef playerRef, PlayerInfo oldPlayerInfo, PlayerInfo playerInfo)
		{
		}
	}
}
