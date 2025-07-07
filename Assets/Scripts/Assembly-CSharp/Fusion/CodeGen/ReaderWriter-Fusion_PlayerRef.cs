using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Fusion_PlayerRef : IElementReaderWriter<PlayerRef>
	{
		public static IElementReaderWriter<PlayerRef> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe PlayerRef Read(byte* data, int index)
		{
			return default(PlayerRef);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref PlayerRef ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, PlayerRef val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<PlayerRef> GetInstance()
		{
			return null;
		}
	}
}
