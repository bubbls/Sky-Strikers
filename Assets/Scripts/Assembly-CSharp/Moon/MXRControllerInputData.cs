using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon
{
	[StructLayout((LayoutKind)2, Size = 76)]
	[NetworkStructWeaved(19)]
	public struct MXRControllerInputData : INetworkStruct
	{
		[FieldOffset(0)]
		public Vector3 Position;

		[FieldOffset(12)]
		public Quaternion Rotation;

		[FieldOffset(28)]
		public Vector3 ControllerPosition;

		[FieldOffset(40)]
		public Vector3 ControllerVelocity;

		[FieldOffset(52)]
		public MXRInputAction InputAction;

		[FieldOffset(56)]
		public float FingerThumb;

		[FieldOffset(60)]
		public float FingerIndex;

		[FieldOffset(64)]
		public float FingerOthers;

		[FieldOffset(68)]
		public Vector2 Joystick;

		public void Reset()
		{
		}
	}
}
