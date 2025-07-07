using Chamber8.Framework.Account;
using UnityEngine.Scripting;

namespace Moon.Framework.Service.Local
{
	[Preserve]
	public class LocalAccountService : IAccountService
	{
		private const string LocalAccountUniquePlayerIdKey = "LocalAccountUniquePlayerId";

		private const string SimulatingLocalPlayerIndexKey = "LocalPlayerIndex";

		private LocalAccount _localAccount;

		private static int SimulatingPlayerIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public IAccount GetCurrentAccount()
		{
			return null;
		}

		private static void RenewUniquePlayerId()
		{
		}

		private static string GetUniquePlayerId()
		{
			return null;
		}

		private string GetDisplayName()
		{
			return null;
		}
	}
}
