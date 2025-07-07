using System;
using System.Runtime.CompilerServices;
using Moon.Economy;
using Moon.Hub;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Moon.Shop
{
	public class SaleSlotPurchaseButton : MonoBehaviour
	{
		[SerializeField]
		private ManualButton? _manualButton;

		[SerializeField]
		private SaleSlotPrice? _price;

		private PriceIndex _currentPriceIndex;

		public PriceIndex CurrentPriceIndex => default(PriceIndex);

		public event Action<SaleSlotPurchaseButton, PriceIndex>? OnPurchaseRequested
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

		private void HandleButtonPurchasePressed()
		{
		}

		public void SetPrice(PriceIndex priceIndex, CatalogPriceAmount amount, CatalogPriceAmount? originalAmount = null)
		{
		}

		public void ShowError()
		{
		}

		public void ShowInsufficientFundsError()
		{
		}

		public void ShowWaitConfirmation()
		{
		}

		public void ShowPurchasing()
		{
		}

		public void ShowPurchased()
		{
		}

		public void ShowIdle()
		{
		}

		public void HidePrice()
		{
		}

		public void SetDisabled()
		{
		}
	}
}
