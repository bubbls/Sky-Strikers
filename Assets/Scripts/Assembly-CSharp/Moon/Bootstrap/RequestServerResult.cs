using System;

namespace Moon.Bootstrap
{
	[Serializable]
	public class RequestServerResult
	{
		public string ServerId;

		public RequestServerResultError? Error;
	}
}
