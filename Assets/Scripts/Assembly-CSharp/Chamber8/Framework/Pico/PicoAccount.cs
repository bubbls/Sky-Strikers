using Chamber8.Framework.Account;
using Chamber8.Framework.Platform;
using Pico.Platform.Models;

namespace Chamber8.Framework.Pico
{
	public class PicoAccount : IAccount
	{
		public string AccessToken;

		private readonly User _user;

		public string DisplayName => null;

		public Chamber8.Framework.Platform.Platform Platform => default(Chamber8.Framework.Platform.Platform);

		public string UniquePlayerId => null;

		public PicoAccount(User user)
		{
		}
	}
}
