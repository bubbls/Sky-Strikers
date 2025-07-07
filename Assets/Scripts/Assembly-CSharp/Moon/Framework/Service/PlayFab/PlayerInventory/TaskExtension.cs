using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Moon.Framework.Service.PlayFab.PlayerInventory
{
	public static class TaskExtension
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTimeoutAfter_003Ed__0<TResult> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<TResult> _003C_003Et__builder;

			public Task<TResult> task;

			public TimeSpan timeout;

			private CancellationTokenSource _003CtimeoutCancellationTokenSource_003E5__2;

			private TaskAwaiter<Task> _003C_003Eu__1;

			private TaskAwaiter<TResult> _003C_003Eu__2;

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

		[AsyncStateMachine(typeof(_003CTimeoutAfter_003Ed__0<>))]
		public static Task<TResult> TimeoutAfter<TResult>(this Task<TResult> task, TimeSpan timeout)
		{
			return null;
		}
	}
}
