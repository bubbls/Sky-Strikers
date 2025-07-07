using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using Fusion;
using Fusion.Photon.Realtime;
using Fusion.Sockets;
using Moon.Bootstrap;
using Moon.Player;
using NaughtyAttributes;
using UnityEngine;

namespace Moon.MultiPlay
{
	public class ConnectionManager : SingleMonoBehaviour<ConnectionManager, DefaultSingleMonoBehaviourSettings<ConnectionManager>>, INetworkRunnerCallbacks
	{
		public enum Status
		{
			Disconnected = 0,
			Disconnecting = 1,
			Connected = 2,
			Connecting = 3
		}

		public enum Progress
		{
			Shutdown = 0,
			LoadStagingScene = 1,
			ConnectingToServer = 2,
			ConnectionToServerSuccess = 3,
			ConnectingToServerFailed = 4,
			ExceptionCaught = 5,
			ServerConnectionTimeout = 6,
			Canceled = 7,
			UpdateServerAuthToken = 8,
			GameIsFullRetryConnection = 9,
			RetryConnection = 10
		}

		[Serializable]
		public class ConnectionNotification
		{
			public Status connectionStatus;

			public NotificationMessage messageSetting;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CConnectAsync_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PhotonConnectResult> _003C_003Et__builder;

			public ConnectionManager _003C_003E4__this;

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
		private struct _003CConnectInternalAsync_003Ed__50 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PhotonConnectResult> _003C_003Et__builder;

			public ConnectionManager _003C_003E4__this;

			public CancellationToken cancellationToken;

			private int _003Cretries_003E5__2;

			private ShutdownReason _003CshutdownReason_003E5__3;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private Task<StartGameResult> _003Cconn_003E5__4;

			private TaskAwaiter<Task> _003C_003Eu__2;

			private TaskAwaiter _003C_003Eu__3;

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
		private struct _003CConnectInternalAsync_003Ed__52 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<StartGameResult> _003C_003Et__builder;

			public ConnectionManager _003C_003E4__this;

			private TaskAwaiter<StartGameResult> _003C_003Eu__1;

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
		private struct _003CForceReconnect_003Ed__64 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ConnectionManager _003C_003E4__this;

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
		private struct _003CShutdownAsync_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ConnectionManager _003C_003E4__this;

			public ShutdownReason shutdownReason;

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
		private struct _003CShutdownAsync_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ConnectionManager _003C_003E4__this;

			public ShutdownReason shutdownReason;

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
		private struct _003CUpdateAuthToken_003Ed__60 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public ConnectionManager _003C_003E4__this;

			public CancellationToken cancellationToken;

			public bool forceRefresh;

			private TaskAwaiter<string> _003C_003Eu__1;

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

		public const string AppVersion = "Sprig";

		public const string ShopVersion = "2.0";

		public const string SinglePlayerConnectedMessage = "LOCAL PLAY";

		public const int SessionNameLength = 4;

		public const int MaxSessionNameNumber = 9999;

		private const int MaxRetries = 3;

		private const int RetryConnectionDelay = 3000;

		private const int ConnectTimeout = 30000;

		private const bool EnableAuth = false;

		private AppSettings _customAppSettings;

		private bool _runnerProvideInput;

		private StartGameArgs _startGameArgs;

		private NetworkRunner _runner;

		private CancellationTokenSource _cancellationTokenSource;

		private bool _applicationPause;

		[SerializeField]
		private List<ConnectionNotification> _notifications;

		public Status ConnStatus { get; private set; }

		public event Action<Status, ShutdownReason> OnConnChanged
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

		public event Action<Progress> OnConnProgressReported
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

		public event Action OnSceneLoadedEvent
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

		public event Action<PlayerRef> OnPlayerJoinedEvent
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

		public event Action<PlayerRef> OnPlayerLeftEvent
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

		public void SetConnectAsClient(PhotonRegion.Code region, string environmentName, string photonSessionId, ushort port = 0)
		{
		}

		public void SetConnectAsSingle(PhotonRegion.Code region, string environmentName)
		{
		}

		public void SetConnectAsAutoHostOrClient(PhotonRegion.Code region, string environmentName, string photonSessionId, GameMode gameMode)
		{
		}

		public static NetworkRunner GetActiveRunner()
		{
			return null;
		}

		private void UpdateConnStatus(Status status, ShutdownReason payload = ShutdownReason.Ok)
		{
		}

		private void ReportProgress(Progress progress)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationQuit()
		{
		}

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__46))]
		public Task<PhotonConnectResult> ConnectAsync()
		{
			return null;
		}

		private void Connect()
		{
		}

		private void Shutdown(ShutdownReason shutdownReason = ShutdownReason.Ok)
		{
		}

		[AsyncStateMachine(typeof(_003CShutdownAsync_003Ed__49))]
		public Task ShutdownAsync(ShutdownReason shutdownReason = ShutdownReason.Ok)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectInternalAsync_003Ed__50))]
		private Task<PhotonConnectResult> ConnectInternalAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CShutdownAsync_003Ed__51))]
		private Task ShutdownAsync(CancellationToken cancellationToken, ShutdownReason shutdownReason = ShutdownReason.Ok)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CConnectInternalAsync_003Ed__52))]
		private Task<StartGameResult> ConnectInternalAsync()
		{
			return null;
		}

		private void LogAppSettings()
		{
		}

		public void OnPlayerJoined(NetworkRunner runner, PlayerRef playerRef)
		{
		}

		public void OnPlayerLeft(NetworkRunner runner, PlayerRef playerRef)
		{
		}

		public void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
		{
		}

		public void OnConnectedToServer(NetworkRunner runner)
		{
		}

		public void OnDisconnectedFromServer(NetworkRunner runner)
		{
		}

		public void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateAuthToken_003Ed__60))]
		private Task<bool> UpdateAuthToken(CancellationToken cancellationToken, bool forceRefresh = false)
		{
			return null;
		}

		private CancellationToken GetToken()
		{
			return default(CancellationToken);
		}

		private void CancelToken()
		{
		}

		public void OnSceneLoadDone(NetworkRunner runner)
		{
		}

		[AsyncStateMachine(typeof(_003CForceReconnect_003Ed__64))]
		[Button(null, EButtonEnableMode.Always)]
		public void ForceReconnect()
		{
		}

		private void SendNotification(Status status)
		{
		}

		public static string GetCurrentConnectionStatusText()
		{
			return null;
		}

		public static bool IsConnectedInSinglePlayer()
		{
			return false;
		}

		public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
		{
		}

		public void OnInput(NetworkRunner runner, NetworkInput input)
		{
		}

		public void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
		{
		}

		public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token)
		{
		}

		public void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message)
		{
		}

		public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
		{
		}

		public void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
		{
		}

		public void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ArraySegment<byte> data)
		{
		}

		public void OnSceneLoadStart(NetworkRunner runner)
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void DebugConnect()
		{
		}

		[Button(null, EButtonEnableMode.Always)]
		private void DebugDisconnect()
		{
		}

		public void SetConnectAsServer(PhotonRegion.Code region, string environmentName, string photonSessionId, ushort port, string publicIpV4 = null, ushort publicPort = 0)
		{
		}
	}
}
