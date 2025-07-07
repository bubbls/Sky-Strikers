using System;

namespace Moon.Hub
{
	[Serializable]
	public class HofHighlightTopPlayersCollection
	{
		public string Title;

		public HofFeaturedPlayerWithScoreData[] TopPlayers;
	}
}
