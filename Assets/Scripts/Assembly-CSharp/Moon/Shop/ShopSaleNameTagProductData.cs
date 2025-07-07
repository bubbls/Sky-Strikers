using System;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public class ShopSaleNameTagProductData : ShopSaleProductData
	{
		[SerializeField]
		private PlayerVisualsNameTagPreset _nameTagVisualsPreset;

		public PlayerVisualsNameTagPreset NameTagPreset => null;

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
