using System;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public class ShopSaleAvatarHeadProductData : ShopSaleProductData
	{
		[SerializeField]
		private PlayerVisualsAvatarHeadPreset _avatarHeadVisualsPreset;

		public PlayerVisualsAvatarHeadPreset AvatarHeadPreset => null;

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
