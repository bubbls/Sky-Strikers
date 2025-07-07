using PlayFab.EconomyModels;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Shop
{
	public class SaleSlotPrice : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _textPrice;

		[SerializeField]
		private TMP_Text _textOriginalPrice;

		[SerializeField]
		private GameObject _priceObject;

		[SerializeField]
		private GameObject _purchasingObject;

		[SerializeField]
		private GameObject _purchasedObject;

		[SerializeField]
		private GameObject _errorObject;

		[SerializeField]
		private TMP_Text _textError;

		[SerializeField]
		private GameObject _waitConfirmationObject;

		[SerializeField]
		private Graphic[] _graphicsToDisable;

		[SerializeField]
		private Color _disabledGraphcsColor;

		[SerializeField]
		private TMP_FontAsset _disabledPriceFont;

		[SerializeField]
		private TMP_FontAsset _enabledPriceFont;

		public void SetPriceAmount(CatalogPriceAmount? amount, CatalogPriceAmount? originalAmount = null)
		{
		}

		public void SetPurchased()
		{
		}

		public void SetError(string errorPrompt)
		{
		}

		public void SetWaitConfirmation()
		{
		}

		public void SetPurchasing()
		{
		}

		public void SetIdle()
		{
		}

		public void SetDisabled()
		{
		}

		private void ToggleDisabled(bool isDisabled)
		{
		}
	}
}
