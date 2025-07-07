using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using PlayFab;
using PlayFab.MultiplayerModels;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	public class LobbyService : IInitializer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CClientFindJoinedLobbyAsync_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<List<LobbySummary>> _003C_003Et__builder;

			public LobbyService _003C_003E4__this;

			private TaskAwaiter<List<LobbySummary>> _003C_003Eu__1;

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
		private struct _003CClientFindLobbyAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<List<LobbySummary>> _003C_003Et__builder;

			public string filter;

			public LobbyService _003C_003E4__this;

			private TaskAwaiter<List<LobbySummary>> _003C_003Eu__1;

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
		private struct _003CClientGetLobbyAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Lobby> _003C_003Et__builder;

			public string lobbyId;

			public LobbyService _003C_003E4__this;

			private TaskAwaiter<Lobby> _003C_003Eu__1;

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
		private struct _003CClientJoinAsync_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<JoinLobbyResult> _003C_003Et__builder;

			public string connString;

			public Dictionary<string, string> memberData;

			public LobbyService _003C_003E4__this;

			private TaskAwaiter<JoinLobbyResult> _003C_003Eu__1;

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
		private struct _003CClientLeaveLobbyAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public string lobbyId;

			public LobbyService _003C_003E4__this;

			private TaskAwaiter<bool> _003C_003Eu__1;

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
		private struct _003CClientPollLobbyChangesAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Lobby> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public LobbyService _003C_003E4__this;

			public string lobbyId;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<Lobby> _003C_003Eu__2;

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
		private struct _003CGetLobbyInternalAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Lobby> _003C_003Et__builder;

			public string lobbyId;

			public PlayFabMultiplayerInstanceAPI api;

			private TaskAwaiter<Lobby> _003C_003Eu__1;

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
		private struct _003CLeaveLobbyInternalAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public string lobbyId;

			public EntityKey entityKey;

			public PlayFabMultiplayerInstanceAPI api;

			private TaskAwaiter<bool> _003C_003Eu__1;

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
		private struct _003CServerCreateLobbyAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CreateLobbyResult> _003C_003Et__builder;

			public uint maxMemberCount;

			public LobbyService _003C_003E4__this;

			private TaskAwaiter<CreateLobbyResult> _003C_003Eu__1;

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
		private struct _003CServerGetLobbyAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Lobby> _003C_003Et__builder;

			public string lobbyId;

			public LobbyService _003C_003E4__this;

			private TaskAwaiter<Lobby> _003C_003Eu__1;

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
		private struct _003CServerUpdateLobbyData_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string lobbyId;

			public Dictionary<string, string> lobbyData;

			public LobbyService _003C_003E4__this;

			private TaskAwaiter<PlayFabError> _003C_003Eu__1;

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
		private struct _003CUpdateLobbyDataAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public string lobbyId;

			public Dictionary<string, string> lobbyData;

			public LobbyService _003C_003E4__this;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		private const int PollLobbyInterval = 10000;

		private PlayFabMultiplayerInstanceAPI _gameServer;

		private PlayFabMultiplayerInstanceAPI _client;

		public void Initialize()
		{
		}

		public bool ClientIsReady()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CServerCreateLobbyAsync_003Ed__5))]
		public Task<CreateLobbyResult> ServerCreateLobbyAsync(uint maxMemberCount)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CServerUpdateLobbyData_003Ed__6))]
		public Task ServerUpdateLobbyData(string lobbyId, Dictionary<string, string> lobbyData)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClientJoinAsync_003Ed__7))]
		public Task<JoinLobbyResult> ClientJoinAsync(string connString, Dictionary<string, string> memberData = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdateLobbyDataAsync_003Ed__8))]
		public Task<bool> UpdateLobbyDataAsync(string lobbyId, Dictionary<string, string> lobbyData)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CServerGetLobbyAsync_003Ed__9))]
		public Task<Lobby> ServerGetLobbyAsync(string lobbyId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClientGetLobbyAsync_003Ed__10))]
		public Task<Lobby> ClientGetLobbyAsync(string lobbyId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetLobbyInternalAsync_003Ed__11))]
		private static Task<Lobby> GetLobbyInternalAsync(string lobbyId, PlayFabMultiplayerInstanceAPI api)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClientPollLobbyChangesAsync_003Ed__12))]
		private Task<Lobby> ClientPollLobbyChangesAsync(string lobbyId, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClientFindJoinedLobbyAsync_003Ed__13))]
		public Task<List<LobbySummary>> ClientFindJoinedLobbyAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClientFindLobbyAsync_003Ed__14))]
		private Task<List<LobbySummary>> ClientFindLobbyAsync(string filter)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CClientLeaveLobbyAsync_003Ed__15))]
		public Task<bool> ClientLeaveLobbyAsync(string lobbyId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLeaveLobbyInternalAsync_003Ed__16))]
		private static Task<bool> LeaveLobbyInternalAsync(string lobbyId, EntityKey entityKey, PlayFabMultiplayerInstanceAPI api)
		{
			return null;
		}

		public static bool IsLobbyIdValid(string lobbyIdValue)
		{
			return false;
		}
	}
}
