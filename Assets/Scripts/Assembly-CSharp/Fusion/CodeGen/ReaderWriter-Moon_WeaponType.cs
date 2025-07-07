using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Moon;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Moon_WeaponType : IElementReaderWriter<WeaponType>
	{
		public static IElementReaderWriter<WeaponType> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe WeaponType Read(byte* data, int index)
		{
			return default(WeaponType);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref WeaponType ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, WeaponType val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<WeaponType> GetInstance()
		{
			return null;
		}
	}
}
