using System;
using Moon.Arena;

namespace Moon.PlayerProfile
{
	public interface IPlayerProfileService
	{
		PlayerVisualsConfig GetLastPlayerVisualConfig();

		void SetPlayerVisualConfig(PlayerVisualsConfig config);

		PlayerVisualsCachedPresets GetPlayerVisualsCachedPresets();

		void SetPlayerVisualsCachedPresets(PlayerVisualsCachedPresets presets);

		PlayerVisualsCachedConfigData GetLastSuitClassDataFrom(PlayerSuitClass suitClass);

		bool GetGameOptions(out GameOption.Options options);

		void SetGameOptions(GameOption.Options options);

		bool GetPlayerNumber(out PlayerNumberData playerNumberData);

		void SetPlayerNumber(int number);

		void SetLocal(string key, object data);

		bool TryGetLocal(string key, Type type, out object data);

		void RemoveLocal(string createdTicketKey);
	}
}
