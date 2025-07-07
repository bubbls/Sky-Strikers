using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Messaging;
using Fusion;
using Moon.Framework.Leaderboard;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Leaderboard
{
	[NetworkBehaviourWeaved(0)]
	public class MLeaderboardManager : NetworkBehaviourSingleton<MLeaderboardManager>
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass57_0
		{
			public MLeaderboardManager _003C_003E4__this;

			public string localPlayFabId;

			public TaskCompletionSource<int> tcs0;

			public TaskCompletionSource<int> tcs1;

			public Func<LeaderboardEntry, LeaderboardEntry> _003C_003E9__6;

			public Func<LeaderboardEntry, LeaderboardEntry> _003C_003E9__7;

			internal void _003CRequestDataContributionLeaderboardInternal_003Eb__0(IEnumerable<LeaderboardEntry> list)
			{
			}

			internal LeaderboardEntry _003CRequestDataContributionLeaderboardInternal_003Eb__6(LeaderboardEntry a)
			{
				return default(LeaderboardEntry);
			}

			internal void _003CRequestDataContributionLeaderboardInternal_003Eb__1()
			{
			}

			internal void _003CRequestDataContributionLeaderboardInternal_003Eb__2(IEnumerable<LeaderboardEntry> list)
			{
			}

			internal LeaderboardEntry _003CRequestDataContributionLeaderboardInternal_003Eb__7(LeaderboardEntry a)
			{
				return default(LeaderboardEntry);
			}

			internal void _003CRequestDataContributionLeaderboardInternal_003Eb__3()
			{
			}

			internal void _003CRequestDataContributionLeaderboardInternal_003Eb__4(IEnumerable<LeaderboardEntry> list)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRequestDataContributionLeaderboardInternal_003Ed__57 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public MLeaderboardManager _003C_003E4__this;

			private _003C_003Ec__DisplayClass57_0 _003C_003E8__1;

			private TaskAwaiter<int[]> _003C_003Eu__1;

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
		private struct _003CTemporaryIncrMyDataContributionAndRequestLeaderboardLaterInternal_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public int amount;

			public MLeaderboardManager _003C_003E4__this;

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

		[SerializeField]
		private PlayerStatisticsViewSetting _playerStatisticsViewSetting;

		private const int TotalDataContributionEntryCount = 1;

		private const int LeaderboardEntryCount = 10;

		private const int LeaderboardAroundMeEntryCount = 3;

		private const int DataContributionRequestDelay = 10000;

		private const float LimitedTime = 1f;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private ILeaderboard _leaderboardServer;

		private ILeaderboardClient _leaderboardClient;

		private PlayerStatistics _cachedMyStatistics;

		private Dictionary<PlayerSuitClass, PlayerRankedStatistics> _cacheMyRankedStatistics;

		private readonly Dictionary<string, (PlayerStatistics statistics, float lastRequestTime)> _cachedPlayerStatistics;

		private readonly Dictionary<string, Dictionary<PlayerSuitClass, (PlayerRankedStatistics statistics, float lastRequestTime)>> _cachedPlayerRankedStatistics;

		private readonly List<LeaderboardEntry> _dataContributionLeaderboard;

		private readonly List<LeaderboardEntry> _dataContributionLeaderboardAroundMe;

		private LeaderboardEntry _totalDataContributionEntry;

		private float _lastMyStatsRequestTime;

		private bool _hasMyStatistics;

		private static Changed<MLeaderboardManager> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MLeaderboardManager> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MLeaderboardManager> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private int HandlePlayerStatsUpdated(IMessage<object> message)
		{
			return 0;
		}

		private int HandlePlayerRankedStatsUpdated(IMessage<PlayerRankedStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerLastMatchStatsUpdated(IMessage<PlayerLastMatchStatisticsUpdatedMessage> message)
		{
			return 0;
		}

		private void UpdatePlayerStatistics(PlayerRef playerRef)
		{
		}

		public static void GetStatForPlayerOnServer(string playFabId, List<string> statsName, Action<bool, List<Statistic>> onComplete)
		{
		}

		private void UpdatePlayerRankedStatistics(PlayerRef playerRef, PlayerSuitClass suitClass, PlayerStatisticsViewSetting.PageType pageType)
		{
		}

		private void UpdatePlayerLastMatchStatistics(PlayerLastMatchStatistics lastMatchStatistics)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void RPC_NotifyPlayerStaticsUpdated(PlayerRef playerRef, PlayerStatistics statistics)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void RPC_NotifyPlayerRankedStaticsUpdated(PlayerRef playerRef, PlayerSuitClass suitClass, PlayerStatisticsViewSetting.PageType pageType, PlayerRankedStatistics rankedStatistics)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void RPC_NotifyPlayerLastMatchStaticsUpdate(PlayerLastMatchStatistics matchStatistics)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		public void Rpc_ExecuteLevelUp(PlayerRef playerRef, PlayerStatistics statistics)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void Rpc_OnLevelUpdated(PlayerRef playerRef, PlayerStatistics statistics, int prevLevel)
		{
		}

		private static void NotifyPlayerStaticsUpdatedInternal(PlayerRef playerRef, PlayerStatistics statistics)
		{
		}

		private static void NotifyPlayerRankedStaticsUpdatedInternal(PlayerRef playerRef, PlayerSuitClass suitClass, PlayerStatisticsViewSetting.PageType pageType, PlayerRankedStatistics statistics)
		{
		}

		private static void NotifyPlayerLastMatchStaticsUpdatedInternal(PlayerLastMatchStatistics matchStatistics)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void Rpc_RequestPlayerStatistics(PlayerRef playerRef)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_UpdatePlayerLegacyStatisticsOnServer(PlayerRef playerRef, PlayerStatistics legacyStatistics)
		{
		}

		private void RequestMyStatistics(Action onComplete = null)
		{
		}

		private void RequestLocalPlayerAllRankStatistics()
		{
		}

		private void RequestLocalPlayerRankStatistics(PlayerSuitClass suitClass)
		{
		}

		private void RequestLocalRankStatisticsInternal(PlayerStatisticsViewSetting.PageType pageType, PlayerSuitClass suitClass)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_RequestPlayerRankedStatisticsOnServer(PlayerRef playerRef, PlayerSuitClass suitClass, PlayerStatisticsViewSetting.PageType pageType, PlayerRankedStatistics rankedStatistics)
		{
		}

		public static void RequestMyRankedStatistics(PlayerStatisticsViewSetting.PageType pageType, PlayerSuitClass suitClass)
		{
		}

		private void RequestStatisticsInternal(PlayerRef playerRef, bool limited)
		{
		}

		public static void RequestStatisticsLimited(PlayerRef playerRef)
		{
		}

		public static void PerformLevelUp(PlayerRef playerRef, PlayerStatistics statistics)
		{
		}

		public static PlayerStatistics GetStatisticsByPlayFabId(string playFabId)
		{
			return default(PlayerStatistics);
		}

		public static PlayerRankedStatistics GetRankedStatistics(string playFabId, PlayerSuitClass suitClass)
		{
			return default(PlayerRankedStatistics);
		}

		public static PlayerRankedStatistics GetMyRankedStatistics(PlayerSuitClass suitClass)
		{
			return default(PlayerRankedStatistics);
		}

		public static PlayerStatistics GetMyStatistics()
		{
			return default(PlayerStatistics);
		}

		public static bool HasMyStatistics()
		{
			return false;
		}

		public static LeaderboardEntry GetTotalDataContributionEntry()
		{
			return default(LeaderboardEntry);
		}

		public static IReadOnlyList<LeaderboardEntry> GetDataContributionLeaderboard()
		{
			return null;
		}

		public static IReadOnlyList<LeaderboardEntry> GetDataContributionLeaderboardAroundMe()
		{
			return null;
		}

		public static void TemporaryIncrMyDataContributionAndRequestLeaderboardLater(int amount)
		{
		}

		[AsyncStateMachine(typeof(_003CTemporaryIncrMyDataContributionAndRequestLeaderboardLaterInternal_003Ed__55))]
		private void TemporaryIncrMyDataContributionAndRequestLeaderboardLaterInternal(int amount)
		{
		}

		public static void RequestDataContributionLeaderboard()
		{
		}

		[AsyncStateMachine(typeof(_003CRequestDataContributionLeaderboardInternal_003Ed__57))]
		private void RequestDataContributionLeaderboardInternal()
		{
		}

		[Rpc]
		private void RPC_NotifyDataContributionLeaderboardUpdated(RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 1, 7)]
		protected unsafe static void RPC_NotifyPlayerStaticsUpdated_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 1, 7)]
		[Preserve]
		protected unsafe static void RPC_NotifyPlayerRankedStaticsUpdated_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 1, 7)]
		protected unsafe static void RPC_NotifyPlayerLastMatchStaticsUpdate_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(4, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_ExecuteLevelUp_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(5, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_OnLevelUpdated_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(6, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_RequestPlayerStatistics_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(7, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_UpdatePlayerLegacyStatisticsOnServer_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(8, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_RequestPlayerRankedStatisticsOnServer_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(9, 7, 7)]
		protected unsafe static void RPC_NotifyDataContributionLeaderboardUpdated_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
