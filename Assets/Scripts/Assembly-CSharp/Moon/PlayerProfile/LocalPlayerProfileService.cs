using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Moon.Arena;
using Moon.Data;

namespace Moon.PlayerProfile
{
	[UsedImplicitly]
	public class LocalPlayerProfileService
	{
		private class ObscuredPrefsHelper
		{
			public ObscuredPrefs ObscuredPref { get; }

			public ObscuredPrefsHelper(string dataId)
			{
			}
		}

		private const int PlayerVisualsSaveDataVersion = 3;

		private static readonly string _saveDataPath;

		private const string PlayerVisualConfigKey = "PlayerVisualConfig";

		private const string PlayerVisualConfigPresetsKey = "PlayerVisualConfigPresets";

		private const string PlayerNumberDataKey = "PlayerNumberData";

		private const string GameOptionsKey = "GameOptions";

		private readonly Dictionary<string, ObscuredPrefsHelper> _obscuredPrefsHelpers;

		public PlayerVisualsConfig GetLastPlayerVisualConfig()
		{
			return default(PlayerVisualsConfig);
		}

		public PlayerVisualsCachedConfigData GetLastSuitClassDataFrom(PlayerSuitClass suitClass)
		{
			return null;
		}

		public PlayerVisualsCachedConfigData GetLastSuitClassDataFrom(SuitVisualTheme suitVisualTheme)
		{
			return null;
		}

		public PlayerVisualsCachedConfigsData LoadVisualsCachedConfigsData()
		{
			return null;
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

		public bool GetGameOptions(out GameOption.Options options)
		{
			options = null;
			return false;
		}

		public void SetGameOptions(GameOption.Options options)
		{
		}

		private static string GetLocalKey(string key)
		{
			return null;
		}

		public void SetLocal(string key, object data)
		{
		}

		public bool TryGetLocal(string key, Type type, out object data)
		{
			data = null;
			return false;
		}

		public bool TryGetLocal<T>(string key, out T data)
		{
			data = default(T);
			return false;
		}

		private void InitializeObscuredPrefs(string key)
		{
		}

		public void RemoveLocal(string key)
		{
		}

		private bool TryLoadJson(string key, Type type, out object data)
		{
			data = null;
			return false;
		}

		public bool GetPlayerNumber(out PlayerNumberData playerNumberData)
		{
			playerNumberData = default(PlayerNumberData);
			return false;
		}

		public void SetPlayerNumber(int number)
		{
		}

		private bool TryLoadJson<T>(string key, out T data) where T : new()
		{
			data = default(T);
			return false;
		}

		private void SaveJson(string key, object data)
		{
		}

		private void TryCreateDirectory(string path)
		{
		}

		private static string TryAddTitleIdToKey(string key)
		{
			return null;
		}
	}
}
