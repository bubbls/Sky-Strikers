using Chamber8.Framework.Account;
using UnityEngine.Scripting;

namespace Moon.Framework.Service.Server
{
	[Preserve]
	public class ServerAccountService : IAccountService
	{
		private const string ServerAccountUniqueId = "KQRUENFJBDKAJDLFIERJF";

		private ServerAccount _serverAccount;

		public IAccount GetCurrentAccount()
		{
			return null;
		}
	}
}
