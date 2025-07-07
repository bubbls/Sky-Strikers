using System;

namespace Chamber8.Framework.Economy.API
{
	public abstract class AbstractApiRequest<T> : IApiRequest<T> where T : class
	{
		public Action<Error> OnError { get; set; }

		public Action<T> OnSuccess { get; set; }

		public abstract void Execute();
	}
}
