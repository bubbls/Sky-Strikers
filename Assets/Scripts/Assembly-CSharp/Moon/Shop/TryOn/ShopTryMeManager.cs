using System;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using UnityEngine;

namespace Moon.Shop.TryOn
{
	public class ShopTryMeManager : MonoBehaviour
	{
		[SerializeField]
		private GameObject? _teamNotAssignedContainer;

		[SerializeField]
		private GameObject? _teamAssignedContainer;

		[Header("Try Me Buttons")]
		[Space(5f)]
		[SerializeField]
		private ShopTryMeButton _teamNotAssignedTryMeButton;

		[SerializeField]
		private ShopTryMeButton? _teamOneTryMeButton;

		[SerializeField]
		private ShopTryMeButton? _teamTwoTryMeButton;

		[SerializeField]
		private ShopTryMeButton.TryMeButtonState _unpurchasedState;

		private IMessageSubscriber[]? _subscribers;

		private SkuData? _skuData;

		private ShopSaleProductData? _productData;

		private bool _isMultiTeamProduct;

		private bool _isCustomized;

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

		private void RegisterEvent(ShopTryMeButton? tryMeButton, bool register)
		{
		}

		public void UpdateSkuData(SkuData? skuData)
		{
		}

		public void UpdateProductData(ShopSaleProductData? productData)
		{
		}

		private void ToggleButtonState(ShopTryMeButton? tryMeButton, ShopTryMeButton.TryMeButtonState state)
		{
		}

		private void UpdateButtonStatus()
		{
		}

		private void ToggleTeamNotAssignedContainer(bool enable)
		{
		}

		private void InitializeTryMeButton(ShopTryMeButton? tryMeButton, TeamNo teamNo)
		{
		}

		private void HandleOnButtonPressed(TeamNo teamNo)
		{
		}

		private void LogShopGoodsTryMe()
		{
		}
	}
}
