using UnityEngine;

namespace Moon.XRSystem
{
	public class PlayerFingerUIInteractor : MonoBehaviour
	{
		public UIInteractorType InteractorType { get; private set; }

		public bool InteractionEnabled { get; private set; }

		public void SetInteractorType(UIInteractorType interactorType)
		{
		}

		public void ToggleInteraction(bool interactionEnabled)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
