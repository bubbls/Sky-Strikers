using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.CreativeMode
{
	public class Interactor : MonoBehaviour
	{
		[SerializeField]
		private Transform _indicator;

		[SerializeField]
		private Renderer _indicatorRenderer;

		[SerializeField]
		private Image _loadingIndicator;

		private Sequence _sequence;

		private Tween _tween;

		private Placeable _placeable;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void IndicateTouchedPlaceable()
		{
		}

		public void ProcessInputAction(Transform head, MXRInputAction inputAction)
		{
		}

		public void UpdateLoadingIndicator(Action callback)
		{
		}

		private void KillTween()
		{
		}

		private void KillSequence()
		{
		}

		public void CancelLoading()
		{
		}
	}
}
