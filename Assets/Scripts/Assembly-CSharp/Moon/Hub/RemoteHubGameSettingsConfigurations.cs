using System;

namespace Moon.Hub
{
	[Serializable]
	public class RemoteHubGameSettingsConfigurations
	{
		public int MinVotesToStartMatch;

		public int MatchStartingCountdownTime;

		public int ParticipationRewardAmount;

		public HubGameMode FreePlayGameMode;

		public HubGameModeWeighted[] GameModes;
	}
}
