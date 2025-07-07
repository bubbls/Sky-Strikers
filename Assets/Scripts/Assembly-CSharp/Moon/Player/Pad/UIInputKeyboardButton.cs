using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class UIInputKeyboardButton : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFlashCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIInputKeyboardButton _003C_003E4__this;

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
			public _003CFlashCoroutine_003Ed__12(int _003C_003E1__state)
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
		private UIButton _uiButton;

		[SerializeField]
		private GameObject _flashObject;

		[SerializeField]
		private float _flashInterval;

		private Coroutine _flashCoroutine;

		public event Action OnButtonPressed
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

		public void ToggleInteraction(bool enable)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void HandleOnButtonPressed()
		{
		}

		[IteratorStateMachine(typeof(_003CFlashCoroutine_003Ed__12))]
		private IEnumerator FlashCoroutine()
		{
			return null;
		}

		private void StopFlashCoroutine()
		{
		}
	}
}
