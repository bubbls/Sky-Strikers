using System;
using System.Runtime.CompilerServices;
using Moon.Economy;
using Moon.Shop.TryOn;
using UnityEngine;

namespace Moon.Shop.Sale
{
	public class ShopSaleProduct : ShopProduct
	{
		private enum ProductState : byte
		{
			AddToCart = 0,
			RemoveFromCart = 1,
			Purchased = 2,
			Purchasing = 3
		}

		[SerializeField]
		private ShopSaleProductModelSpawner _modelSpawner;

		[SerializeField]
		private ShopTryMeManager _tryMeManager;

		[SerializeField]
		private ShopModelSwitcher _shopModelSwitcher;

		[SerializeField]
		private ShopProductPurchaseEquipButton _purchaseButton;

		[SerializeField]
		private ShopSaleProductPanel _productPanel;

		[SerializeField]
		private ShopSaleProductEffectsPlayer _effectsPlayer;

		private PlayerEconomy _playerEconomy;

		private ProductState _productState;

		private bool _addToCart;

		private bool _confirmToPurchase;

		private bool _isInitialized;

		private int _purchasingSoundID;

		public event Action<ShopSaleProduct, Action<bool>> RequestPurchase
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<bool, ShopSaleProductData> OnUpdateProductInCart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override void Initialize(BaseItemData productData)
		{
		}

		public override void Dispose()
		{
		}

		public void NotifyProductDataUpdated()
		{
		}

		public ShopSaleProductData GetProductData()
		{
			return null;
		}

		public void Reset()
		{
		}

		public void SetProductAsPurchased()
		{
		}

		private void HandleOnButtonPressed(string buttonName)
		{
		}

		private void HandleButtonPressedForPurchase()
		{
		}

		private void HandleOnPurchaseStateExited(bool isPurchaseCompleted)
		{
		}

		private void ResetPurchaseProductButton()
		{
		}

		protected virtual void HandleOnPurchasingStateEntered()
		{
		}

		protected virtual void HandleOnPurchaseStateExitedInternal()
		{
		}

		private void LogShopGoodsBuyNowClick()
		{
		}

		private void ResetCartStatus()
		{
		}

		public void AddProductToCartManually()
		{
		}

		private void HandleUpdateProductInCartButtonPressed()
		{
		}
	}
}
