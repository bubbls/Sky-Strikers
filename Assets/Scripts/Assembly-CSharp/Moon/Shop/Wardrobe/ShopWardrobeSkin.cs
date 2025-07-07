using DG.Tweening;
using DP.Takeaway.VisualScripting;
using Moon.Arena;
using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop.Wardrobe
{
	[RequireComponent(typeof(CustomEventHandler))]
	public class ShopWardrobeSkin : ShopWardrobeItem
	{
		[SerializeField]
		private ShopSaleProductModelSpawner _modelSpawner;

		[SerializeField]
		private ShopSaleProductPanel _productPanel;

		[SerializeField]
		private ShopProductEquipButton[] _equipButtons;

		[SerializeField]
		private float _screenPivotOffset;

		[SerializeField]
		private ShopModelSwitcher _shopModelSwitcher;

		[SerializeField]
		private float _screenMeltingDuration;

		private bool _isProductPurchased;

		private static readonly int _pivotOffset;

		private static readonly int _mainColor;

		private Tween _screenSequence;

		private bool _visualsLoaded;

		private bool _hasProductData;

		private Texture _teamOneTexture;

		private Texture _teamTwoTexture;

		private Material _teamOneScreenMaterial;

		private Material _teamTwoScreenMaterial;

		private ShopSaleSkinProductDataDefinition _skinProductDataDefinition;

		private TeamNo _targetTeamToDisplay;

		public override void Initialize(ShopSaleProductDataDefinition productDataDefinition)
		{
		}

		public override void UpdateWardrobe()
		{
		}

		private void ShowSkinModels(bool hasPurchasedSkin)
		{
		}

		private void HandleOnButtonPressed(string buttonName)
		{
		}

		public override void SwitchVisualsForTeam(TeamNo currentTeamOnDisplay)
		{
		}

		private void OnDestroy()
		{
		}

		private void SwitchSkinByTeam(TeamNo currentTeamOnDisplay)
		{
		}

		private void SetScreenMaterial(TeamNo targetTeam)
		{
		}
	}
}
