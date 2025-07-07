using Moon.Shop;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadNotificationCurrencyInfo : NotificationPadCurrencyInfoBase
	{
		[SerializeField]
		private AnimationNumbersText _balanceText;

		[SerializeField]
		private TMP_Text _changeText;

		[SerializeField]
		private bool _showBalance;

		[SerializeField]
		private Color _positiveChangeColor;

		[SerializeField]
		private Color _negativeChangeColor;

		public override void SetBalance(int balance, int change)
		{
		}
	}
}
