namespace Moon.Player.Ability
{
	public class AbilityRecharger
	{
		private float _chargeStartTime;

		private float _chargeEndTime;

		private float _chargeStartAmount;

		private float _maxCharge;

		public void SetMaxCharge(float maxCharge)
		{
		}

		public void StartChargingTracking(in float chargeValue, float rechargeDuration, float rechargeDelay = 0f)
		{
		}

		public bool ExecuteCharge(ref float chargeValue)
		{
			return false;
		}
	}
}
