using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Tutorial
{
	public abstract class TutorialChallenge : MonoBehaviour
	{
		protected enum ChallengeId : byte
		{
			ShootMovingTargets = 0,
			RunningTrack = 1,
			ShootRingGoals = 2
		}

		[CompilerGenerated]
		private sealed class _003CBackToIdleCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutorialChallenge _003C_003E4__this;

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
			public _003CBackToIdleCoroutine_003Ed__9(int _003C_003E1__state)
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

		[Header("Challenge Config")]
		[SerializeField]
		protected ChallengeId _challengeId;

		[SerializeField]
		private TutorialChallengeFreeCurrencyReward _freeCurrencyReward;

		[SerializeField]
		private float _backToIdleDuration;

		private Coroutine _backToIdleCoroutine;

		public virtual void StartChallenge()
		{
		}

		public virtual void SucceedChallenge()
		{
		}

		public virtual void FailedChallenge()
		{
		}

		public virtual void ResetChallenge()
		{
		}

		private void StopCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CBackToIdleCoroutine_003Ed__9))]
		private IEnumerator BackToIdleCoroutine()
		{
			return null;
		}

		protected virtual void HandleBackToIdle()
		{
		}
	}
}
