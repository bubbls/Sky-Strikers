using System.Runtime.InteropServices;
using Fusion;
using Fusion.CodeGen;
using UnityEngine;

namespace Moon.GameActivity
{
	[StructLayout((LayoutKind)2, Size = 44)]
	[NetworkStructWeaved(11)]
	public struct SipletsTrail : INetworkStruct
	{
		[FieldOffset(0)]
		[SerializeField]
		[FixedBufferProperty(typeof(NetworkArray<Vector3>), typeof(UnityArraySurrogate_0040ReaderWriter_0040UnityEngine_Vector3), 3, order = -2147483647)]
		private FixedStorage_00409 _EmitPositions;

		[FieldOffset(36)]
		public int EmitPositionCount;

		[FieldOffset(40)]
		public int Amount;

		[Capacity(3)]
		[Networked]
		public readonly NetworkArray<Vector3> EmitPositions => default(NetworkArray<Vector3>);

		public void SetEmitPosition(int index, Vector3 position)
		{
		}

		public Vector3 GetEmitPosition(int index)
		{
			return default(Vector3);
		}
	}
}
