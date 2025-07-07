using System;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public class ShopSaleSkinProductData : ShopSaleProductData
	{
		[SerializeField]
		private PlayerVisualsSkinPreset _skinVisualsPreset;

		public PlayerVisualsSkinPreset SkinPreset => null;

		public override bool CanEquip(PlayerInfo playerInfo)
		{
			return false;
		}

		public override bool TryEquip(PlayerInfo playerInfo, out PlayerInfo equipped)
		{
			equipped = default(PlayerInfo);
			return false;
		}
	}
}
