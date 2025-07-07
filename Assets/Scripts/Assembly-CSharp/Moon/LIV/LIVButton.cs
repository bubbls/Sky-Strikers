using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using Moon.XRSystem;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVButton : MonoBehaviour
	{
		[SerializeField]
		protected Transform _visual;

		[SerializeField]
		private GameObject _ui;

		[SerializeField]
		protected Transform _pressedPoint;

		[SerializeField]
		protected Transform _releasedPoint;

		[SerializeField]
		protected float _animateDuration;

		[SerializeField]
		private Trigger _trigger;

		[Header("Sound")]
		[SerializeField]
		protected SoundInfo _pressedSoundInfo;

		private Sequence _sequence;

		public bool IsEnabled { get; private set; }

		protected bool IsActive { get; private set; }

		public event Action OnPressed
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

		public void ToggleInteraction(bool isEnabled)
		{
		}

		public void ToggleActivation(bool isActive)
		{
		}

		protected virtual void UpdateInteractionVisuals(bool isEnabled)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void HandleOnEnter(Collider other)
		{
		}

		public virtual void Press(UIInteractorType interactorType)
		{
		}

		protected void NotifyOnPressed()
		{
		}

		protected virtual void UpdateVisuals()
		{
		}
	}
}
