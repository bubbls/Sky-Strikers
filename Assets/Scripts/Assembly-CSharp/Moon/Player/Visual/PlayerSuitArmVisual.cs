using RootMotion.FinalIK;
using UnityEngine;

namespace Moon.Player.Visual
{
	public class PlayerSuitArmVisual : PlayerSuitVisualBase
	{
		[SerializeField]
		private bool _showUnequippedHeldWeapon;

		[SerializeField]
		private Transform _backpackPoint;

		[SerializeField]
		private Vector3 _backpackPointScale;

		[SerializeField]
		private ArmIK _leftArmIK;

		[SerializeField]
		private ArmIK _rightArmIK;

		public bool ShowUnequippedHeldWeapon => false;

		public Transform BackpackPoint => null;

		public Vector3 BackpackPointScale => default(Vector3);

		protected override void InitializeInternal()
		{
		}

		protected override void HandleOnPlayerSkeletonChanged(PlayerSkeleton playerSkeleton)
		{
		}

		private void TryIKUpdateSolverOnce(ref ArmIK armIK)
		{
		}
	}
}
