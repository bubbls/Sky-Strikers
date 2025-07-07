using Chamber8.Framework.Common;

namespace Moon.Bootstrap
{
	public class ClientPrivateQueueChecker : Singleton<ClientPrivateQueueChecker>
	{
		public bool IsPrivateQueueEnabled { get; private set; }

		protected override void Initialize()
		{
		}
	}
}
