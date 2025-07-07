using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Arena
{
	public class ArenaViewFadeableGraphic : MonoBehaviour, IDisposable
	{
		[SerializeField]
		private Graphic _targetGraphic;

		[SerializeField]
		private Ease _fadeInEase;

		[SerializeField]
		private Ease _fadeOutEase;

		[SerializeField]
		private float _fadeDuration;

		[SerializeField]
		private float _fadeOutAlpha;

		private Tween _fadeTween;

		public bool IsFadedIn { get; private set; }

		public void Dispose()
		{
		}

		private void OnDestroy()
		{
		}

		public void FadeInInstantly()
		{
		}

		public void FadeOutInstantly()
		{
		}

		public Tween FadeIn(float? customFadeDuration = null)
		{
			return null;
		}

		public void FadeOut()
		{
		}

		private void SetAlpha(float targetAlpha)
		{
		}

		private void KillTween()
		{
		}
	}
}
