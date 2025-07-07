using PlayFab;
using PlayFab.AuthenticationModels;
using PlayFab.ClientModels;
using PlayFab.CloudScriptModels;
using PlayFab.EconomyModels;
using PlayFab.MultiplayerModels;
using PlayFab.ServerModels;

namespace Chamber8.Framework.Service.PlayFab
{
	public static class PlayFabExtensions
	{
		public static bool IsBanned(this PlayFabError playFabError)
		{
			return false;
		}

		public static global::PlayFab.MultiplayerModels.EntityKey AsMultiplayer(this global::PlayFab.ClientModels.EntityKey entityKey)
		{
			return null;
		}

		public static global::PlayFab.EconomyModels.EntityKey AsEconomy(this global::PlayFab.ClientModels.EntityKey entityKey)
		{
			return null;
		}

		public static global::PlayFab.EconomyModels.EntityKey AsEconomy(this global::PlayFab.ServerModels.EntityKey entityKey)
		{
			return null;
		}

		public static global::PlayFab.ServerModels.EntityKey AsServer(this global::PlayFab.AuthenticationModels.EntityKey entityKey)
		{
			return null;
		}

		public static global::PlayFab.CloudScriptModels.EntityKey AsCloudScript(this PlayFabAuthenticationContext context)
		{
			return null;
		}

		public static global::PlayFab.MultiplayerModels.EntityKey AsMultiplayer(this PlayFabAuthenticationContext context)
		{
			return null;
		}

		public static global::PlayFab.EconomyModels.EntityKey AsEconomy(this PlayFabAuthenticationContext context)
		{
			return null;
		}
	}
}
