using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.Interaction
{
	public abstract class DelayedGrabbableTrigger : MonoBehaviour, IGrabbableTrigger
	{
		[SerializeField]
		private float _delayedHoldTime;

		[SerializeField]
		private OverlapShapeDesc _triggerBounds;

		public float DelayedHoldTime => 0f;

		public abstract IGrabbable Grabbable { get; }

		public OverlapShapeDesc TriggerBounds => null;

		protected MGrabInteractor InteractorInTrigger { get; private set; }

		public void NotifyInteractorEnteredTrigger(MGrabInteractor interactor)
		{
		}

		protected virtual void HandleOnInteractorEnteredTrigger(MGrabInteractor interactor)
		{
		}

		public bool IsTriggerInteractable(MGrabInteractor interactor)
		{
			return false;
		}

		protected abstract bool IsTriggerInteractableInternal();

		public void NotifyInteractorExitTrigger(MGrabInteractor interactor)
		{
		}

		protected virtual void HandleOnInteractorExitTrigger(MGrabInteractor interactor)
		{
		}

		private void SetInteractor(MGrabInteractor interactor)
		{
		}
	}
}
