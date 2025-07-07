using System.Runtime.InteropServices;
using Fusion;

namespace Moon.MultiPlay
{
	[StructLayout((LayoutKind)2, Size = 4)]
	[NetworkStructWeaved(1)]
	public struct UnreliableInventory : INetworkStruct
	{
		[FieldOffset(0)]
		public int SipletsAmount;
	}
}
