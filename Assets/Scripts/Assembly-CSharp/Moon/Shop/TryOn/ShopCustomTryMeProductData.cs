using System;
using System.Runtime.CompilerServices;
using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop.TryOn
{
	public class ShopCustomTryMeProductData : MonoBehaviour
	{
		[SerializeField]
		private ShopTryMeManager _tryMeManager;

		[SerializeField]
		private ShopSaleProductDataDefinition _productDataDefinition;

		public event Action? RequestLogShopGoodsTryMe
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

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleRequestLogShopGoodsTryMe()
		{
		}
	}
}
