using TMPro;
using UnityEngine;

namespace Moon.Shop
{
	public class SaleSlotConsoleDiscount : SaleSlotConsole
	{
		[SerializeField]
		private TMP_Text _savingsText;

		protected override void HandleSlotUpdated()
		{
		}

		protected override void SetPriceOnButtons()
		{
		}
	}
}
