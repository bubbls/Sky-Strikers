using System;
using DG.Tweening;
using UnityEngine;

namespace Moon.Shop.Sale
{
	[Obsolete]
	public class ShopSaleBatProduct : ShopSaleProduct
	{
		private const float MinAnimationTime = 2f;

		private static readonly int SpeedMultiplierParam;

		[SerializeField]
		private BatTierVisualsConfigs _tierVisualsConfigs;

		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private float _speedMultiplierTweenSpeed;

		private Tween _speedMultiplierTween;

		private float _animatorSpeed;

		private float _spinStartTime;

		public override void Initialize(BaseItemData productData)
		{
		}

		protected override void HandleOnPurchasingStateEntered()
		{
		}

		protected override void HandleOnPurchaseStateExitedInternal()
		{
		}

		private void SetSpeedMultiplierTarget(float target, float delay = 0f)
		{
		}
	}
}
