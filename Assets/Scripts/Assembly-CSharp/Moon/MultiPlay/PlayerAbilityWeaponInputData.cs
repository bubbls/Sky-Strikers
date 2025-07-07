using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon.MultiPlay
{
	[StructLayout((LayoutKind)2, Size = 96)]
	[NetworkInputWeaved(24)]
	public struct PlayerAbilityWeaponInputData : INetworkInput
	{
		[FieldOffset(0)]
		public Vector3 TrackedWeaponVelocity;

		[FieldOffset(12)]
		public Vector3 PrimeLeftMuzzlePointPosition;

		[FieldOffset(24)]
		public Quaternion PrimeLeftMuzzlePointRotation;

		[FieldOffset(40)]
		public Vector3 PrimeRightMuzzlePointPosition;

		[FieldOffset(52)]
		public Quaternion PrimeRightMuzzlePointRotation;

		[FieldOffset(68)]
		public Vector3 JetstreamSuckerCenterPointPosition;

		[FieldOffset(80)]
		public Quaternion JetstreamSuckerCenterPointRotation;

		public void Reset()
		{
		}
	}
}
