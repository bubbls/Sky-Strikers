using System;
using Chamber8.Framework.Account;
using PlayFab;
using PlayFab.ClientModels;

namespace Chamber8.Framework.Service.PlayFab
{
	public class LinkedPlayFabAccount
	{
		public bool IsBanned;

		public DateTime BanExpireDate;

		public string BanReason;

		public readonly IAccount PlatformAccount;

		public string EntityToken;

		public DateTime TokenExpiration;

		public EntityKey Entity;

		public string PlayFabId;

		public string PhotonAuthToken;

		public bool IsNewAccount;

		public GetPlayerCombinedInfoResultPayload InitialCombinedInfo;

		public LinkedPlayFabAccount(IAccount platformAccount)
		{
		}

		public string GetDisplayName()
		{
			return null;
		}

		public void SetDisplayName(string displayName)
		{
		}

		public void SetBanned(PlayFabError error)
		{
		}
	}
}
