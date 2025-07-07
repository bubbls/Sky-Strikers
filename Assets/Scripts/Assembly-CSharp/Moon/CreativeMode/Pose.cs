using System;
using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon.CreativeMode
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 40)]
	[NetworkStructWeaved(10)]
	public struct Pose : INetworkStruct
	{
		[FieldOffset(0)]
		public Vector3 Position;

		[FieldOffset(12)]
		public Quaternion Rotation;

		[FieldOffset(28)]
		public Vector3 LocalScale;
	}
}
