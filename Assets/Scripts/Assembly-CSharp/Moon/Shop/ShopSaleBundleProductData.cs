using System;
using System.Collections.Generic;
using Moon.MultiPlay;
using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public class ShopSaleBundleProductData : ShopSaleProductData
	{
		[SerializeField]
		private List<ShopSaleProductDataDefinition> _bundledDefinitions;

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
