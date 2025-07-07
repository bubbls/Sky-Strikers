using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using Moon.Economy;
using UnityEngine;

namespace Moon.Shop.Sale
{
	[Obsolete]
	public class ShopSaleManager : MonoBehaviour
	{
		[SerializeField]
		private List<ShopSaleProduct> _skinsProductList;

		[SerializeField]
		private List<ShopSaleProduct> _batProductList;

		private List<ShopSaleProduct> _allProductsList;

		private PlayerEconomy _playerEconomy;

		private IMessageSubscriber[] _subscribers;

		private bool _isPurchaseAttemptComplete;

		private bool _isPurchaseSucceed;

		private bool _isBalanceUpdated;

		private Action<bool> _purchaseResultCallback;

		private ShopSaleProduct _currentPurchasingProduct;

		public event Action<ShopSaleProductData, Action<bool, string>> RequestPurchase
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

		public void Initialize()
		{
		}

		private void SubscribeMessages()
		{
		}

		private void OnDestroy()
		{
		}

		private void SetupProducts()
		{
		}

		private void SetupSaleProducts(in List<ShopSaleProduct> productList, IList<ShopSaleProductDataDefinition> definitionsList)
		{
		}

		private int HandleInGameStoreProductUpdated(IMessage<object> _)
		{
			return 0;
		}

		private void SyncProductData()
		{
		}

		public void ResetProductBySku(string sku)
		{
		}

		public void AddProductToCartBySkuManually(string sku)
		{
		}

		private void SetPurchasedProductByFriendlyID(string friendlyID)
		{
		}

		private void HandleRequestPurchase(ShopSaleProduct product, Action<bool> onComplete)
		{
		}

		private int HandleOnPlayerBalanceChanged(IMessage<object> message)
		{
			return 0;
		}

		private int HandleOnPlayerInventoryUpdated(IMessage<object> message)
		{
			return 0;
		}

		private void SetPurchasedProducts()
		{
		}

		private void TryCompletePurchase()
		{
		}
	}
}
