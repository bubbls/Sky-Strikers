using DG.Tweening;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaFieldChangingWarningStrip : MonoBehaviour
	{
		private static readonly int AlphaPropertyID;

		[SerializeField]
		[Space(7f)]
		private MeshRenderer _warningStrip;

		[SerializeField]
		private float _warningStripFadeInAlpha;

		[SerializeField]
		private float _warningStripFadeInDuration;

		[SerializeField]
		private float _warningStripFadeOutDuration;

		private Tween _animationTween;

		private bool _isInitialized;

		private void TryInitialize()
		{
		}

		public void ToggleWarningStrip(bool show)
		{
		}

		private void Play()
		{
		}

		private void Stop()
		{
		}
	}
}
