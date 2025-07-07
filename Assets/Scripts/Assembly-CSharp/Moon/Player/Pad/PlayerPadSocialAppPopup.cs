using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.Player.Pad
{
	public class PlayerPadSocialAppPopup : SingleMonoBehaviour<PlayerPadSocialAppPopup, InSceneSingleMonoBehaviourSettings>
	{
		[CompilerGenerated]
		private sealed class _003CStartDisplayCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerPadSocialAppPopup _003C_003E4__this;

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
			public _003CStartDisplayCoroutine_003Ed__14(int _003C_003E1__state)
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
		private sealed class _003CStartLoadingCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PlayerPadSocialAppPopup _003C_003E4__this;

			private int _003CframeIndex_003E5__2;

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
			public _003CStartLoadingCoroutine_003Ed__12(int _003C_003E1__state)
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
		private GameObject _loadingUI;

		[SerializeField]
		private SVGFrameAnimator _loadingSvgFrameAnimator;

		[SerializeField]
		private float _loadingAnimationInterval;

		[SerializeField]
		private TMP_Text _messageText;

		[SerializeField]
		private float _displayDuration;

		private Coroutine _loadingCoroutine;

		private Coroutine _displayCoroutine;

		public void ToggleUI(bool enable)
		{
		}

		public void ToggleMessageUI(bool enable, string message = "")
		{
		}

		public void ToggleLoadingUI(bool enable)
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CStartLoadingCoroutine_003Ed__12))]
		private IEnumerator StartLoadingCoroutine()
		{
			return null;
		}

		private void StopLoadingCoroutine()
		{
		}

		[IteratorStateMachine(typeof(_003CStartDisplayCoroutine_003Ed__14))]
		private IEnumerator StartDisplayCoroutine()
		{
			return null;
		}

		private void StopDisplayCoroutine()
		{
		}
	}
}
