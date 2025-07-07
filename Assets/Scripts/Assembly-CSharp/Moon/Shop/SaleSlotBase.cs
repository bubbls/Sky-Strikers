using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Moon.Economy;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Moon.Shop
{
	public abstract class SaleSlotBase : MonoBehaviour
	{
		public enum State
		{
			NoSku = 0,
			Updating = 1,
			Idle = 2,
			WaitConfirmation = 3,
			Purchasing = 4,
			Purchased = 5,
			Error = 6,
			InsufficientFunds = 7
		}

		public const int MaxDisplayPrices = 2;

		public State CurrentState { get; protected set; }

		public virtual string SlotName => null;

		public virtual bool IsValid => false;

		public virtual SkuData? SkuData => null;

		public event Action? OnSlotUpdated
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

		public event Action? OnTryUpdateMainStageSlot
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

		public abstract int GetDisplayPrices(out Dictionary<PriceIndex, CatalogPriceAmount> displayPrices);

		protected void RaiseSlotUpdated()
		{
		}

		protected void RaiseTryUpdateMainStageSlot()
		{
		}

		public virtual TimeSpan GetCountdown()
		{
			return default(TimeSpan);
		}
	}
}
