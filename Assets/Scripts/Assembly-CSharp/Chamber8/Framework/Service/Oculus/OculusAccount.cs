using Chamber8.Framework.Account;
using Chamber8.Framework.Platform;
using Oculus.Platform.Models;

namespace Chamber8.Framework.Service.Oculus
{
	public class OculusAccount : IAccount
	{
		public string AgeGroup;

		public string AccessToken;

		public UserProof UserProof;

		private readonly User _user;

		public string DisplayName => null;

		public Chamber8.Framework.Platform.Platform Platform => default(Chamber8.Framework.Platform.Platform);

		public string UniquePlayerId => null;

		public ulong UserId => 0uL;

		public OculusAccount(User user)
		{
		}

		public void UpdateUserProof(UserProof userProof)
		{
		}
	}
}
