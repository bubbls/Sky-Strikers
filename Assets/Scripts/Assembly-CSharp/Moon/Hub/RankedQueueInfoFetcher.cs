using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.MultiplayerModels;
using UnityEngine;

namespace Moon.Hub
{
	public class RankedQueueInfoFetcher : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetQueueStatistics_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetQueueStatisticsResult> _003C_003Et__builder;

			public string queueName;

			public RankedQueueInfoFetcher _003C_003E4__this;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private GetQueueStatisticsResult _003Cresult_003E5__3;

			private TaskAwaiter<GetQueueStatisticsResult> _003C_003Eu__1;

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
		private struct _003CInitiatePlayerCountFetching_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public RankedQueueInfoFetcher _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<GetQueueStatisticsResult> _003C_003Eu__2;

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

		private const string LastFetchTimeKey = "LastFetchTime";

		private const int DelayBetweenFetches = 70;

		private CancellationTokenSource _playerCountTokenSource;

		private PlayFabMultiplayerInstanceAPI _client;

		private uint _playersSearchingForMatchCount;

		private string _targetQueue;

		public event Action<uint> OnPlayerCountFetched
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

		public void TryStartPlayerCountFetching()
		{
		}

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003CInitiatePlayerCountFetching_003Ed__11))]
		private void InitiatePlayerCountFetching(CancellationToken cancellationToken)
		{
		}

		[AsyncStateMachine(typeof(_003CGetQueueStatistics_003Ed__12))]
		private Task<GetQueueStatisticsResult> GetQueueStatistics(string queueName)
		{
			return null;
		}

		public void CancelPlayerCountFetching()
		{
		}

		private void GetDelayToStartFetching(out int delay)
		{
			delay = default(int);
		}
	}
}
