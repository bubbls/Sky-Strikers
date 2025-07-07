using Chamber8.Framework.Common;
using Moon.Shop.Sale;
using PlayFab.EconomyModels;

namespace Moon.Shop
{
	public class ItemDatabase : Singleton<ItemDatabase>
	{
		public BaseItemDefinition LoadItemDefinition(CatalogItem catalogItem)
		{
			return null;
		}

		public T LoadItemDefinition<T>(CatalogItem catalogItem) where T : notnull, BaseItemDefinition
		{
			return null;
		}

		private static string MakePath(string friendlyId)
		{
			return null;
		}
	}
}
