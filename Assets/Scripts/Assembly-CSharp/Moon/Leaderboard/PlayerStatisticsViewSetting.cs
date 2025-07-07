using System;
using System.Collections.Generic;
using DP.Takeaway.Runtime;
using UnityEngine;

namespace Moon.Leaderboard
{
	[CreateAssetMenu(fileName = "PlayerStatisticsViewSetting", menuName = "Moon/Statistics/Create PlayerStatisticsViewSetting")]
	public class PlayerStatisticsViewSetting : ScriptableObject
	{
		[Serializable]
		public enum PageType
		{
			Legacy = 1,
			Daily = 4,
			Distance = 8,
			Goal = 0x10,
			Match = 0x20,
			ChampionWeapon = 0x40
		}

		[Serializable]
		private class PlayerStatisticsView
		{
			[SerializeField]
			public string displayName;

			[SerializeField]
			public List<LeaderboardNames> requiredNames;
		}

		[Serializable]
		private class PlayerStatisticsPage : SerializableDictionary<PageType, PlayerStatisticsView>
		{
		}

		[SerializeField]
		private PlayerStatisticsPage statisticsPage;

		public List<string> GetRequiredNames(PageType pageType, PlayerSuitClass suitClass = PlayerSuitClass.None)
		{
			return null;
		}
	}
}
