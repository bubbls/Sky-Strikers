using System;
using DG.Tweening;
using SVGImporter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Shop.Charge
{
	public class ShopChargeScreenController : MonoBehaviour
	{
		[SerializeField]
		private ShopChargeScreenDataDefinitionManager _definitionManager;

		[SerializeField]
		private GameObject _container;

		[SerializeField]
		private TMP_Text _messageText;

		[SerializeField]
		private SVGImage _icon;

		[SerializeField]
		private Image _iconSprite;

		[SerializeField]
		private ShopChargeFakeFlow _fakeFlow;

		public Action<ShopChargeScreenStatus> OnUpdateMessage;

		private Tween _iconTween;

		private Tween _iconSpriteTween;

		public void ToggleScreen(bool enable)
		{
		}

		public void ShowProductsNotAvailableState()
		{
		}

		public void ShowIdleState()
		{
		}

		public void ShowRechargingState()
		{
		}

		public void ShowRechargingWithCountdown(int countdown)
		{
		}

		public void ShowRechargeSucceedState()
		{
		}

		public void ShowRechargeFailedState()
		{
		}

		public void ShowIgcUpdatedState()
		{
		}

		public void ShowRecoverIgcExchangeFailedState()
		{
		}

		public void ShowIapReceiptConsumeFailedState()
		{
		}

		public void ShowRecoverSucceedState()
		{
		}

		public void ShowRecoveringState()
		{
		}

		private void UpdateMessage(ShopChargeScreenStatus status, string additionalMessage = "")
		{
		}

		private void DisplayBlinkIcon()
		{
		}

		private void DisplayRotatingIcon()
		{
		}

		private void StopIconTween()
		{
		}

		private void SetToIdleState(float delay = 5f)
		{
		}

		private void OnDestroy()
		{
		}

		private void KillTween()
		{
		}
	}
}
