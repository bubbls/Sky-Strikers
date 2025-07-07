using System;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public class ShopSaleAvatarBodyProductData : ShopSaleProductData
	{
		[SerializeField]
		private PlayerVisualsAvatarBodyPreset _avatarBodyVisualsPreset;

		public PlayerVisualsAvatarBodyPreset AvatarBodyPreset => null;

		public override bool CanEquip(PlayerInfo playerInfo)
		{
			return false;
		}

		public override bool TryEquip(PlayerInfo playerInfo, out PlayerInfo equipped)
		{
			equipped = default(PlayerInfo);
			return false;
		}
	}
}
