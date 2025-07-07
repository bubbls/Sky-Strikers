using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Utils;
using Moon.Economy;
using Moon.Hub;
using Moon.Shop.TryOn;
using NaughtyAttributes;
using TMPro;
using UnityEngine;

namespace Moon.Shop
{
	public class SaleSlotConsole : MonoBehaviour
	{
		private const string TextSoldOut = "SOLD OUT";

		private const string TextComingSoon = "COMING SOON";

		private static readonly int _prizeColor;

		private static readonly int _switch;

		[SerializeField]
		protected SaleSlotBase _saleSlot;

		[SerializeField]
		private TMP_Text _textCountdown;

		[SerializeField]
		private TMP_Text _textTitle;

		[SerializeField]
		private TMP_Text _textContent;

		[SerializeField]
		protected SaleSlotPurchaseButton? _singlePriceButton;

		[SerializeField]
		private SaleSlotPurchaseButton[]? _multiPriceButtons;

		[SerializeField]
		private MeshRenderer[]? _rarityMeshRenderers;

		[SerializeField]
		private TMP_Text? _rarityName;

		[SerializeField]
		private ShopTryMeManager? _tryMeManager;

		[SerializeField]
		private CurrencyTransactionTubeRendererController _tubeController;

		[SerializeField]
		private SaleSlotVisual? _saleSlotVisual;

		private readonly Cooldown _cooldown;

		private Tween? _tubeTween;

		private float _tubeAnimProgress;

		private SaleSlotPurchaseButton _currentPurchaseButton;

		public event Action<PriceIndex>? RequestPurchase
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

		private void UnregisterEventsFromDisplayModel()
		{
		}

		private void RegisterEventsToDisplayModel()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void PurchaseEffectStart()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void PurchaseEffectStop()
		{
		}

		private void HandleRequestLogShopGoodsTryMe()
		{
		}

		private void HandleButtonPurchasePressed(SaleSlotPurchaseButton purchaseButton, PriceIndex priceIndex)
		{
		}

		protected virtual void HandleSlotUpdated()
		{
		}

		protected virtual void SetPriceOnButtons()
		{
		}

		private void SetNoSku()
		{
		}

		private void Update()
		{
		}

		private void UpdateCountdown()
		{
		}

		protected void ToggleSinglePriceButton(bool show)
		{
		}

		protected void ToggleMultiPriceButtons(bool show)
		{
		}

		private void ShowIdleStateForAllPurchaseButtons()
		{
		}

		private void ShowPurchasedStateForAllPurchaseButtons()
		{
		}
	}
}
