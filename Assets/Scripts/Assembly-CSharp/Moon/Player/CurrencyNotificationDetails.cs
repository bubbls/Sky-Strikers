using System;
using Moon.Economy;

namespace Moon.Player
{
	[Serializable]
	public class CurrencyNotificationDetails
	{
		public PlayerEconomyConstants.CurrencyType CurrencyType;

		public int Balance;

		public CurrencyNotificationDetails(PlayerEconomyConstants.CurrencyType currencyType, int balance)
		{
		}
	}
}
