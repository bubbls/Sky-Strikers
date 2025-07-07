using Chamber8.Framework.Messaging;

namespace Moon.Economy
{
	public static class MessageModels
	{
		public static readonly ISubscriptionModel CurrencyProductsUpdated;

		public static readonly ISubscriptionModel InGameStoreProductUpdated;

		public static readonly ISubscriptionModel PlayerInitialInventoryFetched;

		public static readonly ISubscriptionModel PlayerInventoryUpdated;

		public static readonly ISubscriptionModel PlayerBalanceChanged;

		public static readonly ISubscriptionModel PlayerStoreDataUpdated;
	}
}
