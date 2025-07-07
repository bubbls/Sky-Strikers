using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.MultiplayerModels;

namespace Moon.Bootstrap
{
	public class ClientQos
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public TaskCompletionSource<List<RegionPinger>> taskListQos;

			public ClientQos _003C_003E4__this;

			internal void _003CStartCheckQosAsync_003Eb__0(ListQosServersForTitleResponse response)
			{
			}

			internal void _003CStartCheckQosAsync_003Eb__1(PlayFabError error)
			{
			}

			internal Task<RegionPinger> _003CStartCheckQosAsync_003Eb__5(RegionPinger p)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStartCheckQosAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ClientQos _003C_003E4__this;

			public Action<List<Latency>> onComplete;

			public Action onError;

			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			private Task _003CtimeoutTask_003E5__2;

			private List<RegionPinger> _003Cpingers_003E5__3;

			private TaskAwaiter<Task> _003C_003Eu__1;

			private TaskAwaiter<List<RegionPinger>> _003C_003Eu__2;

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

		public const int TimeoutMs = 10000;

		private const int NumTimeoutsForError = 3;

		private const int ExpectedPingsPerRegion = 150;

		private readonly PlayFabMultiplayerInstanceAPI _client;

		private CancellationTokenSource _cancellationTokenSource;

		private Action<List<Latency>> _onComplete;

		private Action _onError;

		public void Dispose()
		{
		}

		private void CancelPreviousTokenAndReset()
		{
		}

		private void ClearCallbacks()
		{
		}

		[AsyncStateMachine(typeof(_003CStartCheckQosAsync_003Ed__11))]
		public void StartCheckQosAsync(Action<List<Latency>> onComplete, Action onError)
		{
		}

		private static Latency NewLatency(QosRegionResult result)
		{
			return null;
		}
	}
}
