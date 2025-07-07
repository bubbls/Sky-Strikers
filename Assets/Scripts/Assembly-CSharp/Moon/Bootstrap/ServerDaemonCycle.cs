using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using PlayFab.MultiplayerModels;

namespace Moon.Bootstrap
{
	public class ServerDaemonCycle : AbstractAsyncGameCycle
	{
		[Serializable]
		private class ServerCookieData
		{
			public string ServerId;

			public string FieldType;

			public string RoomName;

			public string QueueName;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CActivateServerAsync_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public ServerDaemonCycle _003C_003E4__this;

			private bool _003CisPrivateSession_003E5__2;

			private List<MatchmakingPlayerWithTeamAssignment> _003CmatchedPlayers_003E5__3;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private TaskAwaiter<GetMatchResult> _003C_003Eu__3;

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
		private struct _003CBegin_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ServerDaemonCycle _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter _003C_003Eu__1;

			private InSceneNetworkConfiguration _003Cconfiguration_003E5__2;

			private TaskAwaiter<bool> _003C_003Eu__2;

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
		private struct _003CDelayShutdownServerAsync_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public int delay;

			public CancellationTokenSource cancellationTokenSource;

			public ServerDaemonCycle _003C_003E4__this;

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
		private struct _003CLoginPlayFabAsync_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private object _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private bool _003C_003E7__wrap4;

			private bool _003CloggedIn_003E5__6;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CNotifyServerStillActive_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CancellationTokenSource serverHeartbeatTokenSource;

			public ServerDaemonCycle _003C_003E4__this;

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
		private struct _003CRegisterServerAsync_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public int delay;

			public ServerDaemonCycle _003C_003E4__this;

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
		private struct _003CShutdownServerAsync_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ServerDaemonCycle _003C_003E4__this;

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

		public const string PlayFabKeyGamePort = "gameport";

		private const string PlayFabKeyRegion = "region";

		public const string PlayFabKeyEnv = "env";

		private const string PlayFabKeyQueueName = "PF_MATCH_QUEUE_NAME";

		private const int ServerActiveNotifyDelay = 60000;

		private bool _isInit;

		private PlayFabBackfillTicket _backfillTicket;

		private readonly Cooldown _serverHealthCheckCooldown;

		private const int ServerDelayShutdownTime = 120;

		private bool _isRegistered;

		private bool _isManuallyAllocatedServer;

		private string _currentSessionCode;

		private ServerRegistrationRequest? _serverRegistrationRequest;

		private ServerCookieData _serverCookieData;

		private CancellationTokenSource _serverHeartbeatTokenSource;

		private CancellationTokenSource _shutdownServerTokenSource;

		public override bool Background => false;

		private float LastHealthOkTime { get; set; }

		[AsyncStateMachine(typeof(_003CBegin_003Ed__23))]
		public override Task Begin(CancellationToken cancellationToken)
		{
			return null;
		}

		public override void Tick(bool isBackground)
		{
		}

		private void InitializeEnvironmentArgs()
		{
		}

		private void InitializeMultiplayerAgent()
		{
		}

		private void OnServerAgentError(string error)
		{
		}

		private void OnServerActive()
		{
		}

		private void OnServerShutdown()
		{
		}

		private void OnServerMaintenance(DateTime? nextscheduledmaintenanceutc)
		{
		}

		[AsyncStateMachine(typeof(_003CLoginPlayFabAsync_003Ed__31))]
		private static Task<bool> LoginPlayFabAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CActivateServerAsync_003Ed__32))]
		private void ActivateServerAsync(CancellationToken cancellationToken)
		{
		}

		private void HandleOnServerRegistered(string msg)
		{
		}

		private void HandleOnRegistrationFailed(HttpStatusCode code, string error)
		{
		}

		[AsyncStateMachine(typeof(_003CRegisterServerAsync_003Ed__35))]
		private void RegisterServerAsync(int delay)
		{
		}

		[AsyncStateMachine(typeof(_003CNotifyServerStillActive_003Ed__36))]
		private void NotifyServerStillActive(CancellationTokenSource serverHeartbeatTokenSource)
		{
		}

		private int OnPlayerAdd(IMessage<PlayerAddedMessage> message)
		{
			return 0;
		}

		private int OnPlayerRemove(IMessage<PlayerRemovedMessage> message)
		{
			return 0;
		}

		private int OnConnChanged(IMessage<ConnChangedMessage> message)
		{
			return 0;
		}

		private int HandleOnRequestStopBackFillTicket(IMessage<object> arg)
		{
			return 0;
		}

		private void DelayShutdownServer()
		{
		}

		private void CancelDelayShutdownServer()
		{
		}

		[AsyncStateMachine(typeof(_003CDelayShutdownServerAsync_003Ed__43))]
		private void DelayShutdownServerAsync(int delay, CancellationTokenSource cancellationTokenSource)
		{
		}

		[AsyncStateMachine(typeof(_003CShutdownServerAsync_003Ed__44))]
		private void ShutdownServerAsync()
		{
		}
	}
}
