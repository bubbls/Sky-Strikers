using System;
using Moon.Arena;
using UnityEngine;

namespace Moon
{
	public class BallTrailFxController : MonoBehaviour
	{
		[Serializable]
		private class TrailFXGroup
		{
			[SerializeField]
			private float _targetSpeedPercentage;

			[SerializeField]
			private ParticleSystem _particleSystem;

			private bool _isPlaying;

			public float TargetSpeedPercentage => 0f;

			public void Play()
			{
			}

			public void Stop()
			{
			}
		}

		[Serializable]
		private class TrailMaterial
		{
			[SerializeField]
			private Material _material;

			[ColorUsage(true, true)]
			[SerializeField]
			private Color[] _teamColors;

			public void SetColorForTeam(TeamNo teamNo)
			{
			}
		}

		[Serializable]
		private class TrailColorOverLifetime
		{
			[SerializeField]
			private ParticleSystem _particleSystem;

			[SerializeField]
			private Gradient[] _gradients;

			private ParticleSystem.ColorOverLifetimeModule _colorOverLifetimeModule;

			public void Initialize()
			{
			}

			public void SetColorForTeam(TeamNo teamNo)
			{
			}
		}

		[SerializeField]
		private TrailMaterial[] _teamTrails;

		[SerializeField]
		private TrailFXGroup[] _trailFxGroups;

		[SerializeField]
		private TrailColorOverLifetime[] _trailColorsOverLifetime;

		[SerializeField]
		private Transform[] _transToScale;

		private MBall _ball;

		private Vector3 _cachedBallVelocity;

		private float _cachedBallMagnitude;

		private bool _stopped;

		private TeamNo _curTeamTrail;

		private static readonly int _mainColor;

		public void Initialize(ref MBall ball, float scale)
		{
		}

		private void FixedUpdate()
		{
		}

		public void EnableTrailForTeam(TeamNo teamNo)
		{
		}

		public void TryPlayTrailFX()
		{
		}

		public void Play()
		{
		}

		public void Stop()
		{
		}
	}
}
