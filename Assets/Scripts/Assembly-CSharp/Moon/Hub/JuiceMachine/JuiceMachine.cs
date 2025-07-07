using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using Moon.Shop;
using UnityEngine;

namespace Moon.Hub.JuiceMachine
{
	public class JuiceMachine : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CShowGetJuiceFailedRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JuiceMachine _003C_003E4__this;

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
			public _003CShowGetJuiceFailedRoutine_003Ed__13(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CShowGetJuiceRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JuiceMachine _003C_003E4__this;

			public int amount;

			public string itemId;

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
			public _003CShowGetJuiceRoutine_003Ed__12(int _003C_003E1__state)
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
		private PushLockButton _getJuiceButton;

		[SerializeField]
		private CurrencyNotificationArea _currencyNotificationArea;

		[SerializeField]
		private CurrencyTransactionTubeRendererController _tubeRendererController;

		private const string JuiceId = "com.chamber8.skystrikersvr.consumable.burst";

		private const int JuicePrice = 5;

		private const string PurchaseItemDataKey = "PurchaseItemData";

		private IMessageSubscriber[] _subscribers;

		private Coroutine _processCoroutine;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleOnButtonPressed()
		{
		}

		private void PurchaseJuice()
		{
		}

		[IteratorStateMachine(typeof(_003CShowGetJuiceRoutine_003Ed__12))]
		private IEnumerator ShowGetJuiceRoutine(int amount, string itemId)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowGetJuiceFailedRoutine_003Ed__13))]
		private IEnumerator ShowGetJuiceFailedRoutine()
		{
			return null;
		}

		private void StopProcessRoutine()
		{
		}

		private void EnableGetJuiceButton()
		{
		}
	}
}
