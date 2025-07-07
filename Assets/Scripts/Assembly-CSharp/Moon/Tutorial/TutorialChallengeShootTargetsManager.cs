using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Tutorial
{
	public class TutorialChallengeShootTargetsManager : TutorialChallenge
	{
		[CompilerGenerated]
		private sealed class _003CStartChallengeRoutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TutorialChallengeShootTargetsManager _003C_003E4__this;

			private List<TutorialChallengeShootTarget>.Enumerator _003C_003E7__wrap1;

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
			public _003CStartChallengeRoutine_003Ed__8(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Header("Shoot Targets Challenge Config")]
		[SerializeField]
		private List<TutorialChallengeShootTarget> _shootTargets;

		[SerializeField]
		private float _shootTargetMoveIntervalDelay;

		private int _shootTargetsCount;

		private Coroutine _startChallengeRoutine;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public override void StartChallenge()
		{
		}

		private void StopChallengeRoutine()
		{
		}

		[IteratorStateMachine(typeof(_003CStartChallengeRoutine_003Ed__8))]
		private IEnumerator StartChallengeRoutine()
		{
			return null;
		}

		public void OnShootTargetHit()
		{
		}

		public override void SucceedChallenge()
		{
		}
	}
}
