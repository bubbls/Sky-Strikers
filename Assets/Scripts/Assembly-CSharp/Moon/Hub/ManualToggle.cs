using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DP.Takeaway.Sound;
using JetBrains.Annotations;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.Hub
{
	public class ManualToggle : MonoBehaviour
	{
		[SerializeField]
		private Transform _pivot;

		[SerializeField]
		private Transform _onPivot;

		[SerializeField]
		private Transform _offPivot;

		[SerializeField]
		private SoundInfo _sfxToggle;

		[SerializeField]
		private Transform _sfxPosition;

		[SerializeField]
		private float _animDuration;

		[SerializeField]
		private bool _doMove;

		[SerializeField]
		private bool _moveLocally;

		[SerializeField]
		private bool _doRotation;

		[SerializeField]
		private bool _isOn;

		[SerializeField]
		private bool _isToggleEnabled;

		[SerializeField]
		private bool _onlyAllowToggleOn;

		private Sequence _sequence;

		private bool _skipValueChangedEvent;

		public bool IsEnabled => false;

		public bool IsOn
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public event Action OnEnabled
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

		public event Action OnValueChanged
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

		public event Action OnCompleted
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

		public void SetOnlyAllowToggleOn(bool onlyAllowToggleOn)
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetEnable(bool enable)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void ToggleEnabled()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void ToggleDisabled()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void ToggleOn()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void ToggleOff()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		public void Toggle()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		[UsedImplicitly]
		private void TweenMoveOn()
		{
		}

		[UsedImplicitly]
		[Button(null, EButtonEnableMode.Always)]
		private void TweenMoveOff()
		{
		}

		public void ForceToggle(bool isOn, bool immediate = false, bool skipValueChangedEvent = false, bool allowSfx = true)
		{
		}

		public void Toggle(bool isOn, bool immediate = false, bool skipValueChangedEvent = false, bool allowSfx = true)
		{
		}

		private void ToggleInternal(bool isOn, bool immediate = false, bool skipValueChangedEvent = false, bool allowSfx = true)
		{
		}

		private void DoMove(bool isOn, Action onComplete)
		{
		}

		private void UpdatePositionRotationImmediate()
		{
		}
	}
}
