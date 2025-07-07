using Moon.Player.Visual;
using UnityEngine;

namespace Moon
{
	public class BulwarpSuitArmVisual : PlayerSuitArmVisual
	{
		[SerializeField]
		private GameObject _leftArmShield;

		[SerializeField]
		private GameObject _rightArmShield;

		[SerializeField]
		private GameObject[] _localObjectsToHideInCamera;

		[SerializeField]
		private PlayerSlidingTracker _playerSlidingTracker;

		protected override void InitializeInternal()
		{
		}

		public override void HandleOnHoldingWeaponStateChanged(bool isWeaponOnLeftHand, bool isWeaponOnRightHand)
		{
		}
	}
}
