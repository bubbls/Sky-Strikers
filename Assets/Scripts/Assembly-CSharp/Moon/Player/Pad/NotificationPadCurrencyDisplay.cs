using System.Collections.Generic;
using Moon.Economy;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class NotificationPadCurrencyDisplay : MonoBehaviour
	{
		[SerializeField]
		private NotificationPadCurrencyInfoBase _jcInfo;

		[SerializeField]
		private NotificationPadCurrencyInfoBase _freeCurrencyInfo;

		public void SetBalance(PlayerEconomyConstants.CurrencyType currencyType, int balance, int change = 0, bool enableObj = false)
		{
		}

		public bool TryShowBalanceChanged(PlayerEconomyConstants.CurrencyType currencyType, int balance, int change)
		{
			return false;
		}

		public bool TryAnimateToTarget(List<CurrencyNotificationDetails> messageCurrencyDetails, Dictionary<PlayerEconomyConstants.CurrencyType, int> cachedCurrencyDict)
		{
			return false;
		}

		public void ShowBalance(PlayerEconomyConstants.CurrencyType currencies)
		{
		}

		public void HideBalance()
		{
		}

		public void ToggleBalance(PlayerEconomyConstants.CurrencyType currencies, bool show)
		{
		}

		public bool IsShowingAnyBalance()
		{
			return false;
		}

		public bool IsShowingBalance(PlayerEconomyConstants.CurrencyType currencyType)
		{
			return false;
		}
	}
}
