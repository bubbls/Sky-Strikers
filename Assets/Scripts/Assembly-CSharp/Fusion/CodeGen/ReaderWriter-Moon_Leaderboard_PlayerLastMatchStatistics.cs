using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Moon.Leaderboard;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Moon_Leaderboard_PlayerLastMatchStatistics : IElementReaderWriter<PlayerLastMatchStatistics>
	{
		public static IElementReaderWriter<PlayerLastMatchStatistics> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe PlayerLastMatchStatistics Read(byte* data, int index)
		{
			return default(PlayerLastMatchStatistics);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref PlayerLastMatchStatistics ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, PlayerLastMatchStatistics val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<PlayerLastMatchStatistics> GetInstance()
		{
			return null;
		}
	}
}
