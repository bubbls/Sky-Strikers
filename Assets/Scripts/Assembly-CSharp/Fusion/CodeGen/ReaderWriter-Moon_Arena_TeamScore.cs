using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Moon.Arena;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Moon_Arena_TeamScore : IElementReaderWriter<TeamScore>
	{
		public static IElementReaderWriter<TeamScore> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe TeamScore Read(byte* data, int index)
		{
			return default(TeamScore);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref TeamScore ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, TeamScore val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<TeamScore> GetInstance()
		{
			return null;
		}
	}
}
