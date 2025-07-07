using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	public class BallHitHighlight : MonoBehaviour
	{
		private static readonly int _emissionColor;

		private static readonly int _emissionInt;

		[SerializeField]
		private MeshRenderer _hitHighlightRenderer;

		[SerializeField]
		private float _hitHighlightStayDuration;

		[SerializeField]
		private AnimationCurve _hitHighlightAlphaCurve;

		[SerializeField]
		private AnimationCurve _hitHighlightFadeCurve;

		private NetworkRunner _runner;

		private Color _hitHighlightColor;

		private float _elapsedHitFadeDuration;

		private double _lastHitTime;

		private float _highlightAlphaOnHit;

		private float _targetHitHighlightAlpha;

		private float _targetHitHighlightDuration;

		public void Initialize(ref NetworkRunner runner)
		{
		}

		public void Execute()
		{
		}

		public void ShowHighlight(TeamNo lastHitterTeam, float hitStrength)
		{
		}

		private void UpdateHitHighlight()
		{
		}

		public void Reset()
		{
		}
	}
}
