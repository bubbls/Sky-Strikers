using System;
using Moon.Economy;
using UnityEngine;

namespace Moon.Shop.Charge
{
	[Serializable]
	public class ShopChargeProductData : BaseItemData
	{
		[SerializeField]
		private string _slot;

		public string Slot => null;

		public string Name { get; set; }

		public string Description { get; set; }

		public string Price { get; set; }

		public string Sticker { get; set; }

		public PlayerEconomy.CurrencyProductStatus CurrencyProductStatus { get; set; }
	}
}
