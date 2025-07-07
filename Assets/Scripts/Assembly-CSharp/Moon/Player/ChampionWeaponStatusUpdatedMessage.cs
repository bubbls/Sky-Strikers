using Fusion;

namespace Moon.Player
{
	public class ChampionWeaponStatusUpdatedMessage
	{
		public PlayerRef PlayerRef { get; private set; }

		public ushort MMR { get; private set; }

		public ushort TotalGoals { get; private set; }

		public byte MatchGoals { get; private set; }

		public bool IsWeaponFxActive { get; private set; }

		public int TemporaryTotalGoals => 0;

		public void Reset(PlayerRef playerRef, ushort mmr, ushort totalGoals, byte matchGoals, bool isWeaponFxActive)
		{
		}
	}
}
