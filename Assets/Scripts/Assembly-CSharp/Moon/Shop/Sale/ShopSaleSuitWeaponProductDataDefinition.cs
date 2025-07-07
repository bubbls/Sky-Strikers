using UnityEngine;

namespace Moon.Shop.Sale
{
	[CreateAssetMenu(fileName = "SuitWeaponProductDataDefinition", menuName = "Moon/Shop/Create Suit Weapon ProductDataDefinition")]
	public class ShopSaleSuitWeaponProductDataDefinition : ShopSaleProductDataDefinition
	{
		public ShopSaleSuitWeaponProductData SuitWeaponProductData => null;

		protected override void CreateNewItemData()
		{
		}
	}
}
