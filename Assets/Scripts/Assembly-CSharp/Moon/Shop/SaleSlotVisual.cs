using System;
using System.Runtime.CompilerServices;
using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop
{
	public class SaleSlotVisual : MonoBehaviour
	{
		[SerializeField]
		protected SaleSlotBase _saleSlot;

		[SerializeField]
		private Transform? _predefinedDisplayPivot;

		[SerializeField]
		private ShopSaleProductEffectsPlayer _effectsPlayer;

		private SkuData? _cachedSkuData;

		private GameObject? _displayModel;

		private SaleSlotBase.State _oldState;

		public GameObject? DisplayModel => null;

		public event Action? WillUpdateDisplayModel
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

		public event Action? OnDisplayModelUpdated
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void HandleSlotUpdated()
		{
		}

		private void UpdateVisual()
		{
		}

		private void UnloadProduct()
		{
		}

		private void LoadProduct(ShopSaleProductDataDefinition skuData)
		{
		}
	}
}
