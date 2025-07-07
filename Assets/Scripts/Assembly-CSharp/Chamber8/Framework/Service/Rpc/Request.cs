using System;

namespace Chamber8.Framework.Service.Rpc
{
	public class Request
	{
		public string Name;

		public Guid RequestId;

		public byte[] Payload;

		public static Request Create<T>(string serviceName, T payload) where T : class
		{
			return null;
		}
	}
}
