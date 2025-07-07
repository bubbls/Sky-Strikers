using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 8)]
	[NetworkStructWeaved(2)]
	public struct PlayerVisualsBackpackData : IPlayerVisualsObjectData<BackpackVisualTheme>, INetworkStruct
	{
		[FieldOffset(0)]
		public BackpackVisualTheme Theme;

		[FieldOffset(4)]
		public NetworkBool HasPriceTag;

		public PlayerVisualsBackpackData(BackpackVisualTheme theme)
		{
			Theme = default(BackpackVisualTheme);
			HasPriceTag = default(NetworkBool);
		}

		public static PlayerVisualsBackpackData CreateFromStringTheme(string theme)
		{
			return default(PlayerVisualsBackpackData);
		}

		public static PlayerVisualsBackpackData Default()
		{
			return default(PlayerVisualsBackpackData);
		}

		public static PlayerVisualsBackpackData CreateFromSuit(SuitVisualTheme suitTheme)
		{
			return default(PlayerVisualsBackpackData);
		}
	}
}
