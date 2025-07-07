using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop
{
	[CreateAssetMenu(fileName = "AvatarLegProductDataDefinition", menuName = "Moon/Shop/Create Avatar Leg ProductDataDefinition")]
	public class ShopSaleAvatarLegProductDataDefinition : ShopSaleProductDataDefinition
	{
		public ShopSaleAvatarLegProductData AvatarLegProductData => null;

		protected override void CreateNewItemData()
		{
		}
	}
}
