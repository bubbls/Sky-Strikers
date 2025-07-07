using Chamber8.Framework.Account;
using Chamber8.Framework.Platform;

namespace Chamber8.Framework.Steam
{
	public class SteamAccount : IAccount
	{
		public string SteamTicket;

		public string DisplayName { get; set; }

		public Chamber8.Framework.Platform.Platform Platform => default(Chamber8.Framework.Platform.Platform);

		public string UniquePlayerId => null;
	}
}
