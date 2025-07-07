using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Fusion_SceneRef : IElementReaderWriter<SceneRef>
	{
		public static IElementReaderWriter<SceneRef> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe SceneRef Read(byte* data, int index)
		{
			return default(SceneRef);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref SceneRef ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, SceneRef val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<SceneRef> GetInstance()
		{
			return null;
		}
	}
}
