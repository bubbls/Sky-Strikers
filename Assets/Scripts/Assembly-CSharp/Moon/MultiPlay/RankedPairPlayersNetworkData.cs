using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon.MultiPlay
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 564)]
	[NetworkStructWeaved(141)]
	public struct RankedPairPlayersNetworkData : INetworkStruct
	{
		[FieldOffset(0)]
		public int Index;

		[FieldOffset(4)]
		public RankedPairState PartyState;

		[FieldOffset(8)]
		public RankedPairMatchmakingPlayerNetworkData Creator;

		[FieldOffset(284)]
		public RankedPairMatchmakingPlayerNetworkData Joiner;

		[FieldOffset(560)]
		public TickTimer CooldownTimer;
	}
}
