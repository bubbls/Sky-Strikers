using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Moon.Bootstrap
{
	public class RegionPinger
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			public CancellationTokenSource ct;

			internal void _003CPingAsync_003Eb__0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPingAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<RegionPinger> _003C_003Et__builder;

			public RegionPinger _003C_003E4__this;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private Task<int> _003CpingResultTask_003E5__3;

			private TaskAwaiter<Task> _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

			private TaskAwaiter<int> _003C_003Eu__3;

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
		private struct _003CPingInternalAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			public RegionPinger _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<IPHostEntry> _003C_003Eu__1;

			private UdpClient _003Cclient_003E5__2;

			private long _003CstartTicks_003E5__3;

			private TaskAwaiter<UdpReceiveResult> _003C_003Eu__2;

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

		private const int PortNumber = 3075;

		private const int UnknownLatencyValue = int.MaxValue;

		private const int NumSuccessBeforeFilteringOutBestAndWorst = 4;

		private static readonly byte[] _initialPrefix;

		private static readonly byte[] _subsequentPrefix;

		private readonly int _numTimeoutsForError;

		private readonly string _hostNameOrAddress;

		private readonly string _region;

		private readonly int _timeoutMs;

		private int _numTimeouts;

		private readonly List<int> latencyMeasures;

		public string Region => null;

		public RegionPinger(string hostNameOrAddress, string region, int timeoutMs, int numTimeoutsForError, int expectedPingsPerRegion)
		{
		}

		public bool IsAtTimeoutThreshold()
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CPingAsync_003Ed__15))]
		public Task<RegionPinger> PingAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private QosRegionResult GetResultAtTimeout()
		{
			return null;
		}

		public QosRegionResult GetResult()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CPingInternalAsync_003Ed__18))]
		private Task<int> PingInternalAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private bool VerifyResponseBuffer(byte[] buffer, long ticks)
		{
			return false;
		}
	}
}
