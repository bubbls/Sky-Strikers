using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using JetBrains.Annotations;
using Moon.Arena;
using Moon.Framework.Base;
using Moon.Framework.Service.PlayFab;
using PlayFab;
using PlayFab.MultiplayerModels;
using UnityEngine.Scripting;

namespace Moon.Bootstrap
{
	[Preserve]
	public class ClientMatchmakingService : IInitializer
	{
		private class Ticket
		{
			public string TicketId;

			public string QueueName;

			public FieldType FieldType;

			public long DateExpires;

			public bool IsPrivateSession;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass21_0
		{
			public TaskCompletionSource<bool> taskQos;

			internal void _003CPrepareForMatchmakingAsync_003Eb__0()
			{
			}

			internal void _003CPrepareForMatchmakingAsync_003Eb__1(List<Latency> latencies)
			{
			}

			internal void _003CPrepareForMatchmakingAsync_003Eb__2()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			public TaskCompletionSource<CreateMatchmakingTicketResult> source;

			public PlayFabError playFabError;

			internal void _003CCreateMatchmakingTicketInternal_003Eb__0()
			{
			}

			internal void _003CCreateMatchmakingTicketInternal_003Eb__1(CreateMatchmakingTicketResult result)
			{
			}

			internal void _003CCreateMatchmakingTicketInternal_003Eb__2(PlayFabError error)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass48_0
		{
			public TaskCompletionSource<JoinMatchmakingTicketResult> source;

			public PlayFabError playFabError;

			internal void _003CJoinMatchmakingTicketInternal_003Eb__0()
			{
			}

			internal void _003CJoinMatchmakingTicketInternal_003Eb__1(JoinMatchmakingTicketResult result)
			{
			}

			internal void _003CJoinMatchmakingTicketInternal_003Eb__2(PlayFabError error)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCancelAllMatchmakingTicketsInQueue_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string queueName;

			public CancellationToken cancellationToken;

			public ClientMatchmakingService _003C_003E4__this;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private TaskAwaiter<CancelAllMatchmakingTicketsForPlayerResult> _003C_003Eu__1;

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
		private struct _003CCheckVersion_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public CancellationToken cancellationToken;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateMatchmakingTicket_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CreateMatchmakingTicketResult> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public ClientMatchmakingService _003C_003E4__this;

			public FieldType fieldType;

			public int giveUpAfterSeconds;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<CreateMatchmakingTicketResult> _003C_003Eu__2;

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
		private struct _003CCreateMatchmakingTicketAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CreateMatchmakingTicketResult> _003C_003Et__builder;

			public FieldType fieldType;

			public int giveUpAfterSeconds;

			public ClientMatchmakingService _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<CreateMatchmakingTicketResult> _003C_003Eu__1;

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
		private struct _003CCreateMatchmakingTicketInternal_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CreateMatchmakingTicketResult> _003C_003Et__builder;

			public ClientMatchmakingService _003C_003E4__this;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

			public CreateMatchmakingTicketRequest request;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private CreateMatchmakingTicketResult _003Cresult_003E5__3;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<CreateMatchmakingTicketResult> _003C_003Eu__2;

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
		private struct _003CCreatePairRankedMatchmakingTicket_003Ed__52 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CreateMatchmakingTicketResult> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public FieldType fieldType;

			public List<string> pairPlayFabIdList;

			public float mmrScore;

			public int giveUpAfterSeconds;

			public ClientMatchmakingService _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<CreateMatchmakingTicketResult> _003C_003Eu__2;

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
		private struct _003CCreateRankedMatchmakingTicket_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<CreateMatchmakingTicketResult> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public FieldType fieldType;

			public float mmrScore;

			public int giveUpAfterSeconds;

			public ClientMatchmakingService _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<CreateMatchmakingTicketResult> _003C_003Eu__2;

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
		private struct _003CGetMatch_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetMatchResult> _003C_003Et__builder;

			public ClientMatchmakingService _003C_003E4__this;

			public string queueName;

			public string matchId;

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
		private struct _003CGetMatchmakingTicket_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetMatchmakingTicketResult> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public string queueName;

			public string ticketId;

			public ClientMatchmakingService _003C_003E4__this;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private GetMatchmakingTicketResult _003Cresult_003E5__3;

			private TaskAwaiter<GetMatchmakingTicketResult> _003C_003Eu__1;

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
		private struct _003CIsServerUnderMaintenance_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public ClientMatchmakingService _003C_003E4__this;

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
		private struct _003CJoinMatchmakingTicketInternal_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<JoinMatchmakingTicketResult> _003C_003Et__builder;

			public ClientMatchmakingService _003C_003E4__this;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;

			public JoinMatchmakingTicketRequest request;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private JoinMatchmakingTicketResult _003Cresult_003E5__3;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<JoinMatchmakingTicketResult> _003C_003Eu__2;

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
		private struct _003CPollingMatchmaking_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public CancellationToken cancellationToken;

			public ClientMatchmakingService _003C_003E4__this;

			public string ticketId;

			private string _003CqueueName_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<GetMatchmakingTicketResult> _003C_003Eu__2;

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
		private struct _003CPrepareForMatchmakingAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public MatchmakingStatus connectingStatus;

			public float delayInSeconds;

			public CancellationToken matchToken;

			public MatchmakingStatus cancelledStatus;

			public ClientMatchmakingService _003C_003E4__this;

			public MatchmakingStatus failedStatus;

			private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private Task _003CtaskQosTimeout_003E5__3;

			private bool _003Cresult_003E5__4;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<bool> _003C_003Eu__2;

			private TaskAwaiter<Task> _003C_003Eu__3;

			private ValueTaskAwaiter _003C_003Eu__4;

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
		private struct _003CTryCancelMatchmakingAsync_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public string source;

			public ClientMatchmakingService _003C_003E4__this;

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
		private struct _003CTryCancelMatchmakingTicketInAllQueues_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public ClientMatchmakingService _003C_003E4__this;

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
		private struct _003CTryConnectToPairRankedPublicSessionAsync_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public List<string> pairPlayFabIdList;

			public float mmrScore;

			public CancellationToken cancellationToken;

			private object _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private MatchmakingResult _003Cresult_003E5__4;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private Exception _003Cex_003E5__5;

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
		private struct _003CTryConnectToPrivateSessionAsync_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public FieldType fieldType;

			public string roomName;

			public ClientMatchmakingService _003C_003E4__this;

			public float delayInSeconds;

			private CancellationToken _003CmatchToken_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<bool> _003C_003Eu__2;

			private object _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private MatchmakingResult _003Cresult_003E5__5;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__3;

			private Exception _003Cex_003E5__6;

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
		private struct _003CTryConnectToPublicSessionAsync_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public CancellationToken cancellationToken;

			private object _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private MatchmakingResult _003Cresult_003E5__4;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private Exception _003Cex_003E5__5;

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
		private struct _003CTryConnectToRankedPublicSessionAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public float mmrScore;

			public CancellationToken cancellationToken;

			private object _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private MatchmakingResult _003Cresult_003E5__4;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private Exception _003Cex_003E5__5;

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
		private struct _003CTryJoinPairRankedSessionAsync_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<JoinMatchmakingTicketResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public List<string> preferredRegions;

			public string ticketId;

			public float mmrScore;

			private CancellationToken _003CmatchToken_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<bool> _003C_003Eu__2;

			private TaskAwaiter<JoinMatchmakingTicketResult> _003C_003Eu__3;

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
		private struct _003CTryMultiPersonMatchmaking_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public List<string> pairPlayFabIdList;

			public float mmrScore;

			public int giveUpAfterSeconds;

			public CancellationToken cancellationToken;

			private CreateMatchmakingTicketResult _003CcreateMatchmakingTicketResult_003E5__2;

			private TaskAwaiter<CreateMatchmakingTicketResult> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__3;

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
		private struct _003CTryPrivateMatchmaking_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public string roomName;

			public ClientMatchmakingService _003C_003E4__this;

			public int giveUpAfterSeconds;

			public CancellationToken cancellationToken;

			private TaskAwaiter<CreateMatchmakingTicketResult> _003C_003Eu__1;

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
		private struct _003CTryPublicMatchmaking_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public int giveUpAfterSeconds;

			public CancellationToken cancellationToken;

			private TaskAwaiter<CreateMatchmakingTicketResult> _003C_003Eu__1;

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
		private struct _003CTryPublicRankedMatchmaking_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public float mmrScore;

			public int giveUpAfterSeconds;

			public CancellationToken cancellationToken;

			private TaskAwaiter<CreateMatchmakingTicketResult> _003C_003Eu__1;

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
		private struct _003CTryStartMultiPersonMatchmaking_003Ed__50 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public List<string> pairPlayFabIdList;

			public float mmrScore;

			public CancellationToken cancellationToken;

			private MatchmakingResult _003CmatchmakingResult_003E5__2;

			private int _003Ccount_003E5__3;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__1;

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
		private struct _003CTryStartOrRestorePairRankedSessionAsync_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public List<string> preferredRegions;

			public List<string> pairPlayFabIdList;

			public float mmrScore;

			private CancellationToken _003CmatchToken_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<bool> _003C_003Eu__2;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__3;

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
		private struct _003CTryStartOrRestorePublicMatchmaking_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public CancellationToken cancellationToken;

			private MatchmakingResult _003CmatchmakingResult_003E5__2;

			private int _003Ccount_003E5__3;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__1;

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
		private struct _003CTryStartOrRestorePublicRankedMatchmaking_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public float mmrScore;

			public CancellationToken cancellationToken;

			private MatchmakingResult _003CmatchmakingResult_003E5__2;

			private int _003Ccount_003E5__3;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__1;

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
		private struct _003CTryStartOrRestorePublicSessionAsync_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public float delayInSeconds;

			private CancellationToken _003CmatchToken_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

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
		private struct _003CTryStartOrRestoreRankedSessionAsync_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<MatchmakingResult> _003C_003Et__builder;

			public FieldType fieldType;

			public ClientMatchmakingService _003C_003E4__this;

			public List<string> preferredRegions;

			public float mmrScore;

			private CancellationToken _003CmatchToken_003E5__2;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<bool> _003C_003Eu__2;

			private TaskAwaiter<MatchmakingResult> _003C_003Eu__3;

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

		private const int PollingCooldown = 6000;

		private const int OnMatchedEventDelay = 12000;

		private const int GiveUpDuration = 180;

		private const int RankedGiveUpDuration = 600;

		private const float CreateMatchmakingTicketCooldown = 10f;

		private const string StaMatched = "Matched";

		private const string StaCanceled = "Canceled";

		private PlayFabMultiplayerInstanceAPI _client;

		private ClientQos _clientQos;

		private CancellationTokenSource _matchmakingTokenSource;

		private float _nextCreateMatchmakingTicketApiTime;

		[CanBeNull]
		private Ticket _currentTicket;

		public void Initialize()
		{
		}

		[AsyncStateMachine(typeof(_003CIsServerUnderMaintenance_003Ed__14))]
		public Task<bool> IsServerUnderMaintenance()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCheckVersion_003Ed__15))]
		private Task<bool> CheckVersion(CancellationToken cancellationToken)
		{
			return null;
		}

		private void CacheTicketFromMatchMakingResult(CreateMatchmakingTicketResult createMatchmakingTicketResult, FieldType fieldType, bool isPrivateSession)
		{
		}

		private void DeleteCreatedTicket()
		{
		}

		private static void MakeFakeLatencies()
		{
		}

		private static Latency NewBarelyWorkingLatency(PlayFabRegion region, int offsetMs = 0)
		{
			return null;
		}

		private CancellationToken CreateMatchmakingToken()
		{
			return default(CancellationToken);
		}

		[AsyncStateMachine(typeof(_003CPrepareForMatchmakingAsync_003Ed__21))]
		private Task<bool> PrepareForMatchmakingAsync(float delayInSeconds, CancellationToken matchToken, MatchmakingStatus connectingStatus, MatchmakingStatus failedStatus, MatchmakingStatus cancelledStatus)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateMatchmakingTicket_003Ed__22))]
		private Task<CreateMatchmakingTicketResult> CreateMatchmakingTicket(FieldType fieldType, int giveUpAfterSeconds, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateMatchmakingTicketAsync_003Ed__23))]
		private Task<CreateMatchmakingTicketResult> CreateMatchmakingTicketAsync(FieldType fieldType, int giveUpAfterSeconds, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateMatchmakingTicketInternal_003Ed__24))]
		private Task<CreateMatchmakingTicketResult> CreateMatchmakingTicketInternal(CreateMatchmakingTicketRequest request, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetMatchmakingTicket_003Ed__25))]
		private Task<GetMatchmakingTicketResult> GetMatchmakingTicket(string queueName, string ticketId, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CPollingMatchmaking_003Ed__26))]
		private Task<MatchmakingResult> PollingMatchmaking(FieldType fieldType, string ticketId, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetMatch_003Ed__27))]
		private Task<GetMatchResult> GetMatch(CancellationToken cancellationToken, string queueName, string matchId)
		{
			return null;
		}

		private static void OnMatched(GetMatchResult getMatchResult)
		{
		}

		private static void RaiseMatchMakingResult(MatchmakingResult result)
		{
		}

		[AsyncStateMachine(typeof(_003CTryCancelMatchmakingAsync_003Ed__30))]
		public Task TryCancelMatchmakingAsync(string source)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryCancelMatchmakingTicketInAllQueues_003Ed__31))]
		private Task TryCancelMatchmakingTicketInAllQueues()
		{
			return null;
		}

		private void CancelMatchmakingToken()
		{
		}

		[AsyncStateMachine(typeof(_003CCancelAllMatchmakingTicketsInQueue_003Ed__33))]
		private Task CancelAllMatchmakingTicketsInQueue(CancellationToken cancellationToken, string queueName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryConnectToPrivateSessionAsync_003Ed__34))]
		public Task TryConnectToPrivateSessionAsync(FieldType fieldType, string roomName, float delayInSeconds = 0f)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryPrivateMatchmaking_003Ed__35))]
		private Task<MatchmakingResult> TryPrivateMatchmaking(FieldType fieldType, string roomName, int giveUpAfterSeconds, CancellationToken cancellationToken)
		{
			return null;
		}

		private static void InitializeEnvironmentArgs()
		{
		}

		[AsyncStateMachine(typeof(_003CTryStartOrRestorePublicSessionAsync_003Ed__37))]
		public Task TryStartOrRestorePublicSessionAsync(FieldType fieldType, float delayInSeconds = 0f)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryConnectToPublicSessionAsync_003Ed__38))]
		private Task TryConnectToPublicSessionAsync(FieldType fieldType, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryStartOrRestorePublicMatchmaking_003Ed__39))]
		private Task<MatchmakingResult> TryStartOrRestorePublicMatchmaking(FieldType fieldType, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryPublicMatchmaking_003Ed__40))]
		private Task<MatchmakingResult> TryPublicMatchmaking(FieldType fieldType, int giveUpAfterSeconds, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryStartOrRestoreRankedSessionAsync_003Ed__41))]
		public Task<MatchmakingResult> TryStartOrRestoreRankedSessionAsync(FieldType fieldType, float mmrScore, List<string> preferredRegions)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryConnectToRankedPublicSessionAsync_003Ed__42))]
		private Task<MatchmakingResult> TryConnectToRankedPublicSessionAsync(FieldType fieldType, float mmrScore, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryStartOrRestorePublicRankedMatchmaking_003Ed__43))]
		private Task<MatchmakingResult> TryStartOrRestorePublicRankedMatchmaking(FieldType fieldType, float mmrScore, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryPublicRankedMatchmaking_003Ed__44))]
		private Task<MatchmakingResult> TryPublicRankedMatchmaking(FieldType fieldType, float mmrScore, int giveUpAfterSeconds, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreateRankedMatchmakingTicket_003Ed__45))]
		private Task<CreateMatchmakingTicketResult> CreateRankedMatchmakingTicket(FieldType fieldType, float mmrScore, int giveUpAfterSeconds, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryStartOrRestorePairRankedSessionAsync_003Ed__46))]
		public Task<MatchmakingResult> TryStartOrRestorePairRankedSessionAsync(List<string> pairPlayFabIdList, FieldType fieldType, float mmrScore, List<string> preferredRegions)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryJoinPairRankedSessionAsync_003Ed__47))]
		public Task<JoinMatchmakingTicketResult> TryJoinPairRankedSessionAsync(string ticketId, FieldType fieldType, float mmrScore, List<string> preferredRegions)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CJoinMatchmakingTicketInternal_003Ed__48))]
		private Task<JoinMatchmakingTicketResult> JoinMatchmakingTicketInternal(JoinMatchmakingTicketRequest request, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryConnectToPairRankedPublicSessionAsync_003Ed__49))]
		private Task<MatchmakingResult> TryConnectToPairRankedPublicSessionAsync(List<string> pairPlayFabIdList, FieldType fieldType, float mmrScore, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryStartMultiPersonMatchmaking_003Ed__50))]
		private Task<MatchmakingResult> TryStartMultiPersonMatchmaking(List<string> pairPlayFabIdList, FieldType fieldType, float mmrScore, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CTryMultiPersonMatchmaking_003Ed__51))]
		private Task<MatchmakingResult> TryMultiPersonMatchmaking(List<string> pairPlayFabIdList, FieldType fieldType, float mmrScore, int giveUpAfterSeconds, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCreatePairRankedMatchmakingTicket_003Ed__52))]
		private Task<CreateMatchmakingTicketResult> CreatePairRankedMatchmakingTicket(List<string> pairPlayFabIdList, FieldType fieldType, float mmrScore, int giveUpAfterSeconds, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
