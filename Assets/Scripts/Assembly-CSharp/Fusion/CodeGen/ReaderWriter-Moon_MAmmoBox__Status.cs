using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Moon;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Moon_MAmmoBox__Status : IElementReaderWriter<MAmmoBox.Status>
	{
		public static IElementReaderWriter<MAmmoBox.Status> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe MAmmoBox.Status Read(byte* data, int index)
		{
			return default(MAmmoBox.Status);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref MAmmoBox.Status ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, MAmmoBox.Status val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<MAmmoBox.Status> GetInstance()
		{
			return null;
		}
	}
}
