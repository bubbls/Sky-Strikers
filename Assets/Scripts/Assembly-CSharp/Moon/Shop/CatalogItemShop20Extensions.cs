using PlayFab.EconomyModels;

namespace Moon.Shop
{
	public static class CatalogItemShop20Extensions
	{
		private const string ShortTitleKey = "ShortTitle";

		private const string RarityKey = "Rarity";

		public static Rarity GetRarity(this CatalogItem item)
		{
			return default(Rarity);
		}

		public static string GetShortTitle(this CatalogItem item)
		{
			return null;
		}

		private static bool TryGetKey(object displayProperties, string key, out object? value)
		{
			value = null;
			return false;
		}
	}
}
