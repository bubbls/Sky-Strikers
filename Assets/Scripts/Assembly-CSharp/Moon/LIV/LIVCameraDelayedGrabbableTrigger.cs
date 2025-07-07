using Moon.Interaction;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVCameraDelayedGrabbableTrigger : DelayedGrabbableTrigger
	{
		[SerializeField]
		private LocalGrabbable _localGrabbable;

		private LIVCameraBodyBracket _cameraBodyBracket;

		public override IGrabbable Grabbable => null;

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		protected override bool IsTriggerInteractableInternal()
		{
			return false;
		}
	}
}
