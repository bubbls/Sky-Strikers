using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 8)]
	[NetworkStructWeaved(2)]
	public struct PlayerVisualsAvatarHeadData : IPlayerVisualsObjectData<AvatarHeadVisualTheme>, INetworkStruct
	{
		[FieldOffset(0)]
		public AvatarHeadVisualTheme Theme;

		[FieldOffset(4)]
		public NetworkBool HasPriceTag;

		public PlayerVisualsAvatarHeadData(AvatarHeadVisualTheme theme)
		{
			Theme = default(AvatarHeadVisualTheme);
			HasPriceTag = default(NetworkBool);
		}

		public static PlayerVisualsAvatarHeadData CreateFromStringTheme(string theme)
		{
			return default(PlayerVisualsAvatarHeadData);
		}

		public static PlayerVisualsAvatarHeadData DefaultAvatar()
		{
			return default(PlayerVisualsAvatarHeadData);
		}

		public static PlayerVisualsAvatarHeadData TryCreateFromSuit(SuitVisualTheme theme)
		{
			return default(PlayerVisualsAvatarHeadData);
		}
	}
}
