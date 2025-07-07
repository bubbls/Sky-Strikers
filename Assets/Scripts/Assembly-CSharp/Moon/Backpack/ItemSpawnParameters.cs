using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon.Backpack
{
	[StructLayout((LayoutKind)2, Size = 28)]
	[NetworkStructWeaved(7)]
	public struct ItemSpawnParameters : INetworkStruct
	{
		[FieldOffset(0)]
		public Vector3 Position;

		[FieldOffset(12)]
		public Quaternion Rotation;
	}
}
