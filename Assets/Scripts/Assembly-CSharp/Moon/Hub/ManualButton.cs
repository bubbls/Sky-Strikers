using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Sound;
using DP.Takeaway.Utils;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	public class ManualButton : MonoBehaviour
	{
		[SerializeField]
		private SoundInfo _sfxPressed;

		[SerializeField]
		private DOTweenAnimation? _tweenAnimation;

		[SerializeField]
		private bool _isEnabled;

		protected readonly Cooldown _cd;

		public bool IsEnabled => false;

		public event Action? OnPressed
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

		public event Action? OnEnabled
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

		[Preserve]
		[Button(null, EButtonEnableMode.Always)]
		public void Press()
		{
		}

		protected virtual void AnimatePress()
		{
		}

		protected void PlayPressedSfx()
		{
		}

		private void OnDestroy()
		{
		}

		public virtual void SetEnable(bool enable)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void ToggleEnable()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void ToggleDisable()
		{
		}
	}
}
