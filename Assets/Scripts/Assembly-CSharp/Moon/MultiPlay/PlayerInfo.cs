using System.Runtime.InteropServices;
using Fusion;
using Moon.Arena;
using Moon.Leaderboard;
using Moon.MultiPlay.Aoi;

namespace Moon.MultiPlay
{
	[StructLayout((LayoutKind)2, Size = 308)]
	[NetworkStructWeaved(77)]
	public struct PlayerInfo : INetworkStruct
	{
		[FieldOffset(0)]
		public TeamNo TeamNo;

		[FieldOffset(4)]
		public int PlayerNo;

		[FieldOffset(8)]
		public PlayerVisualsConfig VisualsConfig;

		[FieldOffset(64)]
		public NetworkString<_32> PlayerName;

		[FieldOffset(196)]
		public NetworkBool IsGameMaster;

		[FieldOffset(200)]
		public NetworkString<_16> PlayFabId;

		[FieldOffset(268)]
		public Location Location;

		[FieldOffset(272)]
		public FlagFrameConfiguration FlagFrameConfiguration;

		[FieldOffset(300)]
		public NetworkVisionFlag VisionFlag;

		[FieldOffset(304)]
		public UnreliableInventory UnreliableInventory;
	}
}
