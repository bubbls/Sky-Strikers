using System;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public abstract class ShopSaleProductData : BaseItemData
	{
		[SerializeField]
		private GameObject? _predefinedDisplayPrefab;

		public GameObject? PredefinedDisplayPrefab => null;

		public bool IsMultiTeamProduct => false;

		public virtual bool TryEquip(PlayerInfo playerInfo, out PlayerInfo equipped)
		{
			equipped = default(PlayerInfo);
			return false;
		}

		public virtual bool CanEquip(PlayerInfo playerInfo)
		{
			return false;
		}
	}
}
