using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Arena
{
	[StructLayout((LayoutKind)2, Size = 4)]
	[NetworkStructWeaved(1)]
	public struct TeamScore : INetworkStruct
	{
		[FieldOffset(0)]
		public int Goal;
	}
}
