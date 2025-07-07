using System.Collections.Generic;
using UnityEngine;

namespace Moon.Shop.Charge
{
	[CreateAssetMenu(fileName = "ShopChargeScreenDataDefinitionManager", menuName = "Moon/Shop/Create ShopChargeScreenDataDefinitionManager")]
	public class ShopChargeScreenDataDefinitionManager : ScriptableObject
	{
		[SerializeField]
		private List<ShopChargeScreenDataDefinition> _chargeScreenDataDefinitionList;

		public List<ShopChargeScreenDataDefinition> ChargeScreenDataDefinitionList => null;
	}
}
