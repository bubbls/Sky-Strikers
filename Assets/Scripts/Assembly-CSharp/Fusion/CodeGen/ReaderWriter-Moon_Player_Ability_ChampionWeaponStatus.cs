using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Moon.Player.Ability;

namespace Fusion.CodeGen
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct ReaderWriter_0040Moon_Player_Ability_ChampionWeaponStatus : IElementReaderWriter<ChampionWeaponStatus>
	{
		public static IElementReaderWriter<ChampionWeaponStatus> Instance;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ChampionWeaponStatus Read(byte* data, int index)
		{
			return default(ChampionWeaponStatus);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe ref ChampionWeaponStatus ReadRef(byte* data, int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe void Write(byte* data, int index, ChampionWeaponStatus val)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetElementWordCount()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IElementReaderWriter<ChampionWeaponStatus> GetInstance()
		{
			return null;
		}
	}
}
