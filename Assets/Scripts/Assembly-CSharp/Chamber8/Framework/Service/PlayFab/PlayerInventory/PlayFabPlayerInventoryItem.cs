using PlayFab.EconomyModels;
using PlayFab.Json;

namespace Chamber8.Framework.Service.PlayFab.PlayerInventory
{
	public class PlayFabPlayerInventoryItem
	{
		private InventoryItem _inventoryItem;

		public string Id => null;

		public int Amount => 0;

		public string Type => null;

		public string StackId => null;

		public JsonObject? DisplayProperties => null;

		public PlayFabPlayerInventoryItem(InventoryItem inventoryItem)
		{
		}

		public void AddAmountLocally(int i)
		{
		}

		public void SwapLocally(PlayFabPlayerInventoryItem other)
		{
		}

		public PlayFabPlayerInventoryItem CreateLocalCopy(string stackId, int amount)
		{
			return null;
		}
	}
}
