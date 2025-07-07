using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Economy;
using Moon.Player.Pad;
using UnityEngine;

namespace Moon.Shop
{
	public class CurrencyPad : MonoBehaviour
	{
		[SerializeField]
		private NotificationPadCurrencyDisplay _currencyDisplay;

		[SerializeField]
		private GameObject _offScreen;

		private IMessageSubscriber[] _subscribers;

		private PlayerEconomy _playerEconomy;

		private CurrencyNotificationArea.SupportedCurrencies _currenciesOnDisplay;

		private Dictionary<PlayerEconomyConstants.CurrencyType, int> _currencyDict;

		private bool _isOn;

		private int _cachedChangeValue;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private int HandlePlayerInitialInventoryFetched(IMessage<object> message)
		{
			return 0;
		}

		private int HandlePlayerBalanceChanged(IMessage<object> arg)
		{
			return 0;
		}

		private void SetInitialBalance()
		{
		}

		public void TurnOn(CurrencyNotificationArea.SupportedCurrencies currenciesToShow)
		{
		}

		public void ShowBalances(CurrencyNotificationArea.SupportedCurrencies currenciesToShow)
		{
		}

		public void TurnOff()
		{
		}

		private void ToggleCurrencyScreen(bool show)
		{
		}
	}
}
