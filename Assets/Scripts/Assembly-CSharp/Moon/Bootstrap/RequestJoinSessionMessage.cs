using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Fusion;
using JetBrains.Annotations;
using Moon.Arena;

namespace Moon.Bootstrap
{
	public class RequestJoinSessionMessage
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInvokeStep1BeforeCloseConnection_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RequestJoinSessionMessage _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInvokeStep2ConnectionCloseAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RequestJoinSessionMessage _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInvokeStep3ConnectedToSinglePlayerNewSession_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RequestJoinSessionMessage _003C_003E4__this;

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

		public bool IsPublic;

		public bool DisconnectImmediately;

		[CanBeNull]
		public string PhotonRegion;

		[CanBeNull]
		public string PlayFabRegion;

		public JoinSessionStep Step1BeforeCloseConnection;

		public JoinSessionStep Step2ConnectionClosed;

		public JoinSessionStep Step3ConnectedToSinglePlayerNewSession;

		public Action<bool, ShutdownReason> ConnectionCompleteResult;

		[AsyncStateMachine(typeof(_003CInvokeStep1BeforeCloseConnection_003Ed__10))]
		public Task InvokeStep1BeforeCloseConnection()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInvokeStep2ConnectionCloseAsync_003Ed__11))]
		public Task InvokeStep2ConnectionCloseAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInvokeStep3ConnectedToSinglePlayerNewSession_003Ed__12))]
		public Task InvokeStep3ConnectedToSinglePlayerNewSession()
		{
			return null;
		}
	}
}
