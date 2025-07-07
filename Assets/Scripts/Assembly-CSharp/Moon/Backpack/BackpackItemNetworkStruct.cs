using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Backpack
{
	[StructLayout((LayoutKind)2, Size = 396)]
	[NetworkStructWeaved(99)]
	public struct BackpackItemNetworkStruct : INetworkStruct
	{
		[FieldOffset(0)]
		public NetworkString<_64> FriendlyId;

		[FieldOffset(260)]
		public NetworkString<_32> StackId;

		[FieldOffset(392)]
		public int Amount;
	}
}
