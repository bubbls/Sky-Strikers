using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Service.PlayFab.PlayerInventory;
using PlayFab.EconomyModels;

namespace Moon.Shop
{
	public class SkuDatabase : Singleton<SkuDatabase>
	{
		private class Store
		{
			public readonly CatalogItem StoreItem;

			private readonly Dictionary<string, SkuData> _cachedSkus;

			public void CacheSkuData(SkuData skuData)
			{
			}

			public SkuData GetCachedSkuData(string itemIdOrFriendlyId)
			{
				return null;
			}

			public Store(CatalogItem storeItem)
			{
			}
		}

		private readonly Dictionary<string, Store> _cachedStores;

		private readonly Dictionary<string, SkuData> _purchasedSkus;

		public IEnumerable<SkuData> PurchasedSkus => null;

		public event Action? OnPurchasedSkusUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public SkuData GetSkuData(string gameStoreIdOrFriendlyId, string itemIdOrFriendlyId)
		{
			return null;
		}

		private Store GetStore(PlayFabCatalogItemService catalogItemService, string storeIdOrFriendlyId)
		{
			return null;
		}

		private static SkuData GetSkuDataInternal(PlayFabCatalogItemService catalogItemService, Store store, string itemIdOrFriendlyId)
		{
			return null;
		}

		private static SkuData LoadSkuDataNotInStore(PlayFabCatalogItemService catalogItemService, CatalogItem catalogItem)
		{
			return null;
		}

		private static SkuData LoadSkuData(PlayFabCatalogItemService catalogItemService, CatalogItem store, CatalogItem catalogItem, CatalogItemReference itemReference)
		{
			return null;
		}

		public void UpdatePurchasedSkus(IEnumerable<string> friendlyIds)
		{
		}
	}
}
