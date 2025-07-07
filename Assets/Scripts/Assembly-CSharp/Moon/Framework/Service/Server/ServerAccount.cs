using Chamber8.Framework.Account;
using Chamber8.Framework.Platform;

namespace Moon.Framework.Service.Server
{
	public class ServerAccount : IAccount
	{
		public string DisplayName { get; set; }

		public Platform Platform => default(Platform);

		public string UniquePlayerId { get; }

		public ServerAccount(string userId)
		{
		}
	}
}
