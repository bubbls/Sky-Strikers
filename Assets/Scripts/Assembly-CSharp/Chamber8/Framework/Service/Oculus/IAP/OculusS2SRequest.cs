using Chamber8.Framework.Economy.API;

namespace Chamber8.Framework.Service.Oculus.IAP
{
	public class OculusS2SRequest<T> : PostRequest<T> where T : class
	{
		public string AccessToken;

		protected string Path;

		public override void Execute()
		{
		}
	}
}
