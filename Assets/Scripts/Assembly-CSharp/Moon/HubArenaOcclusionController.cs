using Chamber8.Framework.Messaging;
using Moon.MultiPlay;
using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class HubArenaOcclusionController : MonoBehaviour
	{
		[SerializeField]
		private OcclusionPortal[] _occlusionPortals;

		private IMessageSubscriber _subscriber;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private int HandleLocalPlayerLocationChanged(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		private void TogglePortals(bool open)
		{
		}

		[Button("Find all portals", EButtonEnableMode.Always)]
		private void FindAllPortals()
		{
		}

		[Button("Open All portals", EButtonEnableMode.Always)]
		private void OpenAllPortals()
		{
		}

		[Button("Close All portals", EButtonEnableMode.Always)]
		private void CloseAllPortals()
		{
		}
	}
}
