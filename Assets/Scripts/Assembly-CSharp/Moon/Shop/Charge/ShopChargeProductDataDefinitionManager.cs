using System.Collections.Generic;
using UnityEngine;

namespace Moon.Shop.Charge
{
	[CreateAssetMenu(fileName = "ShopChargeProductDataDefinitionManager", menuName = "Moon/Shop/Create ShopChargeProductDataDefinitionManager")]
	public class ShopChargeProductDataDefinitionManager : ScriptableObject
	{
		[SerializeField]
		private List<ShopChargeProductDataDefinition> _chargeProductDataDefinitionList;

		public List<ShopChargeProductDataDefinition> ChargeProductDataDefinitionList => null;
	}
}
