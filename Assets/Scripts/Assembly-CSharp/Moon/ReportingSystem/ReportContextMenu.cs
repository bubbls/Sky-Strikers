using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DP.Takeaway.Runtime;
using Moon.Hub;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class ReportContextMenu : ReportContextMenuBase
	{
		[Serializable]
		private class ButtonsLookup : SerializableDictionary<BadBehaviour, ManualButton>
		{
		}

		[CompilerGenerated]
		private sealed class _003CShowReportedForSeconds_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ReportContextMenu _003C_003E4__this;

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
			public _003CShowReportedForSeconds_003Ed__20(int _003C_003E1__state)
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
		private GameObject _buttonsContainer;

		[SerializeField]
		private GameObject _reportReceivedPrompt;

		[SerializeField]
		private ButtonsLookup _buttonsLookup;

		[SerializeField]
		private Animator _animator;

		private static readonly int _showHash;

		private static readonly int _hideHash;

		private bool _isShowing;

		private BadBehaviour _lastReportedBehaviour;

		private Coroutine _showReportedStatusRoutine;

		private Coroutine _restartTimer;

		private Coroutine _enableButtonRoutine;

		public override bool IsShowing => false;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void SetReportButtonsStatus()
		{
		}

		private void HandleReportButtonPressed(BadBehaviour badBehaviour)
		{
		}

		private void RestartHideTimer()
		{
		}

		private void DoReport(BadBehaviour badBehaviour)
		{
		}

		[IteratorStateMachine(typeof(_003CShowReportedForSeconds_003Ed__20))]
		private IEnumerator ShowReportedForSeconds()
		{
			return null;
		}

		private void HideReportedPrompt()
		{
		}

		public override void ResetToInitialStatus()
		{
		}

		public override void Toggle(bool show, Action callback = null)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void Show()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void Hide()
		{
		}

		private void EnableButtons(bool enable)
		{
		}
	}
}
