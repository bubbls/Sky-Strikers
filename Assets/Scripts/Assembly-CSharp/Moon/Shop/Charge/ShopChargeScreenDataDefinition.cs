using UnityEngine;

namespace Moon.Shop.Charge
{
	[CreateAssetMenu(fileName = "ShopChargeScreenDataDefinition", menuName = "Moon/Shop/Create ShopChargeScreenDataDefinition")]
	public class ShopChargeScreenDataDefinition : ScriptableObject
	{
		[SerializeField]
		private ShopChargeScreenData _chargeScreenData;

		public ShopChargeScreenData ChargeScreenData => null;
	}
}
