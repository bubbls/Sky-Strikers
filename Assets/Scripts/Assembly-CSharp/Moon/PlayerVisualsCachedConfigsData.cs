using System;

namespace Moon
{
	[Serializable]
	public class PlayerVisualsCachedConfigsData
	{
		public int Version;

		public PlayerVisualsCachedConfigData LastConfig;

		public PlayerVisualsCachedConfigData LastPrimeConfig;

		public PlayerVisualsCachedConfigData LastJetstreamConfig;

		public PlayerVisualsCachedConfigData LastBulwarpConfig;

		public PlayerVisualsCachedConfigData GetConfig(PlayerSuitClass preferredSuitClass)
		{
			return null;
		}
	}
}
