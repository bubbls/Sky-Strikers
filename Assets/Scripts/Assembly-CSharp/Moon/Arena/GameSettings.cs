using System;
using System.Runtime.InteropServices;
using Fusion;

namespace Moon.Arena
{
	[Serializable]
	[StructLayout((LayoutKind)2, Size = 52)]
	[NetworkStructWeaved(13)]
	public struct GameSettings : INetworkStruct
	{
		[FieldOffset(0)]
		public MatchType MatchType;

		[FieldOffset(4)]
		public Mode Mode;

		[FieldOffset(8)]
		public AllowedClasses AllowedClasses;

		[FieldOffset(12)]
		public int MatchDuration;

		[FieldOffset(16)]
		public int MaxGoalCount;

		[FieldOffset(20)]
		public TieOption TieOption;

		[FieldOffset(24)]
		public int OverTimeDuration;

		[FieldOffset(28)]
		public AmmoRegenMultiplier AmmoRegenMultiplier;

		[FieldOffset(32)]
		public PlatformLayout PlatformLayout;

		[FieldOffset(36)]
		public BallType BallType;

		[FieldOffset(40)]
		public BallModifier BallModifier;

		[FieldOffset(44)]
		public GoalType GoalType;

		[FieldOffset(48)]
		public GroundItems GroundItems;

		public static readonly GameSettings FreePlay;

		public static readonly GameSettings TimedModeDefault;

		public static readonly GameSettings RankedDefault;

		public static readonly GameSettings HubSkyballDefault;

		public static readonly GameSettings HubVolleyballDefault;

		public static readonly int[] MatchDurationArray;

		public static readonly int[] OvertimeDurationArray;

		public static readonly int[] MaxGoalCountArray;

		public static float GetAmmoRegenMultiplierValue(AmmoRegenMultiplier ammoRegenMultiplier)
		{
			return 0f;
		}
	}
}
