using System;

namespace Moon.Interaction
{
	public interface IGrabbable
	{
		bool IsLocalGrabbable { get; }

		event Action OnGrabbed;

		event Action OnReleased;

		void Grab(MGrabInteractor interactor);

		void ForceGrab(MGrabInteractor interactor);

		void Release();

		bool CanBeGrabbedByInteractor(MGrabInteractor mGrabInteractor);

		void PlayGrabRejected(MGrabInteractor mGrabInteractor);
	}
}
