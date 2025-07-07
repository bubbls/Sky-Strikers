using System;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Player.Ability.Prime
{
	[OrderAfter(new Type[] { typeof(MNetworkRig) })]
	[NetworkBehaviourWeaved(1)]
	public class MPrimeWeaponController : MPlayerSuitWeaponController
	{
		[SerializeField]
		private MHitterWeapon _mHitterWeapon;

		[SerializeField]
		private Transform _muzzlePoint;

		[SerializeField]
		private LocalHitter _localHitter;

		private Vector3 _muzzlePointPosition;

		private Quaternion _muzzlePointRotation;

		private static Changed<MPrimeWeaponController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPrimeWeaponController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPrimeWeaponController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleOnInitialize()
		{
		}

		protected override void HandleResetWeaponController()
		{
		}

		public override void CollectInputData(ref PlayerAbilityWeaponInputData data)
		{
		}

		public override void Render()
		{
		}

		public override void UpdateInput(PlayerInputData playerInputData)
		{
		}

		protected override void ProcessToggleHeldWeapon()
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
