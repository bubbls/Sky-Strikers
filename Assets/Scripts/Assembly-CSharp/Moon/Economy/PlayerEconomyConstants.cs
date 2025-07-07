using System.Collections.Generic;
using PlayFab.EconomyModels;

namespace Moon.Economy
{
	public static class PlayerEconomyConstants
	{
		public enum CurrencyType
		{
			FreeCurrency = 0,
			Juice = 1
		}

		public const string JuiceFriendlyId = "com.chamber8.igc.skystrikersvr_juice";

		public const string JuiceSymbol = "g";

		public const string SipletsFriendlyId = "com.chamber8.igc.skystrikersvr_siplets";

		public static string SipletsSymbol;

		public const string DataFriendlyId = "com.chamber8.igc.skystrikersvr_data";

		public static string DataSymbol;

		public const string FreeCurrencyFriendlyId = "com.chamber8.igc.skystrikersvr_freecurrency";

		public static string FreeCurrencySymbol;

		public const string GameStoreFriendlyId = "game_store";

		public const string ActivityStoreFriendlyId = "activity_store";

		public const string JuiceStoreFriendlyId = "juice_store";

		public const string FreeCurrencyStoreFriendlyId = "free_currency_store";

		public const string ContentTypeJoyos = "Joyos";

		public const string ContentTypeCoins = "Conins";

		public const string TagEquipment = "Equipment";

		public const string TagSuit = "Suit";

		public const string ModsPFlagFriendlyId = "com.chamber8.skystrikersvr.consumable.pflag";

		public const string MatchCompleteTitle = "Match Complete";

		private static readonly HashSet<string> _inStoreItemTags;

		public static bool IsStoreItem(CatalogItem catalogItem)
		{
			return false;
		}

		public static string GetCurrencyIdFromIndex(PriceIndex priceIndex)
		{
			return null;
		}

		public static CurrencyType GetCurrencyTypeFromIndex(PriceIndex priceIndex)
		{
			return default(CurrencyType);
		}
	}
}
