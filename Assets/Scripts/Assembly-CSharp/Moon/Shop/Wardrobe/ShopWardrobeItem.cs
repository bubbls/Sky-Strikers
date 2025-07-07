using Moon.Arena;
using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop.Wardrobe
{
	public abstract class ShopWardrobeItem : MonoBehaviour
	{
		public abstract void Initialize(ShopSaleProductDataDefinition productDataDefinition);

		public abstract void UpdateWardrobe();

		public abstract void SwitchVisualsForTeam(TeamNo currentTeamOnDisplay);
	}
}
