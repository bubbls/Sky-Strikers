using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using UnityEngine;

namespace Moon.Shop
{
	public class HubTunnelManager : MonoBehaviour
	{
		[SerializeField]
		private HubTunnel _arenaToHubTunnel;

		[SerializeField]
		private Portal _arenaToHubPortal;

		[SerializeField]
		private Portal _hubToArenaPortal;

		[SerializeField]
		private GameObject _vfxTunnel;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnArenaToHubPortalExitTeleportArea()
		{
		}

		private void HandleOnArenaToHubPortalEnterTeleportArea()
		{
		}

		private void HandleOnHubToArenaPortalEnterTeleportArea()
		{
		}

		private void HandleOnHubToArenaPortalExitTeleportArea()
		{
		}

		private int HandleGeneralMessage(IMessage<GeneralMessage> message)
		{
			return 0;
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}
	}
}
