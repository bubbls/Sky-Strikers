using System;
using UnityEngine;

namespace Moon
{
	[Serializable]
	public class PlayerVisualsSkinPreset : IPlayerVisualsPreset
	{
		public PlayerVisualsSuitPartData Suit;

		[Space(10f)]
		public PlayerVisualsAvatarHeadData Head;

		public PlayerVisualsAvatarBodyData Body;

		public PlayerVisualsAvatarLegData Leg;

		public PlayerVisualsNameTagData NameTag;

		[Space(10f)]
		public PlayerVisualsSuitWeaponData IncludedSuitWeapon;

		[Space(10f)]
		public PlayerVisualsBackpackData IncludedBackpack;

		public static PlayerVisualsSkinPreset CreatePreset(SuitVisualTheme visualTheme)
		{
			return null;
		}

		public static PlayerVisualsSkinPreset CreateSuitAndWeaponPreset(PlayerVisualsSuitPartData suitPartData, PlayerVisualsSuitWeaponData suitWeaponData)
		{
			return null;
		}
	}
}
