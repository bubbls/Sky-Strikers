using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	[NetworkBehaviourWeaved(0)]
	public class MPlayerAbilityBulwarp : MPlayerAbility
	{
		[SerializeField]
		private MPlayerAbilityWeaponManager _weaponManager;

		[SerializeField]
		private MBulwarpPlaceablesController _placeablesController;

		[SerializeField]
		private PlayerLocomotionConfiguration _locomotionConfiguration;

		[SerializeField]
		private float _handVelocityMultiplier;

		private static Changed<MPlayerAbilityBulwarp> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerAbilityBulwarp> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerAbilityBulwarp> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleOnSpawned()
		{
		}

		protected override void HandleResetAbility()
		{
		}

		public override PlayerAbilityWeaponInputData GetInputData()
		{
			return default(PlayerAbilityWeaponInputData);
		}

		protected override void OnPreProcessInput(PlayerInputData inputData)
		{
		}

		protected override void OnTriggerPressed(MPlayerHand mPlayerHand)
		{
		}

		protected override void OnTriggerReleased(MPlayerHand mPlayerHand)
		{
		}

		protected override void OnGrabPressed(MPlayerHand mPlayerHand)
		{
		}

		protected override void OnGrabReleased(MPlayerHand mPlayerHand)
		{
		}

		protected override void HandleOnPlayerInfoUpdated(PlayerInfo playerInfo)
		{
		}

		protected override void HandleOnPlayerSuitVisualsUpdated(PlayerInfo playerInfo)
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
