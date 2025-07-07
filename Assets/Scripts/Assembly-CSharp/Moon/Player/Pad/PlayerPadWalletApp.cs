using Chamber8.Framework.Messaging;
using Moon.Economy;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadWalletApp : PlayerPadApp
	{
		[SerializeField]
		private NotificationPadCurrencyInfo _jcInfo;

		[SerializeField]
		private NotificationPadCurrencyInfo _freeCurrencyInfo;

		private PlayerEconomy _playerEconomy;

		private IMessageSubscriber[] _subscribers;

		private int _juiceBalance;

		private int _freeCurrencyBalance;

		public override PlayerPadAppID AppID => default(PlayerPadAppID);

		protected override void InitializeInternal()
		{
		}

		private void OnDestroy()
		{
		}

		protected override void HandleAppAboutToOpenInternal(IPlayerPadAppOpenData appOpenData)
		{
		}

		public override void HandleAppOpenedFromNotification(IPlayerPadAppOpenData appOpenData)
		{
		}

		private void RefreshAppOnOpen(IPlayerPadAppOpenData appOpenData)
		{
		}

		private int HandlePlayerBalanceChanged(IMessage<object> message)
		{
			return 0;
		}

		private int HandlePlayerInitialInventoryFetched(IMessage<object> message)
		{
			return 0;
		}

		protected override void HandleAppAboutToCloseInternal()
		{
		}

		private void UpdateBalanceInstantly()
		{
		}

		private void UpdateBalance()
		{
		}
	}
}
