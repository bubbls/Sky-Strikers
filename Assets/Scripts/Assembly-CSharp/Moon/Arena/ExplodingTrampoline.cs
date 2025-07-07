using DG.Tweening;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Arena
{
	public class ExplodingTrampoline : MonoBehaviour
	{
		private static readonly int _waveFlowProperty;

		private static readonly int _waveSoftProperty;

		private static readonly int _waveHeightProperty;

		[SerializeField]
		private FxExplosion _explosionFxPrefab;

		[SerializeField]
		private float _warningStartAtRemainingTime;

		[SerializeField]
		private SoundInfo _warningSfx;

		[SerializeField]
		private SoundInfo _lastWarningSfx;

		[SerializeField]
		private MeshRenderer _meshRenderer;

		[SerializeField]
		private float _waveHeight;

		[SerializeField]
		private float _warningWaveBaseDuration;

		[SerializeField]
		private float _warningWaveMinDuration;

		[SerializeField]
		private float _finalWarningWaveDuration;

		[SerializeField]
		private float _finalWarningWaveSoft;

		private Tween _waveTween;

		public FxExplosion ExplosionFxPrefab => null;

		public void NotifyWarningFx(int remainingTime)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void DoWave(float target, float duration)
		{
		}

		private void DoFinalWarning(float target, float duration)
		{
		}
	}
}
