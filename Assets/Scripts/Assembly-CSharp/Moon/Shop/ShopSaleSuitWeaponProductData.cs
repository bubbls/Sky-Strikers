using System;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public class ShopSaleSuitWeaponProductData : ShopSaleProductData
	{
		[SerializeField]
		private PlayerVisualsSuitWeaponPreset? _suitWeaponPreset;

		public PlayerVisualsSuitWeaponPreset SuitWeaponPreset => null;

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
