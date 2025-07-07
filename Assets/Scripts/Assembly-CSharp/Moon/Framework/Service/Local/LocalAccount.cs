using Chamber8.Framework.Account;
using Chamber8.Framework.Platform;

namespace Moon.Framework.Service.Local
{
	public class LocalAccount : IAccount
	{
		public bool AlsoAuthorizeAsServer;

		public string DisplayName { get; set; }

		public Platform Platform => default(Platform);

		public string UniquePlayerId { get; set; }
	}
}
