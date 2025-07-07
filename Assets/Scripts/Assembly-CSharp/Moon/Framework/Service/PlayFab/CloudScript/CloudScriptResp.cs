using System.Net;

namespace Moon.Framework.Service.PlayFab.CloudScript
{
	public class CloudScriptResp<T>
	{
		public HttpStatusCode Code;

		public string? Message;

		public T? Data;

		public bool Success()
		{
			return false;
		}

		public static CloudScriptResp<T> Error(HttpStatusCode code, string? message = null)
		{
			return null;
		}
	}
}
