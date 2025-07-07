using System;
using Chamber8.Framework.Common;
using Chamber8.Framework.Service.PlayFab.PlayerData;
using Moon.Arena;

namespace Moon.PlayerProfile
{
	public class MixedPlayerProfileService : IPlayerProfileService, IInitializer
	{
		public const string PlayerVisualsCachedConfigsDataKey = "PlayerVisualsCachedConfigsData";

		private readonly LocalPlayerProfileService _local;

		private PlayFabPlayerDataClient _client;

		private PlayerVisualsConfig? _lastVisualConfig;

		private PlayerNumberData? _lastPlayerNumber;

		public void Initialize()
		{
		}

		public PlayerVisualsConfig GetLastPlayerVisualConfig()
		{
			return default(PlayerVisualsConfig);
		}

		public void SetPlayerVisualConfig(PlayerVisualsConfig config)
		{
		}

		public PlayerVisualsCachedPresets GetPlayerVisualsCachedPresets()
		{
			return null;
		}

		public void SetPlayerVisualsCachedPresets(PlayerVisualsCachedPresets presets)
		{
		}

		public PlayerVisualsCachedConfigData GetLastSuitClassDataFrom(PlayerSuitClass suitClass)
		{
			return null;
		}

		public bool GetGameOptions(out GameOption.Options options)
		{
			options = null;
			return false;
		}

		public void SetGameOptions(GameOption.Options options)
		{
		}

		public bool GetPlayerNumber(out PlayerNumberData playerNumberData)
		{
			playerNumberData = default(PlayerNumberData);
			return false;
		}

		public void SetPlayerNumber(int number)
		{
		}

		public void SetLocal(string key, object data)
		{
		}

		public bool TryGetLocal(string key, Type type, out object data)
		{
			data = null;
			return false;
		}

		public void RemoveLocal(string createdTicketKey)
		{
		}
	}
}
