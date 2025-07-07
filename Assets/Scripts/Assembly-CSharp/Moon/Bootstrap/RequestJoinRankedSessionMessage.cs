using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Moon.Arena;

namespace Moon.Bootstrap
{
	public class RequestJoinRankedSessionMessage
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInvokeStep1AfterCloseConnection_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RequestJoinRankedSessionMessage _003C_003E4__this;

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

		public FieldType FieldType;

		public string RoomName;

		public int MMRScore;

		public List<string> PreferredRegions;

		public JoinSessionStep Step1AfterCloseConnection;

		public Action<ClientSharedData.Error> ConnectionAttemptComplete;

		[AsyncStateMachine(typeof(_003CInvokeStep1AfterCloseConnection_003Ed__6))]
		public Task InvokeStep1AfterCloseConnection()
		{
			return null;
		}
	}
}
