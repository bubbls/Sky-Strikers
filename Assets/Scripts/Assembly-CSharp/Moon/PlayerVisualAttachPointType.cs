using System;

namespace Moon
{
	[Flags]
	public enum PlayerVisualAttachPointType
	{
		None = 0,
		PlayerHeadContainer = 1,
		PlayerBodyContainer = 2,
		PlayerLegContainer = 4,
		PlayerSuitContainer = 8,
		PlayerLeftHandContainer = 0x10,
		PlayerRightHandContainer = 0x20,
		PlayerBackpackContainer = 0x40,
		DisplayArea = 0x80,
		PlayerNameTagContainer = 0x100,
		PlayerContainer = 0x17F
	}
}
