namespace Moon.Shop.Sale
{
	public class ShopProductPurchaseEquipButton : ShopProductEquipButton
	{
		private new ShopProductPurchaseEquipButtonVisual Visual => null;

		protected override void OnDestroy()
		{
		}

		public override void HandleOnProductDataUpdated(ShopSaleProductData productData, bool isPurchased)
		{
		}

		public void ShowDefaultState(string price)
		{
		}

		public void ShowConfirmState()
		{
		}

		public void ShowPurchasingState()
		{
		}

		protected override void UpdateButtonsEquippedState()
		{
		}
	}
}
