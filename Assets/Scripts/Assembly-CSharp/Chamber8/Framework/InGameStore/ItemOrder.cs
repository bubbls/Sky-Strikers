using System.Collections.Generic;
using PlayFab.EconomyModels;

namespace Chamber8.Framework.InGameStore
{
	public class ItemOrder
	{
		public readonly CatalogItem Store;

		public readonly CatalogItem Item;

		public readonly int Amount;

		public readonly CatalogPrice UnitPrice;

		public CatalogPriceAmount? GetFirstPriceAmount()
		{
			return null;
		}

		public ItemOrder(CatalogItem store, CatalogItem item, CatalogPrice unitPrice, int quality = 1)
		{
		}

		public List<PurchasePriceAmount> GetTotalPriceAmounts()
		{
			return null;
		}
	}
}
