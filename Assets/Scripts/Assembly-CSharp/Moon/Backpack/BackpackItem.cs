using PlayFab.EconomyModels;

namespace Moon.Backpack
{
	public class BackpackItem
	{
		public readonly CatalogItem Item;

		public int Amount { get; private set; }

		public BackpackItem(CatalogItem catalogItem, int amount)
		{
		}
	}
}
