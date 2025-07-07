using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Sound;
using Moon.XRSystem;
using NaughtyAttributes;
using UnityEngine;

namespace Moon
{
	public class UIButton : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rectTransform;

		[SerializeField]
		private bool _interactionEnabled;

		[SerializeField]
		private SoundPlayerStub _soundPlayerStub;

		[SerializeField]
		private bool _pressOnRelease;

		[SerializeField]
		private float _delayBetweenPresses;

		[SerializeField]
		private Collider _collider;

		private PlayerFingerUIInteractor _pendingUiInteractor;

		private float _nextPressTime;

		public RectTransform RectTransform => null;

		public bool InteractionEnabled => false;

		public event Action OnButtonPressed
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

		private void Start()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void PressButton()
		{
		}

		public void ForcePressButton(UIInteractorType interactorType)
		{
		}

		private void HandleOnButtonPressed(UIInteractorType interactorType)
		{
		}

		private void HandlePress(UIInteractorType interactorType)
		{
		}

		protected virtual void HandleOnButtonPressedInternal()
		{
		}

		public void ToggleInteraction(bool enable)
		{
		}

		protected virtual void HandleOnInteractionStateChanged(bool interactionEnabled)
		{
		}
	}
}
