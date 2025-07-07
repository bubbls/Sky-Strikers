using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Arena
{
	public class BallHittingParameters : SingleMonoBehaviour<BallHittingParameters, DefaultSingleMonoBehaviourSettings<BallHittingParameters>>
	{
		[SerializeField]
		private float _minHitStrengthForHitFX;

		[SerializeField]
		private float _delayBetweenHitFx;

		[SerializeField]
		private float _minPunchScale;

		[SerializeField]
		private float _maxPunchScale;

		[SerializeField]
		private float _punchSqueezeSpeed;

		[SerializeField]
		private float _maxForce;

		[SerializeField]
		private float _heavyStrikeForceP;

		[SerializeField]
		private AnimationCurve _hapticImpulseAmpCurve;

		[SerializeField]
		private AnimationCurve _hapticImpulseDurationCurve;

		[SerializeField]
		[ColorUsage(false, true)]
		private Color[] _hitHighlightColors;

		[SerializeField]
		[Space(7f)]
		[Header("Tagging")]
		private float _ballTagDuration;

		[SerializeField]
		private int _maxBallHitCountForTag;

		[SerializeField]
		private HitSourceID _taggableHitSources;

		[SerializeField]
		private HitSourceID _ignoreTagsHitSources;

		[SerializeField]
		private HitSourceID _hitCountTaggableHitSources;

		public float MinHitStrengthForHitFX => 0f;

		public float DelayBetweenHitFx => 0f;

		public float PunchSqueezeSpeed => 0f;

		public Color[] HitHighlightColors => null;

		public float BallTagDuration => 0f;

		public int MaxBallHitCountForTag => 0;

		public bool IsHardHit(Vector3 force)
		{
			return false;
		}

		public float GetPunchScale(Vector3 force)
		{
			return 0f;
		}

		public HapticImpulse GetHapticImpulseForForce(float force)
		{
			return null;
		}

		public bool CanTagBallFromHitSource(HitSourceID hitInfoHitSourceID)
		{
			return false;
		}

		public bool CanCountHitFromHitSource(HitSourceID hitInfoHitSourceID)
		{
			return false;
		}
	}
}
