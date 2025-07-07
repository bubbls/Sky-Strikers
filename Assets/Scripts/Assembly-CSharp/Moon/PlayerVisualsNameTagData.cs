using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 8)]
	[NetworkStructWeaved(2)]
	public struct PlayerVisualsNameTagData : IPlayerVisualsObjectData<NameTagVisualTheme>, INetworkStruct
	{
		[FieldOffset(0)]
		public NameTagVisualTheme Theme;

		[FieldOffset(4)]
		public NetworkBool HasPriceTag;

		public PlayerVisualsNameTagData(NameTagVisualTheme theme)
		{
			Theme = default(NameTagVisualTheme);
			HasPriceTag = default(NetworkBool);
		}

		public static PlayerVisualsNameTagData CreateFromStringTheme(string theme)
		{
			return default(PlayerVisualsNameTagData);
		}

		public static PlayerVisualsNameTagData Default()
		{
			return default(PlayerVisualsNameTagData);
		}

		public static PlayerVisualsNameTagData CreateFromSuit(SuitVisualTheme suitTheme)
		{
			return default(PlayerVisualsNameTagData);
		}
	}
}
