using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using Moon.Bootstrap;
using Moon.Player.Pad;

namespace Moon.MultiPlay
{
	public class RankedMatchmakingController : Singleton<RankedMatchmakingController>
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass52_0
		{
			public bool loadingComplete;

			internal void _003CDebugSimulateMatchFound_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDebugSimulateMatchFound_003Ed__52 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			private _003C_003Ec__DisplayClass52_0 _003C_003E8__1;

			public RankedMatchmakingController _003C_003E4__this;

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
		private struct _003CDelayMatchmakingResetStatus_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RankedMatchmakingController _003C_003E4__this;

			public int delayInSeconds;

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
		private struct _003CDelayNextSearch_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RankedMatchmakingController _003C_003E4__this;

			public int delay;

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
		private struct _003CDelayRejoinLastSession_003Ed__63 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RankedMatchmakingController _003C_003E4__this;

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
		private struct _003CDelayReturnToHub_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RankedMatchmakingController _003C_003E4__this;

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
		private struct _003CPollExistingMatch_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RankedMatchmakingController _003C_003E4__this;

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
		private struct _003CRejoinPublicHubAfterSearchFail_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RankedMatchmakingController _003C_003E4__this;

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
		private struct _003CStartMatchFoundCountdown_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RankedMatchmakingController _003C_003E4__this;

			public Action complete;

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

		private const int RankedMatchTeleportDelay = 5;

		public const int CooldownBetweenSearches = 60;

		private const int PrepareErrorEndDelay = 5;

		private const int ExistingMatchPollingInterval = 25;

		public const string LastMatchInProgressMessage = "LAST MATCH IN PROGRESS, REJOIN AT THE CENTER RANKED CONSOLE";

		private RankedMatchmakingStatus _currentRankedMatchmakingStatus;

		private IMessageSubscriber _playerInitMsgMessageSubscriber;

		private IMessageSubscriber[] _flowSubscribers;

		private bool _canStartSearchingAfterPreCheck;

		private float _searchStartTime;

		private bool _playerTeleported;

		private int _matchFoundDuration;

		private float _pairRankCooldownStartTime;

		private RankedPlayerSessionData _existingSessionData;

		private CancellationTokenSource _existingMatchPolling;

		public RankSearchMode RankSearchMode { get; private set; }

		public RankedMatchmakingStatus CurrentRankedMatchmakingStatus
		{
			get
			{
				return default(RankedMatchmakingStatus);
			}
			private set
			{
			}
		}

		public float MatchmakingStatusResetTime { get; private set; }

		public float BanEndTime { get; private set; }

		protected override void Initialize()
		{
		}

		protected override void Dispose()
		{
		}

		public void CheckRankStatus()
		{
		}

		private void CheckIfPlayerIsEligibleForRankedMatch(Action<HttpStatusCode, RankedPlayerEligibilityResult> callback)
		{
		}

		private void TrySetAlreadyInMatchState(RankedPlayerEligibilityResult rankedPlayerEligibilityResult, bool notify)
		{
		}

		[AsyncStateMachine(typeof(_003CPollExistingMatch_003Ed__35))]
		private Task PollExistingMatch()
		{
			return null;
		}

		public void TryCancelExistingMatchPolling()
		{
		}

		public void StartRankedMatchMaking(FieldType fieldType, int mmrScore, List<string> preferredRegions)
		{
		}

		private void SetToBanState(int remainingBanDuration, bool notify)
		{
		}

		private void RequestJoinRankedSession(FieldType fieldType, int mmrScore, List<string> preferredRegions)
		{
		}

		[AsyncStateMachine(typeof(_003CDelayReturnToHub_003Ed__40))]
		private Task DelayReturnToHub()
		{
			return null;
		}

		private int HandleOnJoinRankedSessionFailed(IMessage<ShutdownMessage> message)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CStartMatchFoundCountdown_003Ed__42))]
		private void StartMatchFoundCountdown(Action complete)
		{
		}

		private int HandleOnApplicationPauseChanged(IMessage<object> message)
		{
			return 0;
		}

		private int HandleOnConnChanged(IMessage<ConnChangedMessage> message)
		{
			return 0;
		}

		private int HandleOnMatchmakingStatusChanged(IMessage<object> arg)
		{
			return 0;
		}

		[AsyncStateMachine(typeof(_003CRejoinPublicHubAfterSearchFail_003Ed__46))]
		private void RejoinPublicHubAfterSearchFail()
		{
		}

		[AsyncStateMachine(typeof(_003CDelayMatchmakingResetStatus_003Ed__47))]
		private void DelayMatchmakingResetStatus(int delayInSeconds)
		{
		}

		[AsyncStateMachine(typeof(_003CDelayNextSearch_003Ed__48))]
		private Task DelayNextSearch(int delay)
		{
			return null;
		}

		public void TryCancelRankedMatchMaking()
		{
		}

		private int HandlePlayerInitializedMessage(IMessage<PlayerInitializedMessage> message)
		{
			return 0;
		}

		private void CompleteMoveToArena()
		{
		}

		[AsyncStateMachine(typeof(_003CDebugSimulateMatchFound_003Ed__52))]
		public void DebugSimulateMatchFound()
		{
		}

		private static void SendLoadingMatchMessage()
		{
		}

		private int GetSearchFlowTime()
		{
			return 0;
		}

		public void PrepareToJoinPairRankedMatchmakingTicket()
		{
		}

		public void StartPairRankedMatchmaking(string creatorPlayFabId, string joinerPlayFabId, List<string> pairPlayFabIdList, FieldType fieldType, int mmrScore, List<string> preferredRegions, Action failedCallback)
		{
		}

		public void StartJoinPairRankedMatchmakingTicket(string ticketId, FieldType fieldType, int mmrScore, List<string> preferredRegions, Action joinedCallback, Action failedCallback)
		{
		}

		public void StartPairSearching()
		{
		}

		public void ConnectToPairRankedMatch(RankedPairMatchFoundNetworkData rankedPairMatchFoundNetworkData)
		{
		}

		private void HandleGeneralPairRankedMatchAttemptComplete(ClientSharedData.Error error)
		{
		}

		public void TryCancelPairRankedMatchMaking(bool forceCooldown)
		{
		}

		public void RejoinExistingRankedSession()
		{
		}

		[AsyncStateMachine(typeof(_003CDelayRejoinLastSession_003Ed__63))]
		private Task DelayRejoinLastSession()
		{
			return null;
		}

		private void RequestRejoinLastSession()
		{
		}

		private void ArenaSharedData_OnHasInitialSync()
		{
		}

		private int HandlePlayerInitializedDuringRejoinMessage(IMessage<PlayerInitializedMessage> message)
		{
			return 0;
		}

		private void TeleportToFieldAfterRejoin()
		{
		}

		private void ClearRegisteredEvents()
		{
		}

		private static void ShowNotification(string message, float duration = 3f, NotificationPad.NotificationType notificationType = NotificationPad.NotificationType.Connection, NotificationPad.NotificationTimerType timerType = NotificationPad.NotificationTimerType.None)
		{
		}
	}
}
