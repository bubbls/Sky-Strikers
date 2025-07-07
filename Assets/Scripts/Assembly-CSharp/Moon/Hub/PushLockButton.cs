using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Sound;
using Moon.SNS;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Hub
{
	public class PushLockButton : MonoBehaviour
	{
		private enum State
		{
			Idle = 0,
			Locked = 1
		}

		[SerializeField]
		private SoundInfo _sfxPressed;

		[SerializeField]
		private Transform _pivot;

		[SerializeField]
		private Transform _idlePivot;

		[SerializeField]
		private Transform _pushedPivot;

		[SerializeField]
		private EnableBehaviour? _enableBehaviour;

		[SerializeField]
		private bool _doMove;

		[SerializeField]
		private bool _doRotation;

		[SerializeField]
		private float _animDuration;

		private Sequence? _sequence;

		private State _state;

		public new bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action? OnTouched
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

		public event Action? OnUnlocked
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

		private void OnDestroy()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void Press()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void Unlock()
		{
		}

		private void DoAnimation(bool isPushing)
		{
		}
	}
}
