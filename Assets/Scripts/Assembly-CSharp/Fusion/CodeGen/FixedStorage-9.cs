using System;
using System.Runtime.InteropServices;

namespace Fusion.CodeGen
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[NetworkStructWeaved(9)]
	internal struct FixedStorage_00409 : INetworkStruct
	{
		[FieldOffset(0)]
		public unsafe fixed int Data[9];

		[FieldOffset(4)]
		[NonSerialized]
		private int _1;

		[FieldOffset(8)]
		[NonSerialized]
		private int _2;

		[FieldOffset(12)]
		[NonSerialized]
		private int _3;

		[FieldOffset(16)]
		[NonSerialized]
		private int _4;

		[FieldOffset(20)]
		[NonSerialized]
		private int _5;

		[FieldOffset(24)]
		[NonSerialized]
		private int _6;

		[FieldOffset(28)]
		[NonSerialized]
		private int _7;

		[FieldOffset(32)]
		[NonSerialized]
		private int _8;
	}
}
