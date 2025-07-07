namespace Moon.MultiPlay
{
	public static class PlayerInfoExtensions
	{
		public static string GetPlayerName(this PlayerInfo playerInfo)
		{
			return null;
		}

		public static bool IsObserver(this PlayerInfo playerInfo)
		{
			return false;
		}

		public static PlayerSuitClass GetSuitClass(this PlayerInfo playerInfo)
		{
			return default(PlayerSuitClass);
		}

		public static PlayerSuitClass GetSuitClass(this PlayerVisualsConfig visualsConfig)
		{
			return default(PlayerSuitClass);
		}

		public static bool MatchesConfig(this PlayerVisualsConfig visualsConfig, PlayerVisualsConfig other)
		{
			return false;
		}
	}
}
