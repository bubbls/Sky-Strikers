using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop
{
	[CreateAssetMenu(fileName = "BackpackProductDataDefinition", menuName = "Moon/Shop/Create Backack ProductDataDefinition")]
	public class ShopSaleBackpackProductDataDefinition : ShopSaleProductDataDefinition
	{
		public ShopSaleBackpackProductData BackpackProductData => null;
	}
}
