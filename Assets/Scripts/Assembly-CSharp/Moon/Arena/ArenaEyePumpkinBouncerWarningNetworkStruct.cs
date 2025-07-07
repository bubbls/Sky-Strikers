using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Arena
{
	[StructLayout((LayoutKind)2, Size = 8)]
	[NetworkStructWeaved(2)]
	public struct ArenaEyePumpkinBouncerWarningNetworkStruct : INetworkStruct
	{
		[FieldOffset(0)]
		public NetworkBool ShouldShowWarning;

		[FieldOffset(4)]
		public NetworkBool IsLastWarning;
	}
}
