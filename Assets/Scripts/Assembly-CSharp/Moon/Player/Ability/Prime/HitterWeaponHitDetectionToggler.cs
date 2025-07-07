using Fusion;
using UnityEngine;

namespace Moon.Player.Ability.Prime
{
	[NetworkBehaviourWeaved(0)]
	public class HitterWeaponHitDetectionToggler : NetworkBehaviour
	{
		private const float HitDisableTime = 0.5f;

		[SerializeField]
		private MPlayerAbilityWeaponManager _weaponManager;

		[SerializeField]
		private MHitterWeapon _leftHitterWeapon;

		[SerializeField]
		private MHitterWeapon _rightHitterWeapon;

		[SerializeField]
		private LayerMask _disableHitterMask;

		private float _leftHandHitterEnableTime;

		private float _rightHandHitterEnableTime;

		private static Changed<HitterWeaponHitDetectionToggler> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<HitterWeaponHitDetectionToggler> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<HitterWeaponHitDetectionToggler> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
		{
		}

		private void Initialize()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void ResetToggler()
		{
		}

		private void LeftMHitterWeaponOnHit(Hittable hittable)
		{
		}

		private void RightMHitter_OnHit(Hittable hittable)
		{
		}

		private void LeftMHitterWeapon_OnHitDetectionToggled(bool isHitDetectionEnabled)
		{
		}

		private void RightMHitterWeaponWeapon_OnHitDetectionToggled(bool isHitDetectionEnabled)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}
	}
}
