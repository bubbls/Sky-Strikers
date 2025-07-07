using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon
{
	[StructLayout((LayoutKind)2, Size = 60)]
	[NetworkStructWeaved(15)]
	public struct OverlapShapeDescData : INetworkStruct
	{
		[FieldOffset(0)]
		public Vector3 RelativePosition;

		[FieldOffset(12)]
		public Quaternion RelativeRotation;

		[FieldOffset(28)]
		public HitboxTypes Type;

		[FieldOffset(32)]
		public Vector3 Offset;

		[FieldOffset(44)]
		public float SphereRadius;

		[FieldOffset(48)]
		public Vector3 BoxExtents;
	}
}
