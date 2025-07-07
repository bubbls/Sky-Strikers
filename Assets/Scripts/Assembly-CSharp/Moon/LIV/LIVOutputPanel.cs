using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.LIV
{
	public class LIVOutputPanel : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CShowOutputCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LIVOutputPanel _003C_003E4__this;

			public string output;

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
			public _003CShowOutputCoroutine_003Ed__6(int _003C_003E1__state)
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
		private GameObject _container;

		[SerializeField]
		private TMP_Text _outputText;

		[SerializeField]
		private float _displayDuration;

		private Coroutine _showOutputCoroutine;

		private readonly string _outputTemplate;

		public void TogglePanel(bool isShow, string message = "")
		{
		}

		[IteratorStateMachine(typeof(_003CShowOutputCoroutine_003Ed__6))]
		private IEnumerator ShowOutputCoroutine(string output)
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void TryStopShowOutputCoroutine()
		{
		}
	}
}
