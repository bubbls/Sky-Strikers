namespace Moon.Player.Ability
{
	public class AbilityChargeConsumer
	{
		private float _startConsumptionTime;

		private float _endConsumptionTime;

		private float _chargeStartAmount;

		private bool _isConsumingCharge;

		public void StartChargeConsumption(in float chargeValue, float consumeDuration)
		{
		}

		public float ElapsedConsumptionTime()
		{
			return 0f;
		}

		public void StopChargeConsumption(in float chargeValue)
		{
		}

		public void ExecuteConsumptionUpdate(out float chargeValue)
		{
			chargeValue = default(float);
		}

		public void ResetConsumptionTracking(in float chargeValue, bool resetStartEndTime, float consumptionDuration)
		{
		}
	}
}
