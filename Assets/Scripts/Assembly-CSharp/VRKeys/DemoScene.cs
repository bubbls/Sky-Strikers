using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using UnityEngine;

namespace VRKeys
{
	public class DemoScene : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSubmitEmail_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DemoScene _003C_003E4__this;

			public string email;

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
			public _003CSubmitEmail_003Ed__8(int _003C_003E1__state)
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

		public Keyboard keyboard;

		private Regex emailValidator;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public void HandleUpdate(string text)
		{
		}

		public void HandleSubmit(string text)
		{
		}

		public void HandleCancel()
		{
		}

		[IteratorStateMachine(typeof(_003CSubmitEmail_003Ed__8))]
		private IEnumerator SubmitEmail(string email)
		{
			return null;
		}

		private bool ValidateEmail(string text)
		{
			return false;
		}
	}
}
