using UnityEngine;

namespace Moon.Interaction
{
	public class LocalGrabbableTrigger : MonoBehaviour, IGrabbableTrigger
	{
		[SerializeField]
		private LocalGrabbable _grabbable;

		public IGrabbable Grabbable => null;
	}
}
