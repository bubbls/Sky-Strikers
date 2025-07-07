using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Leaderboard
{
	[StructLayout((LayoutKind)2, Size = 184)]
	[NetworkStructWeaved(46)]
	public struct PlayerRankedStatistics : INetworkStruct
	{
		[FieldOffset(0)]
		public int PlayedMatches;

		[FieldOffset(4)]
		public int TotalRatings;

		[FieldOffset(8)]
		public int MVPs;

		[FieldOffset(12)]
		public int TotalWins;

		[FieldOffset(16)]
		public int TotalLoses;

		[FieldOffset(20)]
		public int TotalGoals;

		[FieldOffset(24)]
		public int TotalShots;

		[FieldOffset(28)]
		public int TotalTargetShots;

		[FieldOffset(32)]
		public int TotalSaves;

		[FieldOffset(36)]
		public int TotalAssists;

		[FieldOffset(40)]
		public int TotalClears;

		[FieldOffset(44)]
		public int TotalDistance;

		[FieldOffset(48)]
		public int TotalPlayTime;

		[FieldOffset(52)]
		public int RealTotalPlayTime;

		[FieldOffset(56)]
		public int TotalAllPlayersPossessionTime;

		[FieldOffset(60)]
		public int SmallEnergyCollectedCount;

		[FieldOffset(64)]
		public int MiddleEnergyCollectedCount;

		[FieldOffset(68)]
		public int BigEnergyCollectedCount;

		[FieldOffset(72)]
		public int EnergyCollectCount;

		[FieldOffset(76)]
		public int EnergyCollectFromOpponent;

		[FieldOffset(80)]
		public int EnergyConsumedCount;

		[FieldOffset(84)]
		public int TotalWinScoreDiff;

		[FieldOffset(88)]
		public int TotalLoseScoreDiff;

		[FieldOffset(92)]
		public int TotalPossession;

		[FieldOffset(96)]
		public int OnGroundTime;

		[FieldOffset(100)]
		public int LowAirTime;

		[FieldOffset(104)]
		public int HighAirTime;

		[FieldOffset(108)]
		public int InDefensiveThirdTime;

		[FieldOffset(112)]
		public int InMiddleThirdTime;

		[FieldOffset(116)]
		public int InOffensiveThirdTime;

		[FieldOffset(120)]
		public int TotalMostBackTime;

		[FieldOffset(124)]
		public int TotalMostForwardTime;

		[FieldOffset(128)]
		public int DisplaceDone;

		[FieldOffset(132)]
		public int DisplaceReceived;

		[FieldOffset(136)]
		public int AVGDistBall;

		[FieldOffset(140)]
		public int AVGDistBallPossession;

		[FieldOffset(144)]
		public int AVGDistBallNoPossession;

		[FieldOffset(148)]
		public int AVGDistTeam;

		[FieldOffset(152)]
		public int DistRecordCnt;

		[FieldOffset(156)]
		public int TimeClosestBall;

		[FieldOffset(160)]
		public int TimeFarthestBall;

		[FieldOffset(164)]
		public int TimeBehindBall;

		[FieldOffset(168)]
		public int TimeFrontBall;

		[FieldOffset(172)]
		public int NHatTricks;

		[FieldOffset(176)]
		public int NShutouts;

		[FieldOffset(180)]
		public ushort Champion01Goals;

		public float WinRatio => 0f;

		public float AVGRating => 0f;

		public float AVGShots => 0f;

		public float AVGGoals => 0f;

		public float AVGAssists => 0f;

		public float AVGSaves => 0f;

		public float AVGWinScoreDiff => 0f;

		public float AVGLoseScoreDiff => 0f;

		public float AVGPrecision => 0f;

		public float AVGPlayerPossession => 0f;

		public float AVG_EPM => 0f;

		public int TotalEnergyCollectCount => 0;

		public int TotalEnergyConsumedCount => 0;

		public float AVG_ECPM => 0f;

		public float AVG_EStolen => 0f;

		public int TotalEStolen => 0;

		public float AVG_ESmall => 0f;

		public float AVG_EMid => 0f;

		public float AVG_EBig => 0f;

		public float AVGSpeed => 0f;

		public float AVGDistanceTraveled => 0f;

		public float AVGTimeOnGround => 0f;

		public float AVGTimeLowAir => 0f;

		public float AVGTimeHighAir => 0f;

		public float OnGroundPercentage => 0f;

		public float LowAirPercentage => 0f;

		public float HighAirPercentage => 0f;

		public float InDefensiveThird => 0f;

		public float InMiddleThird => 0f;

		public float InOffensiveThird => 0f;

		public float MostBackPercentage => 0f;

		public float MostForwardPercentage => 0f;

		public float AVGTimeBehindBallPercentage => 0f;

		public float AVGTimeFrontBallPercentage => 0f;

		public float TimeClosestBallPercentage => 0f;

		public float TimeFarthestBallPercentage => 0f;

		public float AVGTimeDisplaceDone => 0f;

		public float AVGTimeDisplaceReceived => 0f;

		public float EnergyEfficiency => 0f;

		public float AVGClears => 0f;
	}
}
