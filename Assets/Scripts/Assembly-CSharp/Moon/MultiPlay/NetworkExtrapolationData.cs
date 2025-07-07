using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon.MultiPlay
{
	[StructLayout((LayoutKind)2, Size = 60)]
	[NetworkStructWeaved(15)]
	public struct NetworkExtrapolationData : INetworkStruct
	{
		[FieldOffset(0)]
		public Vector3 Position;

		[FieldOffset(12)]
		public Quaternion Rotation;

		[FieldOffset(28)]
		public Vector3 Velocity;

		[FieldOffset(40)]
		public Vector3 AnglerVelocity;

		[FieldOffset(52)]
		public float Speed;

		[FieldOffset(56)]
		public float AnglerSpeed;
	}
}
