using System.Runtime.InteropServices;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Arena
{
	[StructLayout((LayoutKind)2, Size = 136)]
	[NetworkStructWeaved(33)]
	public struct CollisionInfo : INetworkStruct
	{
		[FieldOffset(0)]
		public int CollidedObjectLayer;

		[FieldOffset(4)]
		public Vector3 CollisionRelativeVelocity;

		[FieldOffset(16)]
		public bool HitPlayerOwnedCollider;

		[FieldOffset(20)]
		public BallHitData BallHitData;

		[FieldOffset(128)]
		public SurfaceTagType SurfaceTagType;

		public static CollisionInfo GenerateCollisionInfo(Collision collision, BallHitData hitInfo, bool hitPlayerOwnedCollider)
		{
			return default(CollisionInfo);
		}
	}
}
