using Moon.Bootstrap;

namespace Moon.MultiPlay
{
	public class RankedMatchmakingMessage
	{
		public ClientSharedData.Error Error { get; set; }

		public bool IsPlayerTeleported { get; set; }

		public RankedMatchmakingMessage(ClientSharedData.Error error, bool isPlayerTeleported)
		{
		}
	}
}
