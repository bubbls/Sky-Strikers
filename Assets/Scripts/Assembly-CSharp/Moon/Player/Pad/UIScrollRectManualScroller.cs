using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class UIScrollRectManualScroller : MonoBehaviour
	{
		private enum ScrollDirection
		{
			None = 0,
			Up = 1,
			Down = 2
		}

		[SerializeField]
		private float _overshootMargin;

		[SerializeField]
		private float _normalScrollSensitivity;

		[SerializeField]
		private float _normalScrollDuration;

		[SerializeField]
		private float _bigScrollSensitivity;

		[SerializeField]
		private float _bigScrollDuration;

		private float _scrollEndTime;

		private PointerEventData _pointerEventData;

		private ScrollDirection _currentScrollDirection;

		private float _cachedNormalizedPosition;

		private ScrollRect _scrollRect;

		private bool _hasScrollRect;

		[SerializeField]
		private bool _simulateBigScroll;

		private void LateUpdate()
		{
		}

		private void OnDisable()
		{
		}

		public void ScrollUp(bool isBigScroll)
		{
		}

		public void ScrollDown(bool isBigScroll)
		{
		}

		private void Scroll(ScrollDirection targetDirection, bool isBigScroll)
		{
		}

		public void RegisterScrollRect(ScrollRect scrollRect)
		{
		}

		public void UnregisterScrollRect()
		{
		}
	}
}
