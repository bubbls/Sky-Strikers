using System.Collections.Generic;
using Moon.Economy;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Moon.Shop
{
	public class SaleSlotMini : SaleSlot
	{
		[SerializeField]
		private CurrencyNotificationArea _currencyNotificationArea;

		public override int GetDisplayPrices(out Dictionary<PriceIndex, CatalogPriceAmount> displayPrices)
		{
			displayPrices = null;
			return 0;
		}
	}
}
