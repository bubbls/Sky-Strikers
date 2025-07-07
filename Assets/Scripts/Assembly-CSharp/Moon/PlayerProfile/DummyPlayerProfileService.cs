using System;
using Chamber8.Framework.Common;
using Moon.Arena;
using UnityEngine.Scripting;

namespace Moon.PlayerProfile
{
	[Preserve]
	public class DummyPlayerProfileService : IPlayerProfileService, IInitializer
	{
		private readonly GameOption.Options _gameOptions;

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

		public string GetUniquePlayerId()
		{
			return null;
		}

		public void Initialize()
		{
		}
	}
}
