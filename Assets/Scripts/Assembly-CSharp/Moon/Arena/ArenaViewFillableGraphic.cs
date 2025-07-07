using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Arena
{
	[ExecuteInEditMode]
	public class ArenaViewFillableGraphic : MonoBehaviour, IDisposable
	{
		private static readonly int FillAmountProperty;

		private static readonly int FillAngleProperty;

		private static readonly int InvertProperty;

		private static readonly int FillCenterYProperty;

		[SerializeField]
		private Image _targetGraphic;

		[SerializeField]
		private Ease _fillEase;

		[SerializeField]
		private float _fillDuration;

		[SerializeField]
		private AnimationCurve _fillAngleCurve;

		[SerializeField]
		private AnimationCurve _fillCenterYOffsetCurve;

		[SerializeField]
		private bool _invertCurve;

		[Space(5f)]
		[Header("Editor Only")]
		[SerializeField]
		private bool _executeInEditMode;

		private Sequence _fillSequence;

		private float _targetFill;

		private Material _material;

		private bool _isInitialized;

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void Dispose()
		{
		}

		private float GetFillAmountFromCurve(float time)
		{
			return 0f;
		}

		private float GetCenterYOffsetFromCurve(float time)
		{
			return 0f;
		}

		public void SetFillInstantly(float targetFill)
		{
		}

		public Tween FillTo(float targetFill, float? customFillDuration = null)
		{
			return null;
		}

		private void KillSequence()
		{
		}
	}
}
