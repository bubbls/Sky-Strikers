using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using DP.Takeaway.Runtime;
using SVGImporter;
using UnityEngine;

namespace Moon.Leaderboard
{
	[CreateAssetMenu(fileName = "BadgeLevels", menuName = "Moon/Leaderboard/Badge Levels")]
	public class BadgeLevels : SingleScriptableObject<BadgeLevels, DefaultResourcePathProvider<BadgeLevels>>
	{
		[Serializable]
		public class Level
		{
			public int Value;

			public Color NameColor;

			public SVGAsset Icon;
		}

		[Serializable]
		public class Levels
		{
			public List<Level> LevelsList;
		}

		[Serializable]
		private class BadgeLevelLookup : SerializableDictionary<LeaderboardNames, Levels>
		{
		}

		[SerializeField]
		private Level _defaultLevel;

		[SerializeField]
		private BadgeLevelLookup _badgeLevelLookup;

		public Level DefaultLevel => null;

		public Level GetBadgeLevel(LeaderboardNames leaderboardName, PlayerStatistics stats)
		{
			return null;
		}
	}
}
