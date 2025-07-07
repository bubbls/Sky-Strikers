using System.Collections.Generic;
using Moon.Shop.Sale;
using PlayFab.EconomyModels;

namespace Moon.Shop
{
	public class SkuData
	{
		public readonly CatalogItem? Store;

		public readonly CatalogItem Item;

		public readonly ShopSaleProductDataDefinition? Product;

		public readonly CatalogPrice? SelectedPrice;

		public readonly List<CatalogPrice>? AllPrices;

		public readonly List<SkuData> BundledSkus;

		public bool IsBundle => false;

		public SkuData(CatalogItem catalogItem, ShopSaleProductDataDefinition product)
		{
		}

		public SkuData(CatalogItem store, CatalogItem catalogItem, CatalogItemReference? itemReference, ShopSaleProductDataDefinition? product)
		{
		}

		public CatalogPriceAmount? GetDefaultPriceAmount()
		{
			return null;
		}

		public CatalogPriceAmount? GetSecondPriceAmount()
		{
			return null;
		}

		public CatalogPriceAmount? GetDiscountPriceAmount()
		{
			return null;
		}

		public void AddBundledSkuData(SkuData skuData)
		{
		}
	}
}
