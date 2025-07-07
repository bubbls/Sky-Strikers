using System;

namespace Chamber8.Framework.Service.Rpc
{
	public class Response
	{
		public string Name;

		public Guid RequestId;

		public Result Result;

		public byte[] Payload;

		public static Response From<T>(Request request, T payload) where T : class
		{
			return null;
		}

		public static Response Empty(Request request)
		{
			return null;
		}
	}
}
