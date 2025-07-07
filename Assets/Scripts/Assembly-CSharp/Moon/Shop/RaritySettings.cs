using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using DP.Takeaway.Runtime;
using UnityEngine;

namespace Moon.Shop
{
	[CreateAssetMenu(menuName = "Moon/Shop/Create RaritySettings", fileName = "RaritySettings")]
	public class RaritySettings : SingleScriptableObject<RaritySettings, DefaultResourcePathProvider<RaritySettings>>
	{
		[Serializable]
		public class RaritySettingsData
		{
			public Color Color;

			public string DisplayName;

			public Color DisplayNameColor;
		}

		[Serializable]
		private class Lookup : SerializableDictionary<Rarity, RaritySettingsData>
		{
		}

		[SerializeField]
		private Lookup _lookup;

		public RaritySettingsData GetData(Rarity rarity)
		{
			return null;
		}

		public IEnumerable<Color> GetAllColors()
		{
			return null;
		}
	}
}
