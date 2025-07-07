using UnityEngine;
using UnityEngine.Events;

namespace Moon.Player.Visual
{
	public class PrimeBatVisual : PlayerSuitWeaponVisual, IWeaponVisualWithVelocityTracker, IWeaponVisual
	{
		public UnityEvent<SuitWeaponVisualTheme, Vector3> RequestPlaySwingFx;

		private static readonly int _showBatAnimationHash;

		private static readonly int _hideBatAnimationHash;

		[SerializeField]
		protected Animator _animator;

		private PlayerBatAnimationEventController _animationEventController;

		[SerializeField]
		private VelocityTracker _velocityTracker;

		[SerializeField]
		private PlaySwingFx _playSwingFx;

		public VelocityTracker VelocityTracker => null;

		protected override void InitializeInternal()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleRequestPlaySwingFx(Vector3 position)
		{
		}

		protected override void HandleShow()
		{
		}

		protected override void HandleHide(bool instantly)
		{
		}

		private void HandleOnAnimationComplete(bool show)
		{
		}

		private void HideInstantly()
		{
		}

		void IWeaponVisualWithVelocityTracker.ClearVelocityTracker()
		{
		}

		Vector3 IWeaponVisualWithVelocityTracker.GetWeaponSpecificVelocity()
		{
			return default(Vector3);
		}
	}
}
