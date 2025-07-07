using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 8)]
	[NetworkStructWeaved(2)]
	public struct PlayerVisualsAvatarLegData : IPlayerVisualsObjectData<AvatarBodyVisualTheme>, INetworkStruct
	{
		[FieldOffset(0)]
		public AvatarLegVisualTheme Theme;

		[FieldOffset(4)]
		public NetworkBool HasPriceTag;

		public PlayerVisualsAvatarLegData(AvatarLegVisualTheme theme)
		{
			Theme = default(AvatarLegVisualTheme);
			HasPriceTag = default(NetworkBool);
		}

		public static PlayerVisualsAvatarLegData CreateFromStringTheme(string theme)
		{
			return default(PlayerVisualsAvatarLegData);
		}

		public static PlayerVisualsAvatarLegData DefaultAvatar()
		{
			return default(PlayerVisualsAvatarLegData);
		}

		public static PlayerVisualsAvatarLegData TryCreateFromSuit(SuitVisualTheme theme)
		{
			return default(PlayerVisualsAvatarLegData);
		}
	}
}
