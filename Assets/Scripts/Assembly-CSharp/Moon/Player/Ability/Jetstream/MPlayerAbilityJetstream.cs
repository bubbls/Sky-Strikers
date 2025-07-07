using System;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	[OrderAfter(new Type[] { typeof(HitboxManager) })]
	[NetworkBehaviourWeaved(0)]
	public class MPlayerAbilityJetstream : MPlayerAbility
	{
		[SerializeField]
		private MPlayerAbilityWeaponManager _weaponManager;

		[SerializeField]
		private JetstreamBoostMovement _boostMovement;

		[SerializeField]
		private JetstreamBallSucker _jetstreamBallSucker;

		[SerializeField]
		private JetstreamBlastedBallController _blastedBlastedBallController;

		[SerializeField]
		private float _handVelocityMultiplier;

		[SerializeField]
		private JetstreamAbilityFx _playmakerAbilityFx;

		private static Changed<MPlayerAbilityJetstream> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPlayerAbilityJetstream> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPlayerAbilityJetstream> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		protected override void HandleOnSpawned()
		{
		}

		protected override void HandleResetAbility()
		{
		}

		private void ConfigureHands(params MPlayerHand[] hands)
		{
		}

		protected override void HandleOnPlayerSuitVisualsUpdated(PlayerInfo playerInfo)
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

		private void JetstreamBallSucker_OnSuckerShot(MPlayerHand mPlayerHand, MBall ball, bool usedAmmo)
		{
		}

		protected override void OnTriggerHold(MPlayerHand mPlayerHand)
		{
		}

		protected override void OnTriggerReleased(MPlayerHand mPlayerHand)
		{
		}

		protected override void OnGrabPressed(MPlayerHand mPlayerHand)
		{
		}

		private void TrySwitchBoostingHandOrDisableBoostMode(MPlayerHand handWithChangedInput)
		{
		}

		private void WeaponController_OnIsHoldingWeaponChanged(MWeaponController weaponController, bool isHoldingWeapon)
		{
		}

		private void IssueDropCommand(MPlayerHand mPlayerHand)
		{
		}

		private void BlastedBallController_OnBallControlTimeExpired(MPlayerHand hand)
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
