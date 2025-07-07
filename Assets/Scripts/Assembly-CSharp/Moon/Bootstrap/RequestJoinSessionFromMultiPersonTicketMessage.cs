using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Moon.MultiPlay;

namespace Moon.Bootstrap
{
	public class RequestJoinSessionFromMultiPersonTicketMessage
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInvokeStep1AfterCloseConnection_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RequestJoinSessionFromMultiPersonTicketMessage _003C_003E4__this;

			private TaskAwaiter<int> _003C_003Eu__1;

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

		public RankedPairMatchFoundNetworkData RankedPairMatchFoundNetworkData;

		public JoinSessionStep Step1AfterCloseConnection;

		public Action<ClientSharedData.Error> ConnectionAttemptComplete;

		[AsyncStateMachine(typeof(_003CInvokeStep1AfterCloseConnection_003Ed__3))]
		public Task InvokeStep1AfterCloseConnection()
		{
			return null;
		}
	}
}
