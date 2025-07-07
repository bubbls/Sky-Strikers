using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 8)]
	[NetworkStructWeaved(2)]
	public struct PlayerVisualsSuitWeaponData : IPlayerVisualsObjectData<SuitWeaponVisualTheme>, INetworkStruct
	{
		[FieldOffset(0)]
		public SuitWeaponVisualTheme Theme;

		[FieldOffset(4)]
		public NetworkBool HasPriceTag;

		public PlayerVisualsSuitWeaponData(SuitWeaponVisualTheme theme)
		{
			Theme = default(SuitWeaponVisualTheme);
			HasPriceTag = default(NetworkBool);
		}

		public static PlayerVisualsSuitWeaponData CreateFromStringTheme(string theme, SuitWeaponVisualTheme fallback)
		{
			return default(PlayerVisualsSuitWeaponData);
		}

		public static PlayerVisualsSuitWeaponData DefaultStriker()
		{
			return default(PlayerVisualsSuitWeaponData);
		}

		public static PlayerVisualsSuitWeaponData CreateFromSuit(SuitVisualTheme skinTheme)
		{
			return default(PlayerVisualsSuitWeaponData);
		}

		public static PlayerVisualsSuitWeaponData DefaultWeaponFromSuit(SuitVisualTheme skinTheme)
		{
			return default(PlayerVisualsSuitWeaponData);
		}

		public static PlayerVisualsSuitWeaponData DefaultWeaponFromHeldWeaponTheme(SuitWeaponVisualTheme theme)
		{
			return default(PlayerVisualsSuitWeaponData);
		}
	}
}
