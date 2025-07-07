using System;
using DP.Takeaway.VisualScripting;
using Moon.Arena;
using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop.Wardrobe
{
	[RequireComponent(typeof(CustomEventHandler))]
	[Obsolete]
	public class ShopWardrobeBat : ShopWardrobeItem
	{
		[SerializeField]
		private ShopProductEquipButton _equipButton;

		[SerializeField]
		private ShopSaleProductModelSpawner _modelSpawner;

		[SerializeField]
		private ShopSaleProductPanel _productPanel;

		[SerializeField]
		private BatTierVisualsConfigs _tierVisualsConfigs;

		private ShopSaleSuitWeaponProductDataDefinition _suitWeaponProductDataDefinition;

		private bool _hasProductData;

		private bool _hasPurchasedBat;

		private bool _visualsLoaded;

		public override void Initialize(ShopSaleProductDataDefinition productDataDefinition)
		{
		}

		public override void UpdateWardrobe()
		{
		}

		public override void SwitchVisualsForTeam(TeamNo currentTeamOnDisplay)
		{
		}

		private void TryEnableVisuals()
		{
		}

		private void HandleOnButtonPressed(string buttonName)
		{
		}
	}
}
