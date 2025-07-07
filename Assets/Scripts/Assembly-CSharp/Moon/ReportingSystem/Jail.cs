using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Service.PlayFab;
using TMPro;
using UnityEngine;

namespace Moon.ReportingSystem
{
	public class Jail : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Jail _003C_003E4__this;

			private IPlayFabAccountService _003Csrv_003E5__2;

			private WaitForSeconds _003CwaitForSeconds_003E5__3;

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
			public _003CStart_003Ed__6(int _003C_003E1__state)
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
		private GameObject _banInformation;

		[SerializeField]
		private GameObject _restartPrompt;

		[SerializeField]
		private TMP_Text _banReasonText;

		[SerializeField]
		private TMP_Text _banExpireText;

		[SerializeField]
		private Transform _spawnPosition;

		private DateTime _banExpireDate;

		[IteratorStateMachine(typeof(_003CStart_003Ed__6))]
		private IEnumerator Start()
		{
			return null;
		}
	}
}
