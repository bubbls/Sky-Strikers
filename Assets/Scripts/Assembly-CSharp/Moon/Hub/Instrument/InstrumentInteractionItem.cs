using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Game;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Hub.Instrument
{
	public class InstrumentInteractionItem : MonoBehaviour
	{
		[SerializeField]
		private Trigger _trigger;

		[Header("Sounds")]
		[SerializeField]
		protected List<SoundInfo> _soundInfos;

		[Header("Animation")]
		[SerializeField]
		private DOTweenAnimation _doTweenAnimation;

		[SerializeField]
		[Header("Volume Effect")]
		private List<DOTweenAnimation> _volumeDoTweenAnimations;

		protected bool _isLeftHandInteracted;

		private bool _isEnabled;

		public string Id { get; private set; }

		public event Action<bool, string> OnInteracted
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

		public void Initialize(string id)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnTriggerEnter(Collider other)
		{
		}

		protected virtual bool CanInteract(Collider other)
		{
			return false;
		}

		private void DoFeedbackAnimation()
		{
		}

		private void OnDestroy()
		{
		}

		public void DoInteractionFeedback()
		{
		}

		private void DoCompleteInteraction()
		{
		}

		protected virtual void PlaySound()
		{
		}
	}
}
