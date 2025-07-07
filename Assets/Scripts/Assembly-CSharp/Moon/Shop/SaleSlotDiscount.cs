using System.Collections.Generic;
using Moon.Economy;
using PlayFab.EconomyModels;

namespace Moon.Shop
{
	public class SaleSlotDiscount : SaleSlot
	{
		public override int GetDisplayPrices(out Dictionary<PriceIndex, CatalogPriceAmount> displayPrices)
		{
			displayPrices = null;
			return 0;
		}
	}
}
