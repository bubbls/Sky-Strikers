using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 8)]
	[NetworkStructWeaved(2)]
	public struct PlayerVisualsSuitPartData : IPlayerVisualsObjectData<SuitVisualTheme>, INetworkStruct
	{
		[FieldOffset(0)]
		public SuitVisualTheme Theme;

		[FieldOffset(4)]
		public NetworkBool HasPriceTag;

		public PlayerVisualsSuitPartData(SuitVisualTheme theme)
		{
			Theme = default(SuitVisualTheme);
			HasPriceTag = default(NetworkBool);
		}

		public static PlayerVisualsSuitPartData CreateFromStringTheme(string theme, SuitVisualTheme fallback)
		{
			return default(PlayerVisualsSuitPartData);
		}

		public static PlayerVisualsSuitPartData DefaultStriker()
		{
			return default(PlayerVisualsSuitPartData);
		}

		public static PlayerVisualsSuitPartData DefaultFromTheme(SuitVisualTheme theme)
		{
			return default(PlayerVisualsSuitPartData);
		}
	}
}
