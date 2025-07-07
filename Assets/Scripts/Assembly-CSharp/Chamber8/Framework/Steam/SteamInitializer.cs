using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using JetBrains.Annotations;
using Steamworks;

namespace Chamber8.Framework.Steam
{
	[UsedImplicitly]
	public class SteamInitializer : AbstractSteamService, IInitializer
	{
		private Callback<ValidateAuthTicketResponse_t> _validateAuthTicketResponse;

		private Callback<GameOverlayActivated_t> _gameOverlayActivated;

		private Callback<GetAuthSessionTicketResponse_t> _getAuthSessionTicketResponse;

		public void Initialize()
		{
		}

		private void RegisterCallbacks()
		{
		}

		private void OnValidateAuthTicketResponse(ValidateAuthTicketResponse_t pCallback)
		{
		}

		private void OnGetAuthSessionTicketResponse(GetAuthSessionTicketResponse_t pCallback)
		{
		}

		private void OnGameOverlayActivated(GameOverlayActivated_t pCallback)
		{
		}

		private void SendMessage<T>(IMessage<T> message) where T : class
		{
		}
	}
}
