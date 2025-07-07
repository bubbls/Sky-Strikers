using System;

namespace Moon.Framework.Base
{
	[Serializable]
	public class APIResponseData<T>
	{
		public int code;

		public string message;

		public T data;
	}
}
