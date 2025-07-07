using TMPro;
using UnityEngine;

namespace Moon.Shop.Charge
{
	public class ShopChargeProductSwitchText : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _bonusText;

		[SerializeField]
		private float _intervalTime;

		private int _index;

		private string[] _text;

		private bool _showing;

		private float _timer;

		public TMP_Text BonusText => null;

		public void ShowTexts(string[] text)
		{
		}

		private void Update()
		{
		}
	}
}
