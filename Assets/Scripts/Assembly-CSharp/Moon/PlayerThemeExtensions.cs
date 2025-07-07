namespace Moon
{
	public static class PlayerThemeExtensions
	{
		private const int RangeBetweenClasses = 2999;

		private const int ChampionRangeInClasses = 2000;

		public static bool IsPrime(this SuitVisualTheme theme)
		{
			return false;
		}

		public static bool IsPrimeWeapon(this SuitWeaponVisualTheme theme)
		{
			return false;
		}

		public static bool IsJetstream(this SuitVisualTheme theme)
		{
			return false;
		}

		public static bool IsJetstreamWeapon(this SuitWeaponVisualTheme theme)
		{
			return false;
		}

		public static bool IsBulwarp(this SuitVisualTheme theme)
		{
			return false;
		}

		public static bool IsBulwarpWeapon(this SuitWeaponVisualTheme theme)
		{
			return false;
		}

		public static bool IsObserver(this SuitVisualTheme theme)
		{
			return false;
		}

		private static bool IsVisualThemeInRange(this SuitVisualTheme theme, int start, int end)
		{
			return false;
		}

		private static bool IsWeaponThemeInRange(this SuitWeaponVisualTheme theme, int start, int end)
		{
			return false;
		}

		public static SuitVisualTheme GetSuitVisualThemeFallback(this SuitVisualTheme theme)
		{
			return default(SuitVisualTheme);
		}

		public static SuitVisualTheme GetSuitVisualThemeFallback(this SuitWeaponVisualTheme theme)
		{
			return default(SuitVisualTheme);
		}

		public static SuitWeaponVisualTheme GetSuitWeaponThemeFallback(this SuitWeaponVisualTheme theme)
		{
			return default(SuitWeaponVisualTheme);
		}

		public static SuitVisualTheme GetSuitVisualThemeFallback(this PlayerSuitClass suitClass)
		{
			return default(SuitVisualTheme);
		}

		public static SuitWeaponVisualTheme GetSuitWeaponThemeFallback(this PlayerSuitClass suitClass)
		{
			return default(SuitWeaponVisualTheme);
		}

		public static PlayerSuitClass GetPlayerSuitClass(this SuitVisualTheme suitVisualTheme)
		{
			return default(PlayerSuitClass);
		}

		public static bool IsClass(this SuitVisualTheme suitTheme, PlayerSuitClass suitClass)
		{
			return false;
		}

		public static bool IsClass(this SuitWeaponVisualTheme weaponVisualTheme, PlayerSuitClass suitClass)
		{
			return false;
		}

		public static bool IsChampionWeapon(this SuitWeaponVisualTheme theme)
		{
			return false;
		}
	}
}
