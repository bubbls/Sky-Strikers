using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon.PlayerProfile
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 4)]
	[NetworkStructWeaved(1)]
	public struct PlayerGoalInfo : INetworkStruct
	{
		[FieldOffset(0)]
		public int GoalTime;

		public PlayerGoalInfo(int goalTime)
		{
			GoalTime = 0;
		}
	}
}
