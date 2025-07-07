using Moon.Interaction;
using UnityEngine;

namespace Moon.Backpack
{
	public class BackpackDelayedGrabbableTrigger : DelayedGrabbableTrigger
	{
		[Header("Haptics")]
		[SerializeField]
		private float _hapticDuration;

		[SerializeField]
		private float _hapticAmp;

		[SerializeField]
		private MGrabbable _grabbable;

		private MGrabbableBackpack _backpack;

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
