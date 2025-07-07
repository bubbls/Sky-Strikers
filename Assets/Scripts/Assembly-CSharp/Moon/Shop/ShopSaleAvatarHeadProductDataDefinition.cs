using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop
{
	[CreateAssetMenu(fileName = "AvatarHeadProductDataDefinition", menuName = "Moon/Shop/Create Avatar Head ProductDataDefinition")]
	public class ShopSaleAvatarHeadProductDataDefinition : ShopSaleProductDataDefinition
	{
		public ShopSaleAvatarHeadProductData AvatarHeadProductData => null;

		protected override void CreateNewItemData()
		{
		}
	}
}
