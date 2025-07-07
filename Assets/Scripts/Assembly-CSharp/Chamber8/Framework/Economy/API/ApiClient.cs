using System.Net.Http;

namespace Chamber8.Framework.Economy.API
{
	public class ApiClient
	{
		private static HttpClient _client;

		public static void Execute<T>(IApiRequest<T> request) where T : class
		{
		}

		public static HttpClient HttpClient()
		{
			return null;
		}
	}
}
