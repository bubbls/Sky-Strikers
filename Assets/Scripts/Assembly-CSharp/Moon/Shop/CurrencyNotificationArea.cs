using System;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.Shop
{
	public class CurrencyNotificationArea : MonoBehaviour
	{
		[Flags]
		public enum SupportedCurrencies
		{
			Uncertain = 0,
			FreeCurrency = 2,
			Juice = 4
		}

		[SerializeField]
		private OverlapShapeDesc _overlapShapeDesc;

		[SerializeField]
		private SupportedCurrencies _supportedCurrencies;

		[SerializeField]
		private CurrencyPad _pad;

		private Cooldown _cooldown;

		private bool _isOn;

		private IMessageSubscriber _subscriber;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private bool CheckSinglePlayerInternal()
		{
			return false;
		}

		public void ChangeType(SupportedCurrencies supportedCurrencies, bool notify = false)
		{
		}
	}
}
