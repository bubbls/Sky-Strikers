using System;
using System.Runtime.CompilerServices;
using Moon.XRSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Moon
{
	public class UIPhysicalScrollRectTrigger : MonoBehaviour
	{
		private ScrollRect _scrollRect;

		[SerializeField]
		private float _startScrollThreshold;

		[SerializeField]
		private float _scrollSensitivity;

		[SerializeField]
		private float _minScrollDeltaForHaptic;

		[SerializeField]
		private Transform _cursor;

		[SerializeField]
		private float _decelerationRate;

		[SerializeField]
		private float _maxVelocity;

		[SerializeField]
		private float _overshootMargin;

		private Vector3 _initialFingerPosition;

		private Vector3 _previousFingerPosition;

		private bool _isOnScrollCollider;

		private PlayerFingerUIInteractor _fingerInteractor;

		private PointerEventData _pointerEventData;

		private RectTransform _rectTransform;

		private bool _scrollingAllowed;

		private bool _isInertiaActive;

		private Vector3 _currentFingerPosition;

		private Vector3 _fingerDelta;

		private Vector2 _scrollDelta;

		private Vector2 _inertialVelocity;

		private Vector3 _cachedScrollRectForward;

		private float _normalizedPosition;

		private float _cachedDistance;

		private bool _hasScrollRect;

		public bool IsScrolling { get; private set; }

		public event Action OnScrollStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnScrollEnd
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void RegisterScrollRect(ScrollRect scrollRect)
		{
		}

		public void UnregisterScrollRect()
		{
		}

		public void TryRegisterInteractor(PlayerFingerUIInteractor interactor)
		{
		}

		public void TryUnregisterInteractor(PlayerFingerUIInteractor interactor)
		{
		}

		public void ExecuteUpdate()
		{
		}

		private void HandleScroll()
		{
		}

		private void ApplyInertia()
		{
		}

		public void EndScroll()
		{
		}

		private Vector3 ProjectToScrollRectPlane(Vector3 fingerPosition)
		{
			return default(Vector3);
		}

		public void ToggleScrollingAllowed(bool scrollingAllowed)
		{
		}
	}
}
