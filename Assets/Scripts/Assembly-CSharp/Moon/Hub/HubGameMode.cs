using System;
using Moon.Arena;

namespace Moon.Hub
{
	[Serializable]
	public class HubGameMode
	{
		public string GameModeId;

		public Mode Mode;

		public MatchType MatchType;

		public int MatchDuration;

		public int OvertimeDuration;

		public PlatformLayout PlatformLayout;

		public BallType BallType;

		public GroundItems GroundItem;

		public AmmoRegenMultiplier AmmoRegenMultiplier;

		public GoalType GoalType;

		public BallModifier BallModifier;

		public GameModifierConfiguration[] GameModeModifiers;
	}
}
