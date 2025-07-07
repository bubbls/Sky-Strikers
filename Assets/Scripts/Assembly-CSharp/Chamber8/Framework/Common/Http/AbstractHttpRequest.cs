using System.Collections.Generic;

namespace Chamber8.Framework.Common.Http
{
	public abstract class AbstractHttpRequest : IHttpRequest
	{
		public Dictionary<string, string> RequestHeaders;

		public string FullUrl;

		public string Url()
		{
			return null;
		}

		public Dictionary<string, string> Headers()
		{
			return null;
		}
	}
}
