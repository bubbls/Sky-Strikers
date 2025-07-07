using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Leaderboard
{
	[StructLayout((LayoutKind)2, Size = 48)]
	[NetworkStructWeaved(12)]
	public struct PlayerStatistics : INetworkStruct
	{
		[FieldOffset(0)]
		public int TotalSaves;

		[FieldOffset(4)]
		public int TotalAssists;

		[FieldOffset(8)]
		public int TotalGoalsScored;

		[FieldOffset(12)]
		public int TotalRocketsFired;

		[FieldOffset(16)]
		public int Xp;

		[FieldOffset(20)]
		public int Level;

		[FieldOffset(24)]
		public int TotalMatchesPlayed;

		[FieldOffset(28)]
		public int TotalWins;

		[FieldOffset(32)]
		public int ActivePoints;

		[FieldOffset(36)]
		public int Ranked_MMR;

		[FieldOffset(40)]
		public int Ranked_WinStreak;

		[FieldOffset(44)]
		public int Ranked_HighestWinStreak;

		public override string ToString()
		{
			return null;
		}
	}
}
