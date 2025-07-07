using System;

namespace Moon.Arena
{
	[Flags]
	public enum BallTag
	{
		None = 0,
		Hit = 0x1000,
		Blasted = 0x2000,
		HitLimitByTeamReached = 0x4000
	}
}
