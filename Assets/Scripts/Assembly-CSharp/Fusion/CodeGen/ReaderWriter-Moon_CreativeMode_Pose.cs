using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Moon.CreativeMode;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Moon_CreativeMode_Pose : IElementReaderWriter<Pose>
	{
		public static IElementReaderWriter<Pose> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe Pose Read(byte* data, int index)
		{
			return default(Pose);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref Pose ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, Pose val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<Pose> GetInstance()
		{
			return null;
		}
	}
}
