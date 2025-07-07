using System;

namespace Moon
{
	[Flags]
	public enum MXRInputAction : byte
	{
		None = 0,
		Grab = 1,
		Drop = 2,
		Squeeze = 4,
		Unsqueeze = 8,
		TurnLeft = 0x10,
		TurnRight = 0x20
	}
}
