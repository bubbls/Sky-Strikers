using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Moon.Framework.Service.PlayFab;
using PlayFab;
using PlayFab.MultiplayerModels;
using PlayFab.ServerModels;

namespace Moon.Bootstrap
{
	public static class PlayFabAPIHelper
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCancelBackfillTicket_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string ticketId;

			public CancellationToken cancellationToken;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private TaskAwaiter<CancelServerBackfillTicketResult> _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

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
		private struct _003CCreateBackfillTicket_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CreateServerBackfillTicketResult> _003C_003Et__builder;

			public int giveUpAfterSeconds;

			public bool isPrivateSession;

			public List<MatchmakingPlayerWithTeamAssignment> members;

			public CancellationToken cancellationToken;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private CreateServerBackfillTicketResult _003Cresult_003E5__3;

			private PlayFabError _003Cerror_003E5__4;

			private TaskAwaiter<(CreateServerBackfillTicketResult Result, PlayFabError Error)> _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

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
		private struct _003CGetBackfillTicket_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetServerBackfillTicketResult> _003C_003Et__builder;

			public string ticketId;

			public CancellationToken cancellationToken;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private GetServerBackfillTicketResult _003Cresult_003E5__3;

			private TaskAwaiter<GetServerBackfillTicketResult> _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

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
		private struct _003CGetMatch_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetMatchResult> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			private TaskAwaiter<Utils.Response<GetMatchResult>> _003C_003Eu__1;

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
		private struct _003CGetMatchmakingQueue_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetMatchmakingQueueResult> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public string queueName;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private GetMatchmakingQueueResult _003Cresult_003E5__3;

			private TaskAwaiter<GetMatchmakingQueueResult> _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

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
		private struct _003CGetUseAccountInfo_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetUserAccountInfoResult> _003C_003Et__builder;

			public string playFabId;

			public CancellationToken cancellationToken;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private GetUserAccountInfoResult _003Cresult_003E5__3;

			private TaskAwaiter<GetUserAccountInfoResult> _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

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
		private struct _003CShutdownServer_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

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

		[AsyncStateMachine(typeof(_003CGetMatchmakingQueue_003Ed__0))]
		public static Task<GetMatchmakingQueueResult> GetMatchmakingQueue(CancellationToken cancellationToken, string queueName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetMatch_003Ed__1))]
		public static Task<GetMatchResult> GetMatch(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetUseAccountInfo_003Ed__2))]
		public static Task<GetUserAccountInfoResult> GetUseAccountInfo(CancellationToken cancellationToken, string playFabId)
		{
			return null;
		}

		public static PlayFab.MultiplayerModels.EntityKey CreateEntityKeyFromPlayerString(string playerString)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateBackfillTicket_003Ed__4))]
		public static Task<CreateServerBackfillTicketResult> CreateBackfillTicket(CancellationToken cancellationToken, List<MatchmakingPlayerWithTeamAssignment> members, int giveUpAfterSeconds, bool isPrivateSession)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCancelBackfillTicket_003Ed__5))]
		public static Task CancelBackfillTicket(CancellationToken cancellationToken, string ticketId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetBackfillTicket_003Ed__6))]
		public static Task<GetServerBackfillTicketResult> GetBackfillTicket(CancellationToken cancellationToken, string ticketId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CShutdownServer_003Ed__7))]
		public static Task ShutdownServer(CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
