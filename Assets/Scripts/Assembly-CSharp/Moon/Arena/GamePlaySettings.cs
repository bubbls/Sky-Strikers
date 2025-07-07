using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Arena
{
	[CreateAssetMenu(menuName = "SkyStrikersVR/Create GamePlaySettings", fileName = "GamePlaySettings", order = 0)]
	public class GamePlaySettings : SingleScriptableObject<GamePlaySettings, DefaultResourcePathProvider<GamePlaySettings>>
	{
		[SerializeField]
		[Header("Ball")]
		private float _maxBallSpeed;

		[SerializeField]
		private float _ballSpawnDestroyAreaRadius;

		[SerializeField]
		private LayerMask _ballSpawnDestroyAreaLayerMask;

		[SerializeField]
		[Header("Bat")]
		private float _hitterBodyVelocityMultiplier;

		[SerializeField]
		private float _batSwingSmoothWindow;

		[SerializeField]
		private AnimationCurve _batBatSwingMultiplierCurve;

		[SerializeField]
		private float _batSwingVelocityCurveMultiplier;

		private const float BatVelocityMeterInitYPosition = -0.7640001f;

		[SerializeField]
		private float _batVelocityMeterYPositionRatio;

		[SerializeField]
		private float _batSwingMinVelocity;

		[SerializeField]
		private float _batSwingMaxVelocity;

		[SerializeField]
		private HapticImpulse _defaultUIButtonHapticImpulse;

		[SerializeField]
		private HapticImpulse _defaultUIScrollingHapticImpulse;

		[Header("Rocket Explosion")]
		[SerializeField]
		private ExplosionConfiguration _defaultExplosionConfiguration;

		public float MaxBallSpeed => 0f;

		public float BallSpawnDestroyAreaRadius => 0f;

		public LayerMask BallSpawnDestroyAreaLayerMask => default(LayerMask);

		public float HitterBodyVelocityMultiplier => 0f;

		public float BatSwingSmoothWindow => 0f;

		public AnimationCurve BatSwingMultiplierCurve => null;

		public float BatSwingVelocityCurveMultiplier => 0f;

		public float BatVelocityMeterYPosition => 0f;

		public float BatSwingMinVelocity => 0f;

		public float BatSwingMaxVelocity => 0f;

		public HapticImpulse DefaultUIButtonHapticImpulse => null;

		public HapticImpulse DefaultUIBScrollingHapticImpulse => null;

		public ExplosionConfiguration DefaultExplosionConfiguration => null;

		public void SetExplosionExecutionTicksCount(int ticksCount)
		{
		}
	}
}
