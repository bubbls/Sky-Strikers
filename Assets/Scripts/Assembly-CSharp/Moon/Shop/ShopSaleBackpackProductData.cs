using System;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public class ShopSaleBackpackProductData : ShopSaleProductData
	{
		[SerializeField]
		private PlayerVisualsBackpackPreset _backpackVisualsPreset;

		public PlayerVisualsBackpackPreset BackpackPreset => null;

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
