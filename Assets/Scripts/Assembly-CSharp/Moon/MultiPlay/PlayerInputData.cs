using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon.MultiPlay
{
	[StructLayout((LayoutKind)2, Size = 388)]
	[NetworkInputWeaved(97)]
	public struct PlayerInputData : INetworkInput
	{
		[FieldOffset(0)]
		public MXRInputData XRInputData;

		[FieldOffset(216)]
		public Vector3 PlayerPosition;

		[FieldOffset(228)]
		public Vector3 PlayerVelocity;

		[FieldOffset(240)]
		public Quaternion PlayerRotation;

		[FieldOffset(256)]
		public PlayerHandInputData Left;

		[FieldOffset(272)]
		public PlayerHandInputData Right;

		[FieldOffset(288)]
		public PlayerAbilityWeaponInputData AbilityWeaponData;

		[FieldOffset(384)]
		public bool WeaponSwitcheroo;

		public void Reset()
		{
		}
	}
}
