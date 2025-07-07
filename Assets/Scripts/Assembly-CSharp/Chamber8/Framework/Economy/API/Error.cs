using PlayFab;

namespace Chamber8.Framework.Economy.API
{
	public class Error
	{
		public PlayFabError? PlayFabError;

		public InGameErrorCode? ErrorCode;

		public string? ErrorMessage;

		public ErrorCategory Category;

		public override string ToString()
		{
			return null;
		}

		public Error(PlayFabError error)
		{
		}

		public Error(InGameErrorCode inGameErrorCode)
		{
		}

		public Error(string message)
		{
		}
	}
}
