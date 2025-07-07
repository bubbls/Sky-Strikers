using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040UnityEngine_Vector3 : IElementReaderWriter<Vector3>
	{
		public static IElementReaderWriter<Vector3> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe Vector3 Read(byte* data, int index)
		{
			return default(Vector3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref Vector3 ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, Vector3 val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<Vector3> GetInstance()
		{
			return null;
		}
	}
}
