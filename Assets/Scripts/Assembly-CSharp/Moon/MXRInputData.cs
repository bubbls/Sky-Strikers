using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon
{
	[StructLayout((LayoutKind)2, Size = 216)]
	[NetworkInputWeaved(54)]
	public struct MXRInputData : INetworkInput
	{
		[FieldOffset(0)]
		public Vector3 HeadPosition;

		[FieldOffset(12)]
		public Quaternion HeadRotation;

		[FieldOffset(28)]
		public Vector3 BodyPosition;

		[FieldOffset(40)]
		public Quaternion BodyRotation;

		[FieldOffset(56)]
		public MXRControllerInputData Left;

		[FieldOffset(132)]
		public MXRControllerInputData Right;

		[FieldOffset(208)]
		public Vector2 CreationModeMoveOnEyeSightPlane;

		public void ResetInput()
		{
		}
	}
}
