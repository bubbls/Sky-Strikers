using System;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	[OrderAfter(new Type[] { typeof(MNetworkRig) })]
	[RequireComponent(typeof(PlayerHoldableWeapon))]
	[NetworkBehaviourWeaved(1)]
	public class MBulwarpPaddleController : MWeaponController
	{
		[SerializeField]
		private MHitterWeapon _mHitterWeapon;

		[SerializeField]
		private LocalHitter _localHitter;

		private static Changed<MBulwarpPaddleController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MBulwarpPaddleController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MBulwarpPaddleController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleOnInitialize()
		{
		}

		protected override void HandleResetWeaponController()
		{
		}

		public override void UpdateInput(PlayerInputData playerInputData)
		{
		}

		protected override void ProcessToggleHeldWeapon()
		{
		}

		protected override void TrySetupVisualsOnHand(PlayerHand playerHand)
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
