using Fusion;
using Moon.MultiPlay;
using Moon.Player.Visual;
using UnityEngine;

namespace Moon.Player.Ability.Prime
{
	[NetworkBehaviourWeaved(0)]
	public class MPlayerAbilityPrime : MPlayerAbility
	{
		[SerializeField]
		private PlayerLocomotionConfiguration _locomotionConfiguration;

		[SerializeField]
		private MPlayerAbilityWeaponManager _weaponManager;

		private PrimeSuitWeaponVisualThemeScheme _heldWeaponScheme;

		private bool _hasSwingSfx;

		private static Changed<MPlayerAbilityPrime> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerAbilityPrime> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerAbilityPrime> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleOnSpawned()
		{
		}

		protected override void HandleResetAbility()
		{
		}

		protected override void HandleOnPlayerSuitVisualsUpdated(PlayerInfo playerInfo)
		{
		}

		private void RegisterBatInHand(MPlayerHand mPlayerHand)
		{
		}

		private void PlayerVisualsController_OnHeldWeaponVisualChanged(Transform pivot, PlayerSuitWeaponVisual suitWeaponVisual, bool isLeft)
		{
		}

		private void SetupBat(PrimeBatVisual batVisual)
		{
		}

		private void HandleBatRequestPlaySwingFx(SuitWeaponVisualTheme theme, Vector3 position)
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

		private void ShootWeapon(MPlayerHand mPlayerHand)
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
