using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Player.Ability
{
	public abstract class AbilityChargeHandler
	{
		private float _previousLocalBoostFuel;

		public abstract float CurrentCharge { get; }

		protected float RemoteCharge { get; private set; }

		public event Action OnChargeFull
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnChargeEmpty
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected AbilityChargeHandler(float initialCharge)
		{
		}

		protected void RegisterIndicators<T>(GameObject indicatorParent) where T : ProgressIndicator
		{
		}

		protected abstract void ClearIndicators();

		public abstract void SetCharge(float charge);

		protected abstract bool TrySetupChargeIndicator(in ProgressIndicator chargeIndicator);

		public void SetRemoteCharge(float charge)
		{
		}

		public abstract void SyncWithRemoteCharge();

		protected void TrackAndNotifyChargeChange()
		{
		}
	}
}
