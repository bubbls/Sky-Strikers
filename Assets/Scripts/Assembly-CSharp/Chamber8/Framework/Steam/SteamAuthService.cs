using Chamber8.Framework.Account;
using Chamber8.Framework.Common;
using JetBrains.Annotations;
using Steamworks;

namespace Chamber8.Framework.Steam
{
	[UsedImplicitly]
	public class SteamAuthService : AbstractSteamService, IAuthService<SteamAuthInfo, SteamAuthResult>, IInitializer
	{
		private const int MaxTicketBufferSize = 1024;

		private Callback<ValidateAuthTicketResponse_t> _validateAuthTicketResponse;

		private Callback<GetAuthSessionTicketResponse_t> _getAuthSessionTicketResponse;

		private static HAuthTicket GetAuthSessionTicketBlob(out byte[] ticketBlob)
		{
			ticketBlob = null;
			return default(HAuthTicket);
		}

		public static string GetAuthSessionTicketBlobString()
		{
			return null;
		}

		public SteamAuthResult BeginAuthSession(SteamAuthInfo authInfo)
		{
			return null;
		}

		public void EndAuthSession(SteamAuthResult authResult)
		{
		}

		public void Initialize()
		{
		}

		private void OnValidateAuthTicketResponse(ValidateAuthTicketResponse_t pCallback)
		{
		}

		private void OnGetAuthSessionTicketResponse(GetAuthSessionTicketResponse_t pCallback)
		{
		}
	}
}
