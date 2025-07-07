using System.Collections.Generic;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class JetstreamBoostChargeHandler : AbilityChargeHandler
	{
		private const float RemoteSyncLerpTime = 5f;

		private float _currentLocalBoostFuel;

		private readonly AbilityRecharger _recharger;

		private readonly AbilityChargeConsumer _chargeConsumer;

		private readonly List<ProgressIndicator> _jetstreamBoostChargeIndicators;

		public override float CurrentCharge => 0f;

		public JetstreamBoostChargeHandler(float initialCharge)
			: base(0f)
		{
		}

		public void FindIndicatorVisuals(GameObject indicatorsContainer)
		{
		}

		public override void SetCharge(float charge)
		{
		}

		protected override void ClearIndicators()
		{
		}

		protected override bool TrySetupChargeIndicator(in ProgressIndicator chargeIndicator)
		{
			return false;
		}

		public bool HasFuelForBoost()
		{
			return false;
		}

		public void StartBoostTracking(float boostDuration)
		{
		}

		public float ElapsedBoostTime()
		{
			return 0f;
		}

		public void StopBoostTracking(float rechargeDelay, float rechargeDuration)
		{
		}

		public bool TryRecharge()
		{
			return false;
		}

		private void UpdateIndicatorFill()
		{
		}

		public override void SyncWithRemoteCharge()
		{
		}

		public void ExecuteBoostingUpdate()
		{
		}

		public void ResetBoostTracking(bool isBoosting, float boostDuration)
		{
		}
	}
}
