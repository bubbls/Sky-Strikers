using Chamber8.Framework.Messaging;
using Fusion;
using Moon.MultiPlay;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon.Interaction
{
	public class GrabbableHandSpawner : MonoBehaviour, IGrabbableEventListener
	{
		[SerializeField]
		private Transform _rightHandPoint;

		[SerializeField]
		private Transform _leftHandPoint;

		private PlayerSuitHandVisual _suitHandVisual;

		private MPlayer _currentPlayer;

		private PlayerRef _currentInteractorPlayer;

		private IMessageSubscriber _messageSubscriber;

		public void Initialize(bool isGrabbed, MGrabInteractor grabInteractor)
		{
		}

		void IGrabbableEventListener.HandleOnGrabbed(MGrabInteractor grabInteractor)
		{
		}

		private void AmmoBox_OnStatusChanged(WeaponType weaponType, MAmmoBox.Status status)
		{
		}

		void IGrabbableEventListener.HandleOnRelease(MGrabInteractor grabInteractor)
		{
		}

		private int HandleOnPlayerInfoUpdated(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		private void Reset()
		{
		}
	}
}
