using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using JetBrains.Annotations;
using Moon.Arena;

namespace Moon.Hub
{
	public class HubGameSettingsConfigurations : Singleton<HubGameSettingsConfigurations>
	{
		private const int DefaultParticipationRewardAmount = 3;

		private const int DefaultMinVotesToStartMatch = 2;

		private const int DefaultMatchStartingCountdownTime = 45;

		private RemoteHubGameSettingsConfigurations _remoteHubGameSettingsConfigurations;

		private bool _hasGameSettingsConfigurations;

		protected override void Initialize()
		{
		}

		public int GetMinVotesToStartMatch()
		{
			return 0;
		}

		public int GetMatchStartingCountdownTime()
		{
			return 0;
		}

		public HubGameSettings GetFreePlaySettings()
		{
			return default(HubGameSettings);
		}

		public void GetRandomGameSettings(HubGameSettings? previousSettings, out HubGameSettings gameSettingsOne, out HubGameSettings gameSettingsTwo)
		{
			gameSettingsOne = default(HubGameSettings);
			gameSettingsTwo = default(HubGameSettings);
		}

		public int GetParticipationRewardAmount()
		{
			return 0;
		}

		private bool TrySelectRandomGameModes(HubGameModeWeighted[] preconfiguredGameModes, int count, HubGameSettings? previousSettings, out HubGameModeWeighted[] gameModes)
		{
			gameModes = null;
			return false;
		}

		private HubGameSettings GenerateRandomGameSettings(HubGameMode hubGameMode, HubGameSettings? gameSettingsToIgnore = null)
		{
			return default(HubGameSettings);
		}

		private void TrySelectRandomModifier(GameModifierConfiguration[] modifierConfigurations, GameModeModifier? modifierToIgnore, out GameModeModifier selectedModifier)
		{
			selectedModifier = default(GameModeModifier);
		}

		private static void ApplyModifierToGameSettings(ref GameSettings gameSettings, GameModeModifier modifier)
		{
		}

		[UsedImplicitly]
		private static T GetRandomEnumValue<T>(IEnumerable<T> allowedValues, params T?[] ignoreValues) where T : struct, Enum
		{
			return default(T);
		}

		[UsedImplicitly]
		private static T GetRandomFlags<T>() where T : Enum
		{
			return default(T);
		}
	}
}
