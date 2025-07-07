using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon.MultiPlay
{
	[StructLayout((LayoutKind)2, Size = 112)]
	[NetworkStructWeaved(27)]
	public struct BallHitData : INetworkStruct
	{
		[FieldOffset(0)]
		public double LastServerHitTime;

		[FieldOffset(8)]
		public Vector3 LastAppliedForce;

		[FieldOffset(20)]
		public HittableHitInfo HitInfo;

		public BallHitData Reset(HittableHitInfo hitInfo, double time)
		{
			return default(BallHitData);
		}
	}
}
