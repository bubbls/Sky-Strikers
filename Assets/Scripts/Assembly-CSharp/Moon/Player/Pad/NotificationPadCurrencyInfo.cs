using Moon.Shop;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class NotificationPadCurrencyInfo : NotificationPadCurrencyInfoBase
	{
		[SerializeField]
		private AnimationNumbersText _balanceText;

		[SerializeField]
		private TMP_Text _changeText;

		[SerializeField]
		private float _changeValueDisplayTime;

		private bool _showChangeValue;

		private float _showChangeValueTimer;

		public override void SetBalance(int balance, int change)
		{
		}

		private void LateUpdate()
		{
		}
	}
}
