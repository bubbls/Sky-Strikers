using System.Runtime.InteropServices;
using Fusion;
using UnityEngine;

namespace Moon.MultiPlay
{
	[StructLayout((LayoutKind)2, Size = 16)]
	[NetworkInputWeaved(4)]
	public struct PlayerHandInputData : INetworkInput
	{
		[FieldOffset(0)]
		public int Tick;

		[FieldOffset(4)]
		public Vector3 TrackedHandVelocity;

		public void Reset()
		{
		}
	}
}
