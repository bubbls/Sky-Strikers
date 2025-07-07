using TMPro;
using UnityEngine;

namespace Moon.Shop.Sale
{
	public class ShopSaleProductPanel : MonoBehaviour
	{
		private enum CurrentView
		{
			Title = 0,
			Description = 1,
			Confirm = 2,
			Purchasing = 3,
			NotEnoughBalance = 4
		}

		private const float DescriptionShowTime = 10f;

		private const float NotEnoughBalanceShowTime = 3f;

		[SerializeField]
		private TMP_Text _panelText;

		[SerializeField]
		private ShopSaleProductPanelTraitButton[] _traitButtons;

		private ShopSaleProductData _shopSaleBatProductData;

		private CurrentView _currentView;

		private string _titleText;

		public void Initialize(ShopSaleProductData shopSaleProductData)
		{
		}

		private void OnDestroy()
		{
		}

		public void HandleOnProductDataUpdated(ShopSaleProductData shopSaleProductData, bool isPurchased)
		{
		}

		public void HideButtons()
		{
		}

		public void ShowButtons()
		{
		}

		public void ShowTitle()
		{
		}

		public void ShowNotEnoughBalance()
		{
		}

		private void ShowInfoAboutTrait(int traitIndex)
		{
		}

		private void SetView(CurrentView view)
		{
		}

		public void ShowConfirmState()
		{
		}

		public void ShowPurchasingState()
		{
		}

		public void ShowPurchasedState()
		{
		}

		public void ClearText()
		{
		}
	}
}
