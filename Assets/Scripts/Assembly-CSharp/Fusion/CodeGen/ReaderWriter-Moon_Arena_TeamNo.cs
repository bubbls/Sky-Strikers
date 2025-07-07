using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Moon.Arena;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Moon_Arena_TeamNo : IElementReaderWriter<TeamNo>
	{
		public static IElementReaderWriter<TeamNo> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe TeamNo Read(byte* data, int index)
		{
			return default(TeamNo);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref TeamNo ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, TeamNo val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<TeamNo> GetInstance()
		{
			return null;
		}
	}
}
