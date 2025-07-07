using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.VisualScripting;
using Moon.Economy;
using Moon.Shop.Common;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Shop.Charge
{
	[RequireComponent(typeof(CustomEventHandler))]
	public class ShopChargeProduct : ShopProduct
	{
		[SerializeField]
		private TMP_Text _priceText;

		[SerializeField]
		private TMP_Text _descriptionText;

		[SerializeField]
		private TMP_Text _descriptionBackgroundText;

		[SerializeField]
		private TMP_Text _messageText;

		[SerializeField]
		private TMP_Text _messageBackgroundText;

		[SerializeField]
		private float _defaultFontSize;

		[SerializeField]
		private float _errorFontSize;

		[SerializeField]
		private VRPhysicsButton _chargeButton;

		[SerializeField]
		private Image _juiceIconSvgImage;

		[SerializeField]
		private GameObject _juiceIconGlowing;

		[SerializeField]
		private ShopChargeProductSwitchText _bonusOriginalText;

		[SerializeField]
		private ShopChargeButtonVisualConfig _defaultVisualConfig;

		[SerializeField]
		private ShopChargeButtonVisualConfig _pressedVisualConfig;

		[SerializeField]
		private ShopChargeButtonVisualConfig _disableVisualConfig;

		private bool _isButtonPressed;

		public ShopChargeProductData ChargeProductData => null;

		public event Action<ShopChargeProductData, Action<PlayerEconomyError>> RequestPurchase
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

		public event Action<ShopChargeProductData, Action<PlayerEconomyError>> RequestRecoverPurchasingCurrencies
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

		public override void Initialize(BaseItemData productData)
		{
		}

		public override void Dispose()
		{
		}

		public void SetProductDisable(bool animate = true)
		{
		}

		public void SetProductPurchased()
		{
		}

		public void SetProductNotAvailable()
		{
		}

		public void SetProductPurchaseProcessing()
		{
		}

		public void HandleReconnectUpdateText()
		{
		}

		private void HandleOnButtonPressed(VRPhysicsButton.ButtonState buttonState)
		{
		}

		public void NotifyProductDataUpdated()
		{
		}

		private void UpdateVisualsColor(Color32 frameColor, Color32 descriptionBackgroundColor, Color32 priceColor, Color32 descriptionColor)
		{
		}
	}
}
