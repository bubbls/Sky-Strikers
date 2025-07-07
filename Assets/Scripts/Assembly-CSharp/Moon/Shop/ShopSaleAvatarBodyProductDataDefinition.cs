using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop
{
	[CreateAssetMenu(fileName = "AvatarBodyProductDataDefinition", menuName = "Moon/Shop/Create Avatar Body ProductDataDefinition")]
	public class ShopSaleAvatarBodyProductDataDefinition : ShopSaleProductDataDefinition
	{
		public ShopSaleAvatarBodyProductData AvatarBodyProductData => null;

		protected override void CreateNewItemData()
		{
		}
	}
}
