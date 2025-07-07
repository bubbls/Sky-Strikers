using System;
using Moon.Shop;
using UnityEngine;

namespace Moon.Class
{
	[Serializable]
	public struct PlayerCustomizationPageSlotData
	{
		public PlayerCustomizationSlotType SlotType;

		public IPlayerVisualsPreset PresetData;

		public Rarity Rarity;

		public int VisualTheme;

		public string Name;

		public Sprite[] SlotIcons;
	}
}
