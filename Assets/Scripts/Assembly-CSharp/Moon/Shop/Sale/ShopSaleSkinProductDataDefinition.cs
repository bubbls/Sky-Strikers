using UnityEngine;

namespace Moon.Shop.Sale
{
	[CreateAssetMenu(fileName = "SkinProductDataDefinition", menuName = "Moon/Shop/Create Skin ProductDataDefinition")]
	public class ShopSaleSkinProductDataDefinition : ShopSaleProductDataDefinition
	{
		public ShopSaleSkinProductData SkinProductData => null;

		protected override void CreateNewItemData()
		{
		}
	}
}
