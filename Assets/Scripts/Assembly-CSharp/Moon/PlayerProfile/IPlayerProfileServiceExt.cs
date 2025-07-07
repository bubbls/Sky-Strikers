namespace Moon.PlayerProfile
{
	public static class IPlayerProfileServiceExt
	{
		public static bool TryGetLocal<T>(this IPlayerProfileService srv, string key, out T data)
		{
			data = default(T);
			return false;
		}
	}
}
