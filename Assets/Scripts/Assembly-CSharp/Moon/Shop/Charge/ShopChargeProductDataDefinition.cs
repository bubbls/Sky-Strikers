using UnityEngine;

namespace Moon.Shop.Charge
{
	[CreateAssetMenu(fileName = "ShopChargeProductDataDefinition", menuName = "Moon/Shop/Create ShopChargeProductDataDefinition")]
	public class ShopChargeProductDataDefinition : ScriptableObject
	{
		[SerializeField]
		private ShopChargeProductData _chargeProductData;

		public ShopChargeProductData ChargeProductData => null;
	}
}
