using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Fusion;
using Moon.MultiPlay;

namespace Moon.Bootstrap
{
	public class PhotonConnection : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectAsAutoHostOrClient_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PhotonConnectResult> _003C_003Et__builder;

			public PhotonConnection _003C_003E4__this;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__1;

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
		private struct _003CConnectAsClientAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PhotonConnectResult> _003C_003Et__builder;

			public PhotonConnection _003C_003E4__this;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__1;

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
		private struct _003CConnectAsServerAsync_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PhotonConnection _003C_003E4__this;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__1;

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
		private struct _003CConnectAsSingleAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PhotonConnectResult> _003C_003Et__builder;

			public PhotonConnection _003C_003E4__this;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__1;

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
		private struct _003CShutdownAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PhotonConnection _003C_003E4__this;

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

		private ConnectionManager _connectionManager;

		public event Action<ConnectionManager.Status, ShutdownReason> OnPhotonConnChanged
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

		public event Action<ConnectionManager.Progress> OnPhotonConnProgressReported
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

		public event Action OnPhotonSceneLoaded
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

		public event Action<PlayerRef> OnPhotonPlayerJoined
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

		[AsyncStateMachine(typeof(_003CConnectAsServerAsync_003Ed__13))]
		public Task ConnectAsServerAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsClientAsync_003Ed__14))]
		public Task<PhotonConnectResult> ConnectAsClientAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsSingleAsync_003Ed__15))]
		public Task<PhotonConnectResult> ConnectAsSingleAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsAutoHostOrClient_003Ed__16))]
		public Task<PhotonConnectResult> ConnectAsAutoHostOrClient()
		{
			return null;
		}

		public void Dispose()
		{
		}

		[AsyncStateMachine(typeof(_003CShutdownAsync_003Ed__18))]
		public Task ShutdownAsync()
		{
			return null;
		}

		private void HandleConnChanged(ConnectionManager.Status status, ShutdownReason shutdownReason)
		{
		}

		private void HandleConnProgressReported(ConnectionManager.Progress progress)
		{
		}

		private void HandleConnSceneLoaded()
		{
		}

		private void HandleConnPlayerJoined(PlayerRef playerRef)
		{
		}

		public void Initialize()
		{
		}
	}
}
