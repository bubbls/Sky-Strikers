using System.Collections.Generic;

namespace Chamber8.Framework.Economy.API
{
	public class PostRequest<T> : AbstractApiRequest<T> where T : class
	{
		public string Url;

		public Dictionary<string, string> Fields;

		public override void Execute()
		{
		}
	}
}
