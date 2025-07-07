using System;
using System.Runtime.InteropServices;
using Fusion;
using Moon.Arena;

namespace Moon.Hub
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 124)]
	[NetworkStructWeaved(31)]
	public struct HubGameSettings : INetworkStruct
	{
		[FieldOffset(0)]
		public NetworkString<_16> GameModeName;

		[FieldOffset(68)]
		public GameSettings GameSettings;

		[FieldOffset(120)]
		public GameModeModifier GameModeModifier;

		public static readonly HubGameSettings FreePlay;
	}
}
