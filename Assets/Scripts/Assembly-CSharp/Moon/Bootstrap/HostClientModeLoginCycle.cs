using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Moon.Bootstrap
{
	public class HostClientModeLoginCycle : AbstractAsyncGameCycle
	{
		private enum LoginResult
		{
			Succeeded = 0,
			Banned = 1,
			Failed = 2
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public TaskCompletionSource<LoginResult> tcs;

			public CancellationToken cancellationToken;

			internal void _003CBegin_003Eb__0()
			{
			}

			internal void _003CBegin_003Eb__1()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBegin_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public HostClientModeLoginCycle _003C_003E4__this;

			private _003C_003Ec__DisplayClass1_0 _003C_003E8__1;

			private IAsyncGameCycleService _003CcycleService_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<LoginResult> _003C_003Eu__2;

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

		[AsyncStateMachine(typeof(_003CBegin_003Ed__1))]
		public override Task Begin(CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
