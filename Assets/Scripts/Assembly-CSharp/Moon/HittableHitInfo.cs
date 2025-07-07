using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon
{
	[StructLayout((LayoutKind)2, Size = 88)]
	[NetworkStructWeaved(22)]
	public struct HittableHitInfo : INetworkStruct
	{
		[FieldOffset(0)]
		public long HitId;

		[FieldOffset(8)]
		public PlayerRef Hitter;

		[FieldOffset(12)]
		public HitSourceID HitSourceID;

		[FieldOffset(16)]
		public Vector3 HitObjectPosition;

		[FieldOffset(28)]
		public Vector3 HitNormal;

		[FieldOffset(40)]
		public Vector3 HitPoint;

		[FieldOffset(52)]
		public Vector3 HitForce;

		[FieldOffset(64)]
		public Vector3 HitTorque;

		[FieldOffset(76)]
		public HitType HitType;

		[FieldOffset(80)]
		public float HitDistance;

		[FieldOffset(84)]
		public bool IsHitComplete;

		public void UpdateHitInfo(PlayerRef hitter, HitSourceID hitSourceID, Vector3 hitForce, Vector3 hitTorque, LagCompensatedHit lagCompensatedHit, Tick tick, bool isHitComplete = true)
		{
		}

		public static HittableHitInfo GenerateHitInfo(PlayerRef hitter, HitSourceID hitSourceID, Vector3 hitForce, Vector3 hitTorque, Vector3 hitPoint, bool isHitComplete = true)
		{
			return default(HittableHitInfo);
		}

		public void UpdateHitInfo(PlayerRef hitter, HitSourceID hitSourceID, Vector3 hitForce, Vector3 hitTorque, Vector3 hitPoint, HitType hitType, Tick tick, bool isHitComplete = true)
		{
		}

		public void UpdateHitInfo(PlayerRef hitter, HitSourceID hitSourceID, LagCompensatedHit lagCompensatedHit, Tick tick, bool isHitComplete = true)
		{
		}
	}
}
