using System;

namespace Moon.Hub
{
	[Serializable]
	public class HofHighlightsData
	{
		public HofHighlightTopPlayersCollection[] SeasonalTopRankedPlayers;

		public HofFeaturedPlayerData[] FeaturedPlayers;
	}
}
