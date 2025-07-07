using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Android;

namespace Moon.MultiPlay
{
	public class MicrophonePermissionHelper : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStartRequestingAndroidPermission_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MicrophonePermissionHelper _003C_003E4__this;

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
			public _003CStartRequestingAndroidPermission_003Ed__4(int _003C_003E1__state)
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

		private const string ClassName = "MicrophonePermissionHelper";

		private Action _onPermissionCheckCompleteCallback;

		private PermissionCallbacks _callbacks;

		public void CheckMicrophonePermission(Action onCheckCompleteCallback)
		{
		}

		[IteratorStateMachine(typeof(_003CStartRequestingAndroidPermission_003Ed__4))]
		private IEnumerator StartRequestingAndroidPermission()
		{
			return null;
		}

		private void PermissionCallbacks_PermissionDeniedAndDontAskAgain(string permissionName)
		{
		}

		private void PermissionCallbacks_PermissionGranted(string permissionName)
		{
		}

		private void PermissionCallbacks_PermissionDenied(string permissionName)
		{
		}

		private void FinishAndroidPermissionRequest(string log)
		{
		}
	}
}
