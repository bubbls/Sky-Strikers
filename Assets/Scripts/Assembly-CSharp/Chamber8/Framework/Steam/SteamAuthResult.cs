using Chamber8.Framework.Account;
using Steamworks;

namespace Chamber8.Framework.Steam
{
	public class SteamAuthResult : IAuthResult
	{
		private bool _success;

		private HAuthTicket _authTicket;

		public string TicketBlob { get; private set; }

		public bool Success()
		{
			return false;
		}

		public static SteamAuthResult NewAuthResult(HAuthTicket authTicket, string ticketBlob = null)
		{
			return null;
		}

		public HAuthTicket Ticket()
		{
			return default(HAuthTicket);
		}
	}
}
