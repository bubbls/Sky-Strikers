using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DP.Takeaway.Sound;
using UnityEngine;

namespace Moon.Arena
{
	public class BallSpawningIndicator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDisableBall_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public BallSpawningIndicator _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDisableBall_003Ed__15(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private const string AnimationName = "BallEffect";

		private const string BgStartAnimationName = "BallEffect_Background";

		private const string BgEndAnimationName = "BallEffect_Background_End";

		[SerializeField]
		private GameObject _ball;

		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private Animator _bgAnimator;

		[SerializeField]
		private SoundInfo _ballAppearSoundInfo;

		[SerializeField]
		private SoundInfo _explodeSoundInfo;

		private float _animationDuration;

		private bool _isInitialized;

		private float _animatorSpeed;

		private void Initialize()
		{
		}

		private void OnDisable()
		{
		}

		private float GetAnimationLength(RuntimeAnimatorController animatorController, string clipName)
		{
			return 0f;
		}

		public void Show(float ballSpawnRemainingTime)
		{
		}

		[IteratorStateMachine(typeof(_003CDisableBall_003Ed__15))]
		private IEnumerator DisableBall(float delay)
		{
			return null;
		}

		public void Explode()
		{
		}
	}
}
