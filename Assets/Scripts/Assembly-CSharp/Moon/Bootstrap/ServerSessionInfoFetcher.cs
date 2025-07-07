using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Moon.Bootstrap
{
	public static class ServerSessionInfoFetcher
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public TaskCompletionSource<bool> tcs;

			public ServerSessionInfo sessionInfo;

			internal void _003CFetchServerSessionInfoFromCurSessionId_003Eb__0()
			{
			}

			internal void _003CFetchServerSessionInfoFromCurSessionId_003Eb__1(ServerSessionInfo info)
			{
			}

			internal void _003CFetchServerSessionInfoFromCurSessionId_003Eb__2()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public ServerSessionInfo sessionInfo;

			public HttpStatusCode statusCode;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass4_1
		{
			public TaskCompletionSource<bool> tcs;

			public _003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals1;

			internal void _003CFetchRequestedServerSessionInfo_003Eb__0()
			{
			}

			internal void _003CFetchRequestedServerSessionInfo_003Eb__1(ServerSessionInfo info)
			{
			}

			internal void _003CFetchRequestedServerSessionInfo_003Eb__2(HttpStatusCode code)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFetchRequestedServerSessionInfo_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public Action<HttpStatusCode> onFail;

			public string serverId;

			private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass4_1 _003C_003E8__2;

			public Action<ServerSessionInfo> onSuccess;

			private ServerSessionService _003CserverSessionService_003E5__2;

			private int _003Cattempts_003E5__3;

			private CancellationTokenRegistration _003Cregistry_003E5__4;

			private object _003C_003E7__wrap4;

			private int _003C_003E7__wrap5;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<bool> _003C_003Eu__2;

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
		private struct _003CFetchServerSessionInfoFromCurSessionId_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public Action onFail;

			public CancellationToken cancellationToken;

			public int delay;

			private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

			public Action<ServerSessionInfo> onSuccess;

			private string _003CfieldType_003E5__2;

			private string _003CsessionId_003E5__3;

			private CancellationTokenRegistration _003Cregistry_003E5__4;

			private ServerSessionService _003CserverSessionService_003E5__5;

			private TaskAwaiter _003C_003Eu__1;

			private object _003C_003E7__wrap5;

			private int _003C_003E7__wrap6;

			private bool _003C_003E7__wrap7;

			private TaskAwaiter<bool> _003C_003Eu__2;

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

		private const int FetchRequestedServerSessionInfoAttempts = 18;

		private const int FetchRequestedServerSessionInfoInterval = 3500;

		public static void FetchServerSessionInfoFromCode(string fieldType, string code, Action<ServerSessionInfo> onSuccess, Action onFail)
		{
		}

		[AsyncStateMachine(typeof(_003CFetchServerSessionInfoFromCurSessionId_003Ed__3))]
		public static Task<bool> FetchServerSessionInfoFromCurSessionId(int delay, Action<ServerSessionInfo> onSuccess, Action onFail, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CFetchRequestedServerSessionInfo_003Ed__4))]
		public static Task FetchRequestedServerSessionInfo(string serverId, Action<ServerSessionInfo> onSuccess, Action<HttpStatusCode> onFail, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
