using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine.Networking;

namespace Moon.Framework.Base
{
	[PublicAPI]
	public class WebRequest : WebRequestInternal
	{
		[PublicAPI]
		public class Configuration
		{
			public string Url { get; protected set; }

			public Dictionary<string, string> Headers { get; protected set; }

			public string RequestType { get; set; }

			public string CustomData { get; set; }

			public bool AutoStart { get; set; }
		}

		[PublicAPI]
		public class GetRequestConfiguration : Configuration
		{
			public GetRequestConfiguration(string url)
			{
			}

			public GetRequestConfiguration(string url, Dictionary<string, string> headers)
			{
			}
		}

		[PublicAPI]
		public class PostRequestConfiguration : Configuration
		{
			public string RequestBody { get; protected set; }

			public List<IMultipartFormSection> FormData { get; protected set; }

			public string ContentType { get; protected set; }

			public PostRequestConfiguration(string url, string requestBody, string contentType = "application/json")
			{
			}

			public PostRequestConfiguration(string url, Dictionary<string, string> headers, string requestBody, string contentType = "application/json")
			{
			}

			public PostRequestConfiguration(string url, Dictionary<string, string> headers, List<IMultipartFormSection> formData)
			{
			}
		}

		public WebRequest(Configuration configuration)
			: base(null)
		{
		}
	}
}
