using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Sound;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon
{
	public class HandHoldPressButton : MonoBehaviour
	{
		[SerializeField]
		private float _pressingToOpenPlayerListDuration;

		[SerializeField]
		private Image _progressImage;

		[SerializeField]
		private Transform _buttonVisualTransform;

		[SerializeField]
		private Transform _idlePositionPoint;

		[SerializeField]
		private Transform _pressedPositionPoint;

		[SerializeField]
		private float _buttonMoveAnimationDuration;

		[SerializeField]
		private SoundPlayerStub _soundPlayerStub;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private TMP_Text _buttonText;

		private bool _canCheckPressingButtonTimer;

		private float _pressingButtonTimer;

		private bool _isPressingButton;

		private bool _isHoldPressCompleted;

		private Sequence _sequence;

		public event Action OnHoldPressComplete
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

		public void UpdateVisuals(Sprite icon, string buttonText)
		{
		}

		public void HandleOnTriggerEnter()
		{
		}

		public void HandleOnTriggerExit()
		{
		}

		public void Select()
		{
		}

		public void Reset()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void KillSequence()
		{
		}
	}
}
