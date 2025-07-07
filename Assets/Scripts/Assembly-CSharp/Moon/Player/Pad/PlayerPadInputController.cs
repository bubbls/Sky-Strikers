using System;
using System.Runtime.CompilerServices;
using Moon.AI.VisualScripting;
using Moon.XRSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Player.Pad
{
	public class PlayerPadInputController : MonoBehaviour
	{
		[SerializeField]
		private UIPhysicalScrollRectTrigger _scrollRectTrigger;

		[SerializeField]
		private UIScrollRectManualScroller _scrollRectManualScroller;

		[SerializeField]
		private OverlapShapeDesc _overlapShapeDesc;

		[SerializeField]
		private PlayerPadNavigationButton _homeButton;

		[SerializeField]
		private PlayerPadNavigationButton _navigationUpButton;

		[SerializeField]
		private PlayerPadNavigationButton _navigationDownButton;

		[SerializeField]
		private Collider _screenTrigger;

		private bool _interactionEnabled;

		private ScrollRect _scrollRect;

		private bool _hasScrollRect;

		private bool _isScrollRectScrollable;

		private bool _canScrollUp;

		private bool _cachedCanScrollUp;

		private bool _canScrollDown;

		private bool _cachedCanScrollDown;

		private bool _hasScrollRectChange;

		private float _lastContentTransformSize;

		private Vector3 _lastContentTransformLocalPosition;

		public event Action OnHomeButtonPressed
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

		public void Initialize()
		{
		}

		private void TryPressButton(Vector3 worldTapPosition, UIInteractorType uiInteractorType)
		{
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnScrollValueChanged(Vector2 scrollPosition)
		{
		}

		private void ValidateContent(bool forceUpdateButtons)
		{
		}

		private void CheckIfHasContentForScrolling()
		{
		}

		private void CheckAvailableScrollDirections(bool forceUpdateButtons)
		{
		}

		public void ToggleScreenInput(bool inputEnabled)
		{
		}

		public void PrepareForAppChange()
		{
		}

		public void HandleOnAppOpened()
		{
		}

		public void RegisterScrollRect(ScrollRect scrollRect)
		{
		}

		public void UnRegisterScrollRect(ScrollRect scrollRect)
		{
		}

		private void ScrollRectTrigger_OnScrollStart()
		{
		}

		private void ScrollRectTrigger_OnScrollEnd()
		{
		}

		private void TogglePhysicalButtons(bool enable)
		{
		}

		private void HandleNavigationButtonPressed(PadNavigationButtonDirection navigationButtonType)
		{
		}

		private void HandleNavigationButtonHold(PadNavigationButtonDirection navigationButtonType)
		{
		}
	}
}
