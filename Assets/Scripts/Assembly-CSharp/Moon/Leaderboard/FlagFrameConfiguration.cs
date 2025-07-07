using System;
using System.Runtime.InteropServices;
using Fusion;
using Moon.GameActivity;

namespace Moon.Leaderboard
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 28)]
	[NetworkStructWeaved(7)]
	public struct FlagFrameConfiguration : INetworkStruct
	{
		[FieldOffset(0)]
		public FlagFrameTheme StatsFrame;

		[FieldOffset(4)]
		public FlagFrameTheme PortraitFrame;

		[FieldOffset(8)]
		public FlagFrameTheme PlayerNameBoard;

		[FieldOffset(12)]
		public FlagFrameTheme Medal01;

		[FieldOffset(16)]
		public FlagFrameTheme Medal02;

		[FieldOffset(20)]
		public FlagFrameTheme Medal03;

		[FieldOffset(24)]
		public FlagFrameTheme Bg;
	}
}
