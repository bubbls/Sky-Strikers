using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon.MultiPlay
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 280)]
	[NetworkStructWeaved(70)]
	public struct RankedPairMatchmakingSlotNetworkData : INetworkStruct
	{
		[FieldOffset(0)]
		public NetworkBool HasPlayer;

		[FieldOffset(4)]
		public RankedPairMatchmakingPlayerNetworkData Player;
	}
}
