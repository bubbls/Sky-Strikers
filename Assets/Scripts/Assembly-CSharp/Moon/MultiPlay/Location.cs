using System;

namespace Moon.MultiPlay
{
	[Flags]
	public enum Location : ushort
	{
		None = 0,
		Arena = 1,
		Hub = 2,
		ClassChangeRoom = 4,
		ArenaGoalTeamOne = 8,
		ArenaGoalTeamTwo = 0x10,
		ArenaShop = 0x20,
		Tutorial = 0x40,
		ArenaUnderground = 0x80,
		AbilityRestricted = 0x100,
		ShopPlayArea = 0x200,
		HubArena = 0x400,
		StatsTrackingArea = 0x800,
		HubArenaPlayArea = 0x1000
	}
}
