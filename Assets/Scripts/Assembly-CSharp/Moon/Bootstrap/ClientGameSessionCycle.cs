using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Arena;
using Moon.MultiPlay;
using PlayFab;
using PlayFab.MultiplayerModels;

namespace Moon.Bootstrap
{
	public class ClientGameSessionCycle : AbstractAsyncGameCycle
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBegin_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<bool> _003C_003Eu__2;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__3;

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
		private struct _003CConnectAndTryToStartOrRestorePublicSessionAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public FieldType fieldType;

			public ClientGameSessionCycle _003C_003E4__this;

			public float delayInSeconds;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CConnectAsClientAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PhotonConnectResult> _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

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
		private struct _003CConnectAsSingleAndJoinPublicSessionAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public FieldType fieldType;

			public float delayInSeconds;

			public ClientGameSessionCycle _003C_003E4__this;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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
		private struct _003CConnectAsSingleAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PhotonConnectResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientGameSessionCycle _003C_003E4__this;

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
		private struct _003CDisconnectAndReconnectAsClientAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

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
		private struct _003CDisposePhotonConnection_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

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
		private struct _003CEnd_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CHandleOnConnectAsSingleAsync_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

			public ConnectAsSingleMessage payload;

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
		private struct _003CRequestJoinMultiPersonTicketInternal_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

			public RequestJoinMultiPersonTicketMessage payload;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<JoinMatchmakingTicketResult> _003C_003Eu__2;

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
		private struct _003CRequestJoinRankedSessionInternal_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

			public RequestJoinRankedSessionMessage payload;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__2;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__3;

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
		private struct _003CRequestJoinSessionFromKickInternal_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RequestJoinSessionMessage payload;

			public ClientGameSessionCycle _003C_003E4__this;

			private PhotonConnectResult _003CconnectResult_003E5__2;

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
		private struct _003CRequestJoinSessionFromMultiPersonTicketInternal_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

			public RequestJoinSessionFromMultiPersonTicketMessage payload;

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
		private struct _003CRequestJoinSessionInternal_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

			public RequestJoinSessionMessage payload;

			private PhotonConnectResult _003CconnectResult_003E5__2;

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
		private struct _003CRequestJoinSessionNoMatchmaking_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RequestJoinSessionMessage payload;

			public ClientGameSessionCycle _003C_003E4__this;

			private PhotonConnectResult _003CphotonConnectResult_003E5__2;

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
		private struct _003CRequestRestartMatchmakingInternal_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

			public RequestJoinSessionMessage payload;

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
		private struct _003CRequestStartMultiPersonMatchmaking_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

			public RequestStartMultiPersonMatchmakingMessage payload;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__2;

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
		private struct _003CTick_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

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
		private struct _003CTryToJoinPrivateSessionAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientGameSessionCycle _003C_003E4__this;

			public FieldType fieldType;

			public string roomName;

			public float delayInSeconds;

			private TaskAwaiter<PhotonConnectResult> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

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

		private IMessageSubscriber[] _subscribers;

		private ClientMatchmakingService _matchmakingService;

		private ShutdownReason _shutdownReason;

		private float _reconnectTimer;

		private const float ReconnectInterval = 30f;

		private ServerSessionService _serverSessionService;

		public static event Action<FieldType, ShutdownReason> OnPlayerUnableToRejoinSession
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

		[AsyncStateMachine(typeof(_003CBegin_003Ed__10))]
		public override Task Begin(CancellationToken cancellationToken)
		{
			return null;
		}

		private int HandleAccountBanned(IMessage<PlayFabError> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CEnd_003Ed__12))]
		public override Task End(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDisposePhotonConnection_003Ed__13))]
		private Task DisposePhotonConnection()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectAndTryToStartOrRestorePublicSessionAsync_003Ed__14))]
		private void ConnectAndTryToStartOrRestorePublicSessionAsync(FieldType fieldType, float delayInSeconds = 0f)
		{
		}

		[AsyncStateMachine(typeof(_003CConnectAsSingleAndJoinPublicSessionAsync_003Ed__15))]
		private Task ConnectAsSingleAndJoinPublicSessionAsync(FieldType fieldType, float delayInSeconds = 0f)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryToJoinPrivateSessionAsync_003Ed__16))]
		private void TryToJoinPrivateSessionAsync(FieldType fieldType, string roomName, float delayInSeconds = 0f)
		{
		}

		[AsyncStateMachine(typeof(_003CConnectAsSingleAsync_003Ed__17))]
		private Task<PhotonConnectResult> ConnectAsSingleAsync(FieldType fieldType)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDisconnectAndReconnectAsClientAsync_003Ed__18))]
		private void DisconnectAndReconnectAsClientAsync()
		{
		}

		private int HandleMatchMakingResult(IMessage<MatchMakingResultMessage> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CConnectAsClientAsync_003Ed__20))]
		private Task<PhotonConnectResult> ConnectAsClientAsync()
		{
			return null;
		}

		private void HandlePhotonConnChanged(ConnectionManager.Status status, ShutdownReason shutdownReason)
		{
		}

		private void HandlePhotonDisconnected(ShutdownReason shutdownReason)
		{
		}

		private static void HandlePhotonConnProgressReported(ConnectionManager.Progress progress)
		{
		}

		private int HandleRequestRestartMatchmaking(IMessage<RequestJoinSessionMessage> message)
		{
			return 0;
		}

		private int HandleRequestJoinSession(IMessage<RequestJoinSessionMessage> message)
		{
			return 0;
		}

		private int HandleRequestJoinRankedSession(IMessage<RequestJoinRankedSessionMessage> message)
		{
			return 0;
		}

		private int HandleRequestStartMultiPersonMatchmaking(IMessage<RequestStartMultiPersonMatchmakingMessage> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CRequestStartMultiPersonMatchmaking_003Ed__28))]
		private void RequestStartMultiPersonMatchmaking(RequestStartMultiPersonMatchmakingMessage payload)
		{
		}

		private int HandleRequestJoinMultiPersonTicket(IMessage<RequestJoinMultiPersonTicketMessage> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CRequestJoinMultiPersonTicketInternal_003Ed__30))]
		private void RequestJoinMultiPersonTicketInternal(RequestJoinMultiPersonTicketMessage payload)
		{
		}

		private int HandleRequestJoinSessionFromMultiPersonTicket(IMessage<RequestJoinSessionFromMultiPersonTicketMessage> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CRequestJoinSessionFromMultiPersonTicketInternal_003Ed__32))]
		private void RequestJoinSessionFromMultiPersonTicketInternal(RequestJoinSessionFromMultiPersonTicketMessage payload)
		{
		}

		[AsyncStateMachine(typeof(_003CRequestJoinRankedSessionInternal_003Ed__33))]
		private void RequestJoinRankedSessionInternal(RequestJoinRankedSessionMessage payload)
		{
		}

		[AsyncStateMachine(typeof(_003CRequestRestartMatchmakingInternal_003Ed__34))]
		private void RequestRestartMatchmakingInternal(RequestJoinSessionMessage payload)
		{
		}

		[AsyncStateMachine(typeof(_003CRequestJoinSessionInternal_003Ed__35))]
		private void RequestJoinSessionInternal(RequestJoinSessionMessage payload)
		{
		}

		private int HandleRequestJoinSessionFromKick(IMessage<RequestJoinSessionMessage> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CRequestJoinSessionFromKickInternal_003Ed__37))]
		private void RequestJoinSessionFromKickInternal(RequestJoinSessionMessage payload)
		{
		}

		private int HandleRequestJoinSessionNoMatchmaking(IMessage<RequestJoinSessionMessage> arg)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CRequestJoinSessionNoMatchmaking_003Ed__39))]
		private void RequestJoinSessionNoMatchmaking(RequestJoinSessionMessage payload)
		{
		}

		private int HandleCancelMatchmaking(IMessage<object> message)
		{
			return 0;
		}

		private int HandleRequestJoinPrivateSession(IMessage<RequestJoinPrivateSessionMessage> message)
		{
			return 0;
		}

		private int HandleOnConnectAsSingle(IMessage<ConnectAsSingleMessage> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CHandleOnConnectAsSingleAsync_003Ed__43))]
		private void HandleOnConnectAsSingleAsync(ConnectAsSingleMessage payload)
		{
		}

		[AsyncStateMachine(typeof(_003CTick_003Ed__44))]
		public override void Tick(bool isBackground)
		{
		}

		private bool CheckJoinSession(ShutdownReason shutdownReason)
		{
			return false;
		}

		private bool CheckIfCanRejoinArenaDefault(ShutdownReason shutdownReason)
		{
			return false;
		}

		public static void ConnectAsSingle(FieldType fieldType, Action complete)
		{
		}

		public static void CancelMatchmaking()
		{
		}

		public static void RequestRestartMatchmaking(FieldType fieldType, string roomName, bool isPublic)
		{
		}

		public static void RequestJoinSessionWithSteps(FieldType fieldType, string roomName, bool isPublic, JoinSessionStep step1BeforeCloseConnection = null, JoinSessionStep step2ConnectionClosed = null, JoinSessionStep step3ConnectedToSinglePlayerNewSession = null, Action<bool, ShutdownReason> connectionCompleteResult = null)
		{
		}

		public static void RequestJoinSessionFromKickWithSteps(FieldType fieldType, string roomName, bool isPublic, JoinSessionStep step1BeforeCloseConnection = null, JoinSessionStep step2ConnectionClosed = null, JoinSessionStep step3ConnectedToSinglePlayerNewSession = null, Action<bool, ShutdownReason> connectionCompleteResult = null)
		{
		}

		public static void RequestJoinRankedSession(FieldType fieldType, string roomName, int mmrScore, List<string> preferredRegions, JoinSessionStep step1AfterCloseConnection = null, Action<ClientSharedData.Error> connectionAttemptComplete = null)
		{
		}

		public static void RequestStartMultiPersonMatchmaking(string[] playersPlayFabIds, List<string> pairPlayFabIdList, FieldType fieldType, string roomName, int mmrScore, List<string> preferredRegions, Action<ClientSharedData.Error> connectionAttemptComplete = null)
		{
		}

		public static void RequestJoinMultiPersonTicket(string ticketId, FieldType fieldType, string roomName, int mmrScore, List<string> preferredRegions, Action<ClientSharedData.Error> connectionAttemptComplete = null)
		{
		}

		public static void RequestJoinNonMatchmakingSessionWithSteps(FieldType fieldType, string roomName, bool isPublic, bool disconnectImmediately, string photonRegion, string playFabRegion, JoinSessionStep step1BeforeCloseConnection = null, JoinSessionStep step2ConnectionClosed = null, JoinSessionStep step3ConnectedToSinglePlayerNewSession = null, Action<bool, ShutdownReason> connectionCompleteResult = null)
		{
		}
	}
}
