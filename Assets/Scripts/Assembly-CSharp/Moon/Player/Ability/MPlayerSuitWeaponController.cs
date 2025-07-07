using System;
using Fusion;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon.Player.Ability
{
	[OrderAfter(new Type[] { typeof(MNetworkRig) })]
	[NetworkBehaviourWeaved(1)]
	public class MPlayerSuitWeaponController : MWeaponController
	{
		private PlayerVisualsController _playerVisualsController;

		private static Changed<MPlayerSuitWeaponController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerSuitWeaponController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerSuitWeaponController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleOnInitialize()
		{
		}

		protected override void HandleResetWeaponController()
		{
		}

		private void UpdateHeldWeaponVisualRelatedData(Transform pivot, PlayerSuitWeaponVisual suitWeaponVisual, bool isLeft)
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
