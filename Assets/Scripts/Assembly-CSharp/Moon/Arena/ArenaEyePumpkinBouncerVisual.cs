using System;
using DG.Tweening;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaEyePumpkinBouncerVisual : MonoBehaviour
	{
		[SerializeField]
		private GameObject _tearVisual;

		[SerializeField]
		private GameObject _platformVisual;

		[SerializeField]
		private MeshRenderer _tearMeshRenderer;

		[SerializeField]
		private GameObject _tearExplosionPrefab;

		[SerializeField]
		private Transform _tearExplosionSpawnPoint;

		[SerializeField]
		private float _tearExplosionDestroyDelay;

		[SerializeField]
		private GameObject _soundsTriggerPrefab;

		[SerializeField]
		private Transform _soundsTriggerSpawnPoint;

		[SerializeField]
		private float _waveMinDisableValue;

		[SerializeField]
		private float _waveMinEnableValue;

		[SerializeField]
		private float _waveMinFullValue;

		[SerializeField]
		private float _waveTweenDuration;

		[SerializeField]
		private float _waveLastWarningTweenDuration;

		[SerializeField]
		private float _lifeTime;

		private static readonly int _waveFlowProperty;

		private static readonly int _waveMinProperty;

		private GameObject _tearExplosion;

		private GameObject _soundsTrigger;

		private ArenaEyePumpkinBouncerSoundTrigger _bouncerSoundsTrigger;

		private Tween _waveTween;

		public void Initialize()
		{
		}

		public void ToggleTearVisual(bool enable)
		{
		}

		public void TogglePlatformVisual(bool enable)
		{
		}

		public void DestroyLocalSoundsAndEffects()
		{
		}

		public void ToggleRangeVisual(bool enable)
		{
		}

		public void ToggleLastWarningVisual(bool enable)
		{
		}

		public void ShowPlatform(Action callback)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
