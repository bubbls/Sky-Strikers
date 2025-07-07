using System;

namespace Moon.GameActivity.Behaviors
{
	[Flags]
	public enum PlayerParts : byte
	{
		None = 0,
		LeftHand = 1,
		RightHand = 2,
		Head = 4,
		Body = 8
	}
}
