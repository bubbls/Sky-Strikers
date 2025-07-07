using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Shop
{
	public class AnimationNumbers : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAnimateNumberCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationNumbers _003C_003E4__this;

			public int currentNumber;

			public int targetNumber;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

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
			public _003CAnimateNumberCoroutine_003Ed__11(int _003C_003E1__state)
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

		[SerializeField]
		private float _duration;

		private int _currentNumber;

		private Coroutine _coroutine;

		public event Action<int> OnNumbersChanged
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

		public event Action<int> OnNumbersChangeCompleted
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

		public void AnimateNumbers(int currentNumber, int targetNumber, float duration)
		{
		}

		public void AnimateNumbers(int currentNumber, int targetNumber)
		{
		}

		[IteratorStateMachine(typeof(_003CAnimateNumberCoroutine_003Ed__11))]
		private IEnumerator AnimateNumberCoroutine(int currentNumber, int targetNumber)
		{
			return null;
		}
	}
}
