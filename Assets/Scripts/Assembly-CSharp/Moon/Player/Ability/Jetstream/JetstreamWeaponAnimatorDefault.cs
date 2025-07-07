using DG.Tweening;
using UnityEngine;

namespace Moon.Player.Ability.Jetstream
{
	public class JetstreamWeaponAnimatorDefault : JetstreamWeaponAnimator
	{
		private enum State
		{
			Sucking = 0,
			ShotBallControl = 1
		}

		private const float CloseAnimationAdditionalTime = 0.12f;

		private const int BallControlLayerIndex = 1;

		private static readonly int _openHash;

		private static readonly int _closeHash;

		[SerializeField]
		private float _animationSpeed;

		[SerializeField]
		private float _suckingRangeLerp;

		[Header("Outer Ring")]
		[SerializeField]
		private Transform _outerRing;

		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private float _outerRingDefaultRotateSpeed;

		[SerializeField]
		private float _outerRingCanShootRotateSpeed;

		[SerializeField]
		private float _readyToShootLayerChangeSpeed;

		[SerializeField]
		private float _outRingWeightChangeSpeed;

		[Header("Center Point")]
		[SerializeField]
		private Transform _centerRotatingPoint;

		[SerializeField]
		private AnimationCurve _rotateSpeedBallDistCurve;

		[SerializeField]
		private float _speedChangeSpeed;

		[SerializeField]
		private float _noBallRotateSpeed;

		private Vector3 _rotateAxis;

		private Sequence _curAnimationSequence;

		private Transform _ballTransform;

		private bool _isAnimatingOut;

		private float _animateOutCompleteTime;

		private float _currentAnimationTime;

		private float _targetCenterRotateSpeed;

		private float _curCenterRotateSpeed;

		private float _ballDistanceFromCenter;

		private float _curOuterRingRotateSpeed;

		private float _curBallControlLayerWeight;

		private float _targetBallControlLayerWeight;

		private bool _shouldResetAnimator;

		private bool _isBallInBlastArea;

		private State _currentState;

		public override void Initialize(PlayerVisualAttachPointType attachPointType)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDisable()
		{
		}

		private void ResetActiveValues()
		{
		}

		public override void AnimateIn()
		{
		}

		public override void AnimateOut()
		{
		}

		public override void HandleOnBallEnteredWeaponArea(Transform ball)
		{
		}

		public override void HandleBallBlastAreaStatusChanged(bool isBallInBlastArea)
		{
		}

		public override void HandleOnBallExitWeaponArea()
		{
		}

		public override void EnterBallShotState(Transform ballTransform, float ballControlDuration)
		{
		}

		public override void AnimateSuckingRange(float t)
		{
		}

		private bool TrySwitchToCloseAnimation(out float animationDuration)
		{
			animationDuration = default(float);
			return false;
		}

		private void AccelerateRotation(in Transform transformToRotate, ref float currentRotationSpeed, in float targetRotationSpeed, in float changeSpeed)
		{
		}

		private void TweenResetRotatedTransforms(float duration)
		{
		}

		private void SetAnimatorSpeed(float speed)
		{
		}
	}
}
