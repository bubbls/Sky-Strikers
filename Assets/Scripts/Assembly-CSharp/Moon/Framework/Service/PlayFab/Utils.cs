using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using PlayFab;

namespace Moon.Framework.Service.PlayFab
{
	public static class Utils
	{
		public class Response<T>
		{
			public T? Result;

			public PlayFabError? Error;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0<T> where T : class
		{
			public TaskCompletionSource<Response<T>> source;

			internal void _003CRetryAsync_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRetryAsync_003Ed__3<T> : IAsyncStateMachine where T : class
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Response<T>> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public int maxRetryTimes;

			public Action<TaskCompletionSource<Response<T>>> requestAction;

			private _003C_003Ec__DisplayClass3_0<T> _003C_003E8__1;

			private Response<T> _003Cresponse_003E5__2;

			private CancellationTokenRegistration _003Cregistry_003E5__3;

			private int _003CretryTimes_003E5__4;

			private TaskAwaiter<Response<T>> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private ValueTaskAwaiter _003C_003Eu__3;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private const int MaxRetryTimes = 3;

		private const int RetryInterval = 3000;

		[AsyncStateMachine(typeof(_003CRetryAsync_003Ed__3<>))]
		public static Task<Response<T>> RetryAsync<T>(Action<TaskCompletionSource<Response<T>>> requestAction, CancellationToken cancellationToken, int maxRetryTimes = 3) where T : class
		{
			return null;
		}
	}
}
