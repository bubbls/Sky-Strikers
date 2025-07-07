using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon.MultiPlay
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 276)]
	[NetworkStructWeaved(69)]
	public struct RankedPairMatchmakingPlayerNetworkData : INetworkStruct
	{
		[FieldOffset(0)]
		public PlayerRef PlayerRef;

		[FieldOffset(4)]
		public NetworkString<_16> MultiPlayEntityId;

		[FieldOffset(72)]
		public NetworkString<_16> PlayFabId;

		[FieldOffset(140)]
		public NetworkString<_32> PlayerName;

		[FieldOffset(272)]
		public int PlayerRankMMR;
	}
}
