using System.Collections.Generic;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class BulwarpShieldChargeHandler : AbilityChargeHandler
	{
		private const float RemoteSyncLerpTime = 10f;

		private float _energyShieldCharge;

		private readonly AbilityRecharger _recharger;

		private readonly AbilityChargeConsumer _chargeConsumer;

		private List<BulwarpShieldHandIndicator> _shieldHandIndicators;

		public override float CurrentCharge => 0f;

		public BulwarpShieldChargeHandler(float initialCharge)
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

		public void StartEnergyShieldChargeConsumption(float consumeDuration)
		{
		}

		public void ExecuteEnergyShieldChargeConsumption()
		{
		}

		public void StopEnergyShieldChargeConsumption()
		{
		}

		public void StartEnergyShieldCharging(float rechargeDuration, float delay = 0f)
		{
		}

		public bool TryRecharge()
		{
			return false;
		}

		public override void SyncWithRemoteCharge()
		{
		}

		public void ForceResetEnergyShieldCharge(float charge, float consumptionDuration)
		{
		}

		private void UpdateEnergyShieldIndicator()
		{
		}
	}
}
