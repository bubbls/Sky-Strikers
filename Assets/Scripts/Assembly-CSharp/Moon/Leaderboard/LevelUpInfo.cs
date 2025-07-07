using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Leaderboard
{
	[StructLayout((LayoutKind)2, Size = 12)]
	[NetworkStructWeaved(3)]
	public struct LevelUpInfo : INetworkStruct
	{
		[FieldOffset(0)]
		public bool IsLevelUp;

		[FieldOffset(4)]
		public int PreviousLevel;

		[FieldOffset(8)]
		public int CurrentLevel;
	}
}
