using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using Moon.Shop.Sale;
using UnityEngine;

namespace Moon.Shop.Wardrobe
{
	[Obsolete]
	public class ShopWardrobe : MonoBehaviour
	{
		[SerializeField]
		private ShopSaleSkinProductDataDefinition[] _skinProductDataDefinitions;

		[SerializeField]
		private ShopSaleSuitWeaponProductDataDefinition[] _batProductDataDefinitions;

		private List<ShopWardrobeItem> _shopWardrobeItems;

		private ShopWardrobeSkin[] _shopWardrobeSkins;

		private ShopWardrobeBat[] _shopWardrobeBats;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private TeamNo _currentTeamOnDisplay;

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void InitializeWardrobeItems<T1, T2>(ref T1[] items, in IList<T2> productDataDefinitions) where T1 : ShopWardrobeItem where T2 : ShopSaleProductDataDefinition
		{
		}

		private int HandleOnPlayerInventoryUpdated(IMessage<object> message)
		{
			return 0;
		}

		private void SwitchVisualsForTeam()
		{
		}
	}
}
