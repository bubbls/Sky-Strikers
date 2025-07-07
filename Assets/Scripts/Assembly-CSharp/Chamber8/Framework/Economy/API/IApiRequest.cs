namespace Chamber8.Framework.Economy.API
{
	public interface IApiRequest<T> where T : class
	{
		void Execute();
	}
}
