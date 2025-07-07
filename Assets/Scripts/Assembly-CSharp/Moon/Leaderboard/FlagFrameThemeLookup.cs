using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using DP.Takeaway.Runtime;
using Moon.GameActivity;
using UnityEngine;

namespace Moon.Leaderboard
{
	[CreateAssetMenu(fileName = "FlagFrameThemeLookup", menuName = "Moon/Flag Frame/FlagFrameThemeLookup")]
	public class FlagFrameThemeLookup : SingleScriptableObject<FlagFrameThemeLookup, DefaultResourcePathProvider<FlagFrameThemeLookup>>
	{
		[Serializable]
		private class ThemeLookup : SerializableDictionary<FlagFrameTheme, FlagFrameThemeSettings>
		{
		}

		[SerializeField]
		private ThemeLookup _lookup;

		[SerializeField]
		private List<FlagFrameItemDefinition> _products;

		public FlagFrameThemeSettings FindTheme(FlagFrameTheme theme)
		{
			return null;
		}

		public IEnumerable<FlagFrameItemDefinition> AllItemDefinitionsFor(FlagFrameTheme theme)
		{
			return null;
		}
	}
}
