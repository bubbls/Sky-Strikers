using System;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Shop
{
	[Serializable]
	public class ShopSaleAvatarLegProductData : ShopSaleProductData
	{
		[SerializeField]
		private PlayerVisualsAvatarLegPreset _avatarLegVisualsPreset;

		public PlayerVisualsAvatarLegPreset AvatarLegPreset => null;

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
