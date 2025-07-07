using System;
using Fusion;
using Moon.Arena;

namespace Moon.Player.Visual
{
	public interface IVisualEventNotifier
	{
		event Action<PlayerRef, PlayerVisualAttachPointType, bool> OnVisualInitialized;

		event Action<TeamNo> OnTeamNoUpdated;

		event Action<PlayerRef> OnOwnerChanged;

		event Action OnVisualAboutToUnload;
	}
}
