using System;
using System.Runtime.InteropServices;
using Fusion;
using Moon.Arena;
using Moon.Framework.Base;

namespace Moon.MultiPlay
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 372)]
	[NetworkStructWeaved(93)]
	public struct RankedPairMatchFoundNetworkData : INetworkStruct
	{
		[FieldOffset(0)]
		public NetworkString<_16> RoomName;

		[FieldOffset(68)]
		public NetworkString<_64> SessionId;

		[FieldOffset(328)]
		public FieldType FieldType;

		[FieldOffset(332)]
		public NetworkString<_8> TeamId;

		[FieldOffset(368)]
		public PlayFabRegion PlayFabRegion;
	}
}
