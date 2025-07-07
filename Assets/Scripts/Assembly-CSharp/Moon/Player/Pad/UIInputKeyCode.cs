using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class UIInputKeyCode : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFlashingCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIInputKeyCode _003C_003E4__this;

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
			public _003CFlashingCoroutine_003Ed__13(int _003C_003E1__state)
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
		private TMP_Text _keyCodeText;

		[SerializeField]
		private GameObject _flashObject;

		[SerializeField]
		private float _flashingInterval;

		private Coroutine _flashCoroutine;

		public event Action<string> OnInputKeyCodePressed
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

		public void ToggleUpperCase(bool isUpperCase)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnButtonPressed()
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CFlashingCoroutine_003Ed__13))]
		private IEnumerator FlashingCoroutine()
		{
			return null;
		}

		private void StopFlashingCoroutine()
		{
		}
	}
}
