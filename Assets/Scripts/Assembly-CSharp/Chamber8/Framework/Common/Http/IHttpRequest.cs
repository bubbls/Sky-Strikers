using System.Collections.Generic;

namespace Chamber8.Framework.Common.Http
{
	public interface IHttpRequest
	{
		string Url();

		Dictionary<string, string> Headers();
	}
}
