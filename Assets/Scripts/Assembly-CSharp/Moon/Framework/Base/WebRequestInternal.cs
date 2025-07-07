using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine.Networking;

namespace Moon.Framework.Base
{
	[PublicAPI]
	public class WebRequestInternal
	{
		[CompilerGenerated]
		private sealed class _003CRequestRoutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public WebRequestInternal _003C_003E4__this;

			private float _003CrequestProgress_003E5__2;

			private float _003CrequestStuckTime_003E5__3;

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
			public _003CRequestRoutine_003Ed__22(int _003C_003E1__state)
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

		private const int RequestTimeOut = 8;

		private int _requestAttemptsLimit;

		private WebRequest.Configuration _configuration;

		private UnityWebRequest _request;

		private int _requestTimeOutDuration;

		private int _requestAttempts;

		public WebRequestState RequestState { get; private set; }

		public event Action<WebRequestResponseData> OnRequestDone
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

		public event Action<int> OnRequestWillRestart
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

		public WebRequestInternal(WebRequest.Configuration configuration)
		{
		}

		public void StartRequest()
		{
		}

		public void StopRequest()
		{
		}

		public void SetRequestRequestAttemptsLimit(int requestAttemptsLimit)
		{
		}

		private void RestartRequest()
		{
		}

		private bool SetUpRequestConfiguration(WebRequest.Configuration configuration)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CRequestRoutine_003Ed__22))]
		private IEnumerator RequestRoutine()
		{
			return null;
		}

		private void HandleOnRequestTimeOut()
		{
		}

		private void HandleOnRequestDone()
		{
		}

		private void HandleOnRequestInvalid()
		{
		}

		private void DisposeRequest(bool disposeUploadHandler)
		{
		}
	}
}
