using System.Runtime.InteropServices;
using Fusion;
using Moon.Arena;

namespace Moon.Leaderboard
{
	[StructLayout((LayoutKind)2, Size = 316)]
	[NetworkStructWeaved(79)]
	public struct PlayerLastMatchStatistics : INetworkStruct
	{
		[FieldOffset(0)]
		public NetworkString<_16> PlayFabId;

		[FieldOffset(68)]
		public NetworkString<_32> PlayerName;

		[FieldOffset(200)]
		public TeamNo TeamNo;

		[FieldOffset(204)]
		public PlayerVisualsConfig VisualsConfig;

		[FieldOffset(260)]
		public int Rating;

		[FieldOffset(264)]
		public bool IsMvp;

		[FieldOffset(268)]
		public int NGoals;

		[FieldOffset(272)]
		public int NAssists;

		[FieldOffset(276)]
		public int NSaves;

		[FieldOffset(280)]
		public int NShots;

		[FieldOffset(284)]
		public int Clears;

		[FieldOffset(288)]
		public float PlayerPossession;

		[FieldOffset(292)]
		public int MMR;

		[FieldOffset(296)]
		public int NewMMR;

		[FieldOffset(300)]
		public int WinStreakMMR;

		[FieldOffset(304)]
		public int UnderdogMMR;

		[FieldOffset(308)]
		public bool IsPlayerForfeit;

		[FieldOffset(312)]
		public bool IsUnderdog;
	}
}
