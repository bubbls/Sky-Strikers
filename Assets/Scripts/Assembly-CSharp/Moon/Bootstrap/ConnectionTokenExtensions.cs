namespace Moon.Bootstrap
{
	public static class ConnectionTokenExtensions
	{
		public static byte[] Serialize(this ConnectionToken connectionToken)
		{
			return null;
		}

		public static ConnectionToken Deserialize(byte[] bytes)
		{
			return default(ConnectionToken);
		}

		public static PlayerVisualsConfig ToPlayerVisualConfig(this ConnectionTokenVisualsConfig connectionTokenVisualsConfig)
		{
			return default(PlayerVisualsConfig);
		}
	}
}
