using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DP.Takeaway.Utils;
using PlayFab.MultiplayerModels;

namespace Moon.Bootstrap
{
	public class PlayFabBackfillTicket
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCancelTicket_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayFabBackfillTicket _003C_003E4__this;

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
		private struct _003CCreateTicket_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public List<MatchmakingPlayerWithTeamAssignment> members;

			public PlayFabBackfillTicket _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<CreateServerBackfillTicketResult> _003C_003Eu__1;

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
		private struct _003CDisposeAsync_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayFabBackfillTicket _003C_003E4__this;

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
		private struct _003CGetTicketStatus_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public PlayFabBackfillTicket _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<GetServerBackfillTicketResult> _003C_003Eu__1;

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
		private struct _003CStartBackFillingInternalAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public PlayFabBackfillTicket _003C_003E4__this;

			private TaskAwaiter<GetMatchmakingQueueResult> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private TaskAwaiter<bool> _003C_003Eu__3;

			private TaskAwaiter<string> _003C_003Eu__4;

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

		private const int BackfillTicketTimeout = 600;

		private const int MaximumTicketTimesPerMinute = 6;

		private const int TicketLoopInterval = 4000;

		private const int StatusLoopInterval = 60000;

		private const int InitialPlayersJoiningTimeout = 30;

		private GetMatchmakingQueueResult _matchmakingQueue;

		private CancellationTokenSource _cancellationTokenSource;

		private string _ticketId;

		private int _ticketTimes;

		private int _statusLoopTime;

		private Cooldown _ticketCreationTimesRechargeCd;

		private Cooldown _ticketExpireCd;

		private Cooldown _cooldownStatus;

		private bool _isPrivateSession;

		private bool _shouldUpdateTicket;

		private readonly List<MatchmakingPlayerWithTeamAssignment> _playersInTicket;

		private readonly Dictionary<string, float> _initialPlayersDictionary;

		private bool _ticketExpired;

		public void StartBackFilling(List<MatchmakingPlayerWithTeamAssignment> initialPlayers, bool isPrivateSession)
		{
		}

		private void HandleMatchmakingPlayersChanged(ServerSharedData.Change change)
		{
		}

		private static bool MergePlayers(List<MatchmakingPlayerWithTeamAssignment> source, List<MatchmakingPlayerWithTeamAssignment> target)
		{
			return false;
		}

		private static bool RemovePlayers(List<MatchmakingPlayerWithTeamAssignment> toRemove, List<MatchmakingPlayerWithTeamAssignment> list)
		{
			return false;
		}

		private static bool PlayerExists(MatchmakingPlayerWithTeamAssignment player, List<MatchmakingPlayerWithTeamAssignment> list)
		{
			return false;
		}

		private static bool RemovePlayer(MatchmakingPlayerWithTeamAssignment player, List<MatchmakingPlayerWithTeamAssignment> list)
		{
			return false;
		}

		private void TryRemoveFromInitialPlayers(List<MatchmakingPlayerWithTeamAssignment> playersToRemove)
		{
		}

		[AsyncStateMachine(typeof(_003CStartBackFillingInternalAsync_003Ed__25))]
		private Task StartBackFillingInternalAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private void RenewTicketExpiration()
		{
		}

		private void SetTicketExpired()
		{
		}

		private void TickTicketExpire()
		{
		}

		private void TryRemoveInitialPlayersWhoFailedToConnect()
		{
		}

		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__30))]
		public Task DisposeAsync()
		{
			return null;
		}

		public void Tick()
		{
		}

		[AsyncStateMachine(typeof(_003CCancelTicket_003Ed__32))]
		private Task CancelTicket(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateTicket_003Ed__33))]
		private Task<bool> CreateTicket(List<MatchmakingPlayerWithTeamAssignment> members, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetTicketStatus_003Ed__34))]
		private Task<string> GetTicketStatus(CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
