using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Player.Ability
{
	[StructLayout((LayoutKind)2, Size = 16)]
	[NetworkStructWeaved(4)]
	public struct ChampionWeaponStatus : INetworkStruct
	{
		[FieldOffset(0)]
		public ushort MMR;

		[FieldOffset(4)]
		public ushort TotalGoals;

		[FieldOffset(8)]
		public byte MatchGoals;

		[FieldOffset(12)]
		public NetworkBool IsWeaponFxActive;
	}
}
