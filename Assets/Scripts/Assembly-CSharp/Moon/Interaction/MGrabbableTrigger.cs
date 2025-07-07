using UnityEngine;

namespace Moon.Interaction
{
	public class MGrabbableTrigger : MonoBehaviour, IGrabbableTrigger
	{
		[SerializeField]
		private MGrabbable _grabbable;

		public IGrabbable Grabbable => null;
	}
}
