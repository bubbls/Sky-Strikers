using UnityEngine;

namespace Moon.Player.Visual
{
	public class SharkBatVisual : PrimeBatVisual
	{
		private const int DefaultLayerIndex = 0;

		private const int MovementLayerIndex = 1;

		private static readonly int HorizontalMovementProperty;

		private static readonly int VerticalMovementProperty;

		private static readonly int MovementBlendTree;

		private static readonly int IdleAnimationName;

		private static readonly int EmptyAnimationName;

		[SerializeField]
		private float _minVelocityForBend;

		[SerializeField]
		private float _blendSmoothTime;

		[SerializeField]
		private float _blendMaxSpeed;

		[SerializeField]
		private Transform _tracker;

		[SerializeField]
		private Transform _priceTagPoint;

		private Vector3 _cachedVelocity;

		private Vector3 _currentPosition;

		private float _targetHorizontalBlend;

		private float _targetVerticalBlend;

		private float _currentVerticalVelocity;

		private float _currentHorizontalVelocity;

		private bool _isPlayingIdle;

		protected override void InitializeInternal()
		{
		}

		private void OnEnable()
		{
		}

		protected override void HandleShow()
		{
		}

		private void Update()
		{
		}

		private void HandleMovementLayer()
		{
		}

		private void PlayMovement()
		{
		}

		private void PlayIdle()
		{
		}
	}
}
