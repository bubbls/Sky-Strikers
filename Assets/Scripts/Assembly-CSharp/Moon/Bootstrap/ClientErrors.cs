using Fusion;
using PlayFab;

namespace Moon.Bootstrap
{
	public static class ClientErrors
	{
		public static ClientErrorCode From(ShutdownReason reason)
		{
			return default(ClientErrorCode);
		}

		public static ClientErrorCode From(PlayFabError error)
		{
			return default(ClientErrorCode);
		}

		public static ClientErrorCode From(ClientSharedData.Error error)
		{
			return default(ClientErrorCode);
		}

		public static string Stringify(ClientErrorCode errorCode)
		{
			return null;
		}
	}
}
