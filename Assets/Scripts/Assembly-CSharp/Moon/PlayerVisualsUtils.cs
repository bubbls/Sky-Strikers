using System;

namespace Moon
{
	public static class PlayerVisualsUtils
	{
		public static bool IsSuitCompatibleWithWeapon(SuitVisualTheme suitVisualTheme, SuitWeaponVisualTheme suitWeaponVisualTheme)
		{
			return false;
		}

		public static PlayerVisualsConfig GenerateVisualsConfigFromCacheConfig(PlayerVisualsCachedConfigData configData)
		{
			return default(PlayerVisualsConfig);
		}

		public static bool ChangeToClass(PlayerSuitClass suitClass)
		{
			return false;
		}

		public static void ChangeWeapon(SuitWeaponVisualTheme theme)
		{
		}

		public static void ChangeSkin(SuitVisualTheme theme)
		{
		}

		public static void ChangeAvatar(AvatarHeadVisualTheme headVisualTheme, AvatarBodyVisualTheme bodyVisualTheme, AvatarLegVisualTheme legVisualTheme)
		{
		}

		private static T TryGetCommonPartFromSuit<T>(SuitVisualTheme suitVisualTheme, T fallback) where T : Enum
		{
			return default(T);
		}

		public static PlayerVisualsCachedConfigData GenerateCachedConfigDataFromVisualsConfig(PlayerVisualsConfig visualsConfig)
		{
			return null;
		}

		public static PlayerVisualsCachedConfigData GenerateEmptyCachedConfigData()
		{
			return null;
		}

		private static PlayerVisualsSkinPreset GetObserverPreset()
		{
			return null;
		}

		public static PlayerVisualsConfig GenerateObserverPlayerVisualsConfig()
		{
			return default(PlayerVisualsConfig);
		}
	}
}
