using System;

namespace Moon
{
	[Flags]
	public enum HitSourceID
	{
		None = 0,
		PlayerHead = 1,
		PlayerBody = 2,
		PlayerHand = 4,
		PlayerBat = 8,
		Explosion = 0x20,
		JetstreamSuckerMove = 0x40,
		JetstreamSuckerBlast = 0x80,
		JetstreamBallController = 0x100,
		BulwarpTeleport = 0x200,
		BulwarpPaddle = 0x400,
		BulwarpShield = 0x800,
		PlayerBodyPart = 7,
		PlayerHeldWeapon = 0xA48,
		PlayerSuitPart = 0x400,
		PhysicalWeapon = 0x40C
	}
}
