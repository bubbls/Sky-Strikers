using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Moon.Hub;
using UnityEngine;

namespace Moon
{
	public class ManualHoldButton : ManualButton
	{
		[SerializeField]
		private Transform buttonPivot;

		[SerializeField]
		private float _pressDuration;

		[SerializeField]
		private float _minHoldTime;

		[SerializeField]
		private Transform _holdPivot;

		[SerializeField]
		private Transform _releasePivot;

		private bool _isTrackingHold;

		private bool _isHolding;

		private float _holdStartTime;

		private Sequence _moveSequence;

		public event Action OnHold
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

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		public void CheckForHold()
		{
		}

		public void TryPressOrReleaseHold()
		{
		}

		protected override void AnimatePress()
		{
		}

		private void Release()
		{
		}

		private float CalculateDuration(float distance, float totalDistance, float defaultDuration)
		{
			return 0f;
		}
	}
}
