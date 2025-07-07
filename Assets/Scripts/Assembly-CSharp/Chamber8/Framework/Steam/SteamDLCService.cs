using System.Collections.Generic;
using Chamber8.Framework.Core;
using Chamber8.Framework.DLC;
using JetBrains.Annotations;
using Steamworks;

namespace Chamber8.Framework.Steam
{
	[UsedImplicitly]
	public class SteamDLCService : AbstractSteamService, IDLCService
	{
		private readonly HashSet<Chamber8.Framework.DLC.DLC> _purchasedDlcs;

		public CreationStrategy CreateStrategy()
		{
			return default(CreationStrategy);
		}

		public List<Chamber8.Framework.DLC.DLC> ListAllDLC()
		{
			return null;
		}

		public bool IsPurchased(Chamber8.Framework.DLC.DLC dlc)
		{
			return false;
		}

		public bool IsInstalled(Chamber8.Framework.DLC.DLC dlc)
		{
			return false;
		}

		public void OpenDetailPage(Chamber8.Framework.DLC.DLC dlc)
		{
		}

		private AppId_t AppId(Chamber8.Framework.DLC.DLC dlc)
		{
			return default(AppId_t);
		}
	}
}
