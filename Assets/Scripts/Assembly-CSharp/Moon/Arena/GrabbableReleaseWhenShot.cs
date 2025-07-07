using Chamber8.Framework.Messaging;
using Moon.Interaction;
using UnityEngine;

namespace Moon.Arena
{
	public class GrabbableReleaseWhenShot : MonoBehaviour, IGrabbableEventListener
	{
		private IMessageSubscriber _messageSubscriber;

		private MGrabInteractor _interactor;

		void IGrabbableEventListener.Initialize(bool isGrabbed, MGrabInteractor grabInteractor)
		{
		}

		private void OnDestroy()
		{
		}

		void IGrabbableEventListener.HandleOnGrabbed(MGrabInteractor grabInteractor)
		{
		}

		void IGrabbableEventListener.HandleOnRelease(MGrabInteractor grabInteractor)
		{
		}

		private int HandlePlayerLocomotionMessage(IMessage<PlayerLocomotionMessage> message)
		{
			return 0;
		}
	}
}
