using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Moon.Arena;
using Moon.Class;
using UnityEngine;

namespace Moon
{
	public class MatchSummaryPlayerAvatar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadPlayerVisualsRoutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MatchSummaryPlayerAvatar _003C_003E4__this;

			public PlayerVisualsConfig config;

			public TeamNo teamNo;

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
			public _003CLoadPlayerVisualsRoutine_003Ed__5(int _003C_003E1__state)
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
		private GameObject _model;

		[SerializeField]
		private PlayerVisualsPresetLoader _playerVisualsPresetLoader;

		[SerializeField]
		private PlayerVisualsPresetPoints _presetPoints;

		private Coroutine _loaderCoroutine;

		public void LoadPlayerVisuals(TeamNo teamNo, PlayerVisualsConfig config)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadPlayerVisualsRoutine_003Ed__5))]
		private IEnumerator LoadPlayerVisualsRoutine(TeamNo teamNo, PlayerVisualsConfig config)
		{
			return null;
		}

		public void ToggleAvatar(bool enable)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
