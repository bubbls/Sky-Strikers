using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.MultiPlay;
using PlayFab;

namespace Moon.Bootstrap
{
	public class HostClientModeGameSessionCycle : AbstractAsyncGameCycle
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBegin_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public HostClientModeGameSessionCycle _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__2;

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
		private struct _003CDisposePhotonConnection_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public HostClientModeGameSessionCycle _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CEnd_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public HostClientModeGameSessionCycle _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter _003C_003Eu__1;

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

		private PhotonConnection _photonConnection;

		private IMessageProducer _messageProducer;

		private IMessageSubscriber[] _subscribers;

		[AsyncStateMachine(typeof(_003CBegin_003Ed__3))]
		public override Task Begin(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CEnd_003Ed__4))]
		public override Task End(CancellationToken cancellationToken)
		{
			return null;
		}

		private int HandleAccountBanned(IMessage<PlayFabError> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CDisposePhotonConnection_003Ed__6))]
		private Task DisposePhotonConnection()
		{
			return null;
		}

		private void HandlePhotonConnChanged(ConnectionManager.Status status, ShutdownReason shutdownReason)
		{
		}
	}
}
