using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 8)]
	[NetworkStructWeaved(2)]
	public struct PlayerVisualsAvatarBodyData : IPlayerVisualsObjectData<AvatarBodyVisualTheme>, INetworkStruct
	{
		[FieldOffset(0)]
		public AvatarBodyVisualTheme Theme;

		[FieldOffset(4)]
		public NetworkBool HasPriceTag;

		public PlayerVisualsAvatarBodyData(AvatarBodyVisualTheme theme)
		{
			Theme = default(AvatarBodyVisualTheme);
			HasPriceTag = default(NetworkBool);
		}

		public static PlayerVisualsAvatarBodyData CreateFromStringTheme(string theme)
		{
			return default(PlayerVisualsAvatarBodyData);
		}

		public static PlayerVisualsAvatarBodyData DefaultAvatar()
		{
			return default(PlayerVisualsAvatarBodyData);
		}

		public static PlayerVisualsAvatarBodyData TryCreateFromSuit(SuitVisualTheme theme)
		{
			return default(PlayerVisualsAvatarBodyData);
		}
	}
}
