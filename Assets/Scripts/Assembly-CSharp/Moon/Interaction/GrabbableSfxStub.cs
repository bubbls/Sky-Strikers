using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Interaction
{
	public class GrabbableSfxStub : MonoBehaviour, IGrabbableEventListener
	{
		[SerializeField]
		private SoundInfo _grabbedSound;

		[SerializeField]
		private SoundInfo _releasedSound;

		private int _grabbedSoundId;

		private int _releasedSoundId;

		void IGrabbableEventListener.Initialize(bool isGrabbed, MGrabInteractor grabInteractor)
		{
		}

		void IGrabbableEventListener.HandleOnGrabbed(MGrabInteractor grabInteractor)
		{
		}

		void IGrabbableEventListener.HandleOnRelease(MGrabInteractor grabInteractor)
		{
		}
	}
}
