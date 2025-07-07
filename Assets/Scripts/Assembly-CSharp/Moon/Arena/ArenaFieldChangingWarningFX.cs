using DG.Tweening;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Arena
{
	public class ArenaFieldChangingWarningFX : MonoBehaviour
	{
		private static readonly int WarningRangePropertyID;

		private static readonly int AlphaPropertyID;

		[SerializeField]
		private SoundInfo _warningSfx;

		[Header("Air Wall")]
		[SerializeField]
		private MeshRenderer _airWallMeshRenderer;

		[SerializeField]
		private float _airWallFadeInAlpha;

		[SerializeField]
		private float _airWallFadeInDuration;

		[SerializeField]
		private float _airWallWarningRangeMin;

		[SerializeField]
		private float _airWallWarningRangeMax;

		[SerializeField]
		private float _airWallWarningRangeMoveInDuration;

		[Space(5f)]
		[SerializeField]
		private float _airWallFadeOutDuration;

		[SerializeField]
		private float _airWallWarningRangeMoveOutDuration;

		[Space(7f)]
		[SerializeField]
		[Header("Warning Strip")]
		private MeshRenderer _warningStrip;

		[SerializeField]
		private float _warningStripFadeInAlpha;

		[SerializeField]
		private float _warningStripFadeInDuration;

		[SerializeField]
		private float _warningStripFadeOutDuration;

		private Sequence _sequence;

		private bool _isInitialized;

		private int _warningSfxId;

		private void TryInitialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void ToggleWarning(bool show)
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
