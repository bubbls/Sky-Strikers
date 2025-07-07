using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Moon.MultiPlay;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Moon_MultiPlay_RankedPairPlayersNetworkData : IElementReaderWriter<RankedPairPlayersNetworkData>
	{
		public static IElementReaderWriter<RankedPairPlayersNetworkData> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe RankedPairPlayersNetworkData Read(byte* data, int index)
		{
			return default(RankedPairPlayersNetworkData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref RankedPairPlayersNetworkData ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, RankedPairPlayersNetworkData val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<RankedPairPlayersNetworkData> GetInstance()
		{
			return null;
		}
	}
}
