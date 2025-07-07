using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Shop
{
	public class AnimationNumbersText : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAnimateNumberIncrease_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimationNumbersText _003C_003E4__this;

			public int currentNumber;

			public float waitingTime;

			public Action started;

			public int targetNumber;

			public string postFix;

			public Action callback;

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
			public _003CAnimateNumberIncrease_003Ed__12(int _003C_003E1__state)
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

		[SerializeField]
		private TMP_Text _numberText;

		private int _currentNumber;

		private Coroutine _coroutine;

		public TMP_Text NumberText => null;

		public int CurrentNumber => 0;

		public void SetText(int number)
		{
		}

		private void TryStopAnimation()
		{
		}

		public void AnimateText(int currentNumber, int targetNumber, string postFix = "", Action completed = null, float waitingTime = 0f, Action started = null)
		{
		}

		public void AnimateText(int currentNumber, int targetNumber, float duration, string postFix = "", Action completed = null, float waitingTime = 0f, Action started = null)
		{
		}

		[IteratorStateMachine(typeof(_003CAnimateNumberIncrease_003Ed__12))]
		private IEnumerator AnimateNumberIncrease(int currentNumber, int targetNumber, string postFix, Action callback = null, float waitingTime = 0f, Action started = null)
		{
			return null;
		}
	}
}
