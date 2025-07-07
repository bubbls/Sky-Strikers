using System.Collections.Generic;
using Moon.Framework.Leaderboard;

namespace Moon.Leaderboard
{
	public struct HofSlotData
	{
		public string LeaderboardName;

		public string LeaderboardDisplayName;

		public string PreferredSuitClass;

		public List<LeaderboardEntry>? Entries;

		public LeaderboardEntry? MyEntry;

		public PlayerSuitClass SuitClass => default(PlayerSuitClass);
	}
}
