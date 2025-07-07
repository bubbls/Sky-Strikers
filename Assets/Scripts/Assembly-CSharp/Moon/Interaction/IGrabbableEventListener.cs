namespace Moon.Interaction
{
	public interface IGrabbableEventListener
	{
		void Initialize(bool isGrabbed, MGrabInteractor grabInteractor);

		void HandleOnGrabbed(MGrabInteractor grabInteractor);

		void HandleOnRelease(MGrabInteractor grabInteractor);
	}
}
