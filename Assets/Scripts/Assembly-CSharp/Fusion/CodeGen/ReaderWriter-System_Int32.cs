using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040System_Int32 : IElementReaderWriter<int>
	{
		public static IElementReaderWriter<int> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe int Read(byte* data, int index)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref int ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, int val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<int> GetInstance()
		{
			return null;
		}
	}
}
