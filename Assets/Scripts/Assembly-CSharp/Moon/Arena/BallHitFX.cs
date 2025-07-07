using System;
using UnityEngine;

namespace Moon.Arena
{
	public class BallHitFX : MonoBehaviour, IPrewarmable
	{
		[Serializable]
		private class BallHitFXConfig
		{
			[SerializeField]
			private TeamNo _targetTeam;

			[SerializeField]
			private ParticleSystem _smallHitFx;

			[SerializeField]
			private ParticleSystem _mediumHitFx;

			[SerializeField]
			private ParticleSystem _largeHitFx;

			public TeamNo TargetTeam => default(TeamNo);

			public ParticleSystem SmallHitFx => null;

			public ParticleSystem MediumHitFx => null;

			public ParticleSystem LargeHitFx => null;
		}

		[SerializeField]
		private BallHitFXConfig[] _hitFXConfig;

		public void PlayFX(TeamNo teamNo, float hitStrength)
		{
		}

		private bool TryGetHitFXConfigForTeam(TeamNo teamNo, out BallHitFXConfig config)
		{
			config = null;
			return false;
		}

		public void Prewarm()
		{
		}
	}
}
