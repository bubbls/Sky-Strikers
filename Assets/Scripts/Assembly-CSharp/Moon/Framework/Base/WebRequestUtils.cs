using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Moon.Framework.Base
{
	[PublicAPI]
	public static class WebRequestUtils
	{
		public static string GetBaseUrl()
		{
			return null;
		}

		public static Uri AddParametersToUrl(Uri uri, IDictionary<string, string> parameters)
		{
			return null;
		}

		public static string AddParametersToUrl(string url, IDictionary<string, string> parameters)
		{
			return null;
		}

		public static Dictionary<string, string> GetUrlParameters(string url)
		{
			return null;
		}

		public static Dictionary<string, string> GetUrlParameters(Uri uri)
		{
			return null;
		}

		public static string DictionaryToJsonString<T>(Dictionary<string, T> parameters)
		{
			return null;
		}

		public static bool TryParseResponseData<T>(string text, out T responseData)
		{
			responseData = default(T);
			return false;
		}
	}
}
