using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Account;
using Chamber8.Framework.Common;
using Chamber8.Framework.Platform;
using Chamber8.Framework.Service.Oculus;
using PlayFab;
using PlayFab.AuthenticationModels;
using PlayFab.ClientModels;
using PlayFab.ServerModels;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	internal class PlayFabAccountService : IPlayFabAccountService, IInitializer
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass16_0
		{
			public DateTime expiration;

			public TaskCompletionSource<PlayFabError?> tcs;

			internal void _003CAuthorizeGameServerAsync_003Eb__0(AuthenticateCustomIdResult result)
			{
			}

			internal void _003CAuthorizeGameServerAsync_003Eb__1(PlayFabError error)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass17_0
		{
			public DateTime expiration;

			public TaskCompletionSource<PlayFabError?> tcs;

			internal void _003CAuthorizeAsTitleAsync_003Eb__0(GetEntityTokenResponse response)
			{
			}

			internal void _003CAuthorizeAsTitleAsync_003Eb__1(PlayFabError error)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			public DateTime serverExp;

			public IAccount account;

			public TaskCompletionSource<LinkedPlayFabAccount?> tcsLogin;

			internal void _003CAuthorizeAsTitleAndLoginWithServerCustomIdAsync_003Eb__0(ServerLoginResult result)
			{
			}

			internal void _003CAuthorizeAsTitleAndLoginWithServerCustomIdAsync_003Eb__1(PlayFabError _)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass27_0
		{
			public IAccount platformAccount;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass27_1
		{
			public TaskCompletionSource<(LinkedPlayFabAccount?, PlayFabError?)> tcs;

			public _003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals1;

			internal void _003CLoginWithCustomIdAsync_003Eb__0(LoginResult result)
			{
			}

			internal void _003CLoginWithCustomIdAsync_003Eb__1(PlayFabError error)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAuthorizeAsTitleAndLoginWithServerCustomIdAsync_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LinkedPlayFabAccount> _003C_003Et__builder;

			public IAccount account;

			public PlayFabAccountService _003C_003E4__this;

			private _003C_003Ec__DisplayClass18_0 _003C_003E8__1;

			private DateTime _003CtitleExp_003E5__2;

			private TaskAwaiter<(bool, DateTime)> _003C_003Eu__1;

			private TaskAwaiter<DateTime> _003C_003Eu__2;

			private TaskAwaiter<LinkedPlayFabAccount?> _003C_003Eu__3;

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
		private struct _003CAuthorizeAsTitleAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(bool, DateTime)> _003C_003Et__builder;

			public PlayFabAccountService _003C_003E4__this;

			private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

			private TaskAwaiter<PlayFabError?> _003C_003Eu__1;

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
		private struct _003CAuthorizeGameServerAsync_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<DateTime> _003C_003Et__builder;

			public PlayFabAccountService _003C_003E4__this;

			private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

			private TaskAwaiter<PlayFabError?> _003C_003Eu__1;

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
		private struct _003CAuthorizeLocalAccountAsGameServerAndWatchExpirationAsync_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayFabAccountService _003C_003E4__this;

			public CancellationTokenSource cancellationTokenSource;

			private DateTime _003CtitleExp_003E5__2;

			private TaskAwaiter<(bool, DateTime)> _003C_003Eu__1;

			private TaskAwaiter<DateTime> _003C_003Eu__2;

			private TaskAwaiter<bool> _003C_003Eu__3;

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
		private struct _003CGetPhotonAuthToken_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public PlayFabAccountService _003C_003E4__this;

			public bool forceRefresh;

			public CancellationToken cancellationToken;

			public string appId;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private GetPhotonAuthenticationTokenResult _003Cresult_003E5__3;

			private TaskAwaiter<GetPhotonAuthenticationTokenResult?> _003C_003Eu__1;

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
		private struct _003CLinkWithSteamAccountAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LinkedPlayFabAccount> _003C_003Et__builder;

			public IAccount platformAccount;

			public PlayFabAccountService _003C_003E4__this;

			private TaskAwaiter<(LinkedPlayFabAccount?, PlayFabError?)> _003C_003Eu__1;

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
		private struct _003CLoginAsync_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LinkedPlayFabAccount> _003C_003Et__builder;

			public IAccount accountToLink;

			public PlayFabAccountService _003C_003E4__this;

			private TaskAwaiter<LinkedPlayFabAccount?> _003C_003Eu__1;

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
		private struct _003CLoginWithCustomIdAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LinkedPlayFabAccount> _003C_003Et__builder;

			public IAccount platformAccount;

			private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

			public Func<IAccount, string> getUniqueIdFromPlatformAccount;

			public bool createAccount;

			public PlayFabAccountService _003C_003E4__this;

			private _003C_003Ec__DisplayClass27_1 _003C_003E8__2;

			private int _003CretryCount_003E5__2;

			private bool _003CprocessEnds_003E5__3;

			private string _003CcustomId_003E5__4;

			private TaskAwaiter<(LinkedPlayFabAccount?, PlayFabError?)> _003C_003Eu__1;

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
		private struct _003CRebindOculusAccountAsync_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<LinkedPlayFabAccount> _003C_003Et__builder;

			public IAccount accountToLink;

			public PlayFabAccountService _003C_003E4__this;

			private OculusAccount _003CoculusAccount_003E5__2;

			private LinkedPlayFabAccount _003ClinkedAccount_003E5__3;

			private TaskAwaiter<LinkedPlayFabAccount?> _003C_003Eu__1;

			private TaskAwaiter _003C_003Eu__2;

			private TaskAwaiter<PlayFabError?> _003C_003Eu__3;

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
		private struct _003CServerAuthorizeAsTitleAccountAndWatchExpirationAsync_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TaskCompletionSource<LinkedPlayFabAccount> firstLoginTaskCompletionSource;

			public PlayFabAccountService _003C_003E4__this;

			public IAccount account;

			public CancellationTokenSource cancellationTokenSource;

			private TaskCompletionSource<LinkedPlayFabAccount> _003CfirstTcs_003E5__2;

			private TaskAwaiter<LinkedPlayFabAccount?> _003C_003Eu__1;

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
		private struct _003CWaitForExpiration_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public DateTime expiration;

			public CancellationTokenSource cancellationTokenSource;

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
		private struct _003CWaitForMainAccountLoggedInThenLink_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public Action onError;

			public PlayFabAccountService _003C_003E4__this;

			public Action onComplete;

			private TaskAwaiter<IAccount> _003C_003Eu__1;

			private TaskAwaiter<LinkedPlayFabAccount?> _003C_003Eu__2;

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

		private const int LoginRetryDuration = 2;

		public const string GameServerCustomId = "game_server.e31b11b6-2677-4876-b387-009fe2b79166";

		private const int RetryCountForConnectionError = 3;

		private static readonly Regex _userNameRegex;

		private PlayFabClientInstanceAPI _client;

		private PlayFabAuthenticationInstanceAPI _serverAuthentication;

		private LinkedPlayFabAccount? _linkedPlayFabAccount;

		private CancellationTokenSource? _serverTokenTaskCancellationTokenSource;

		public void Initialize()
		{
		}

		public LinkedPlayFabAccount? GetLoggedInAccount()
		{
			return null;
		}

		public void Login(Action onComplete, Action onError)
		{
		}

		[AsyncStateMachine(typeof(_003CWaitForMainAccountLoggedInThenLink_003Ed__11))]
		private void WaitForMainAccountLoggedInThenLink(Action onComplete, Action onError)
		{
		}

		public static void GetPlayerDisplayName(string playFabDisplayName, out string userName, out int suffixNumber)
		{
			userName = null;
			suffixNumber = default(int);
		}

		private void UpdatePlayerTitleDisplayName()
		{
		}

		private void UpdatePlayerTitleDisplayName(string displayName)
		{
		}

		private static string ClampDisplayName(string displayName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthorizeGameServerAsync_003Ed__16))]
		private Task<DateTime> AuthorizeGameServerAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthorizeAsTitleAsync_003Ed__17))]
		private Task<(bool, DateTime)> AuthorizeAsTitleAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAuthorizeAsTitleAndLoginWithServerCustomIdAsync_003Ed__18))]
		private Task<LinkedPlayFabAccount> AuthorizeAsTitleAndLoginWithServerCustomIdAsync(IAccount account)
		{
			return null;
		}

		private void HandleApplicationQuitting()
		{
		}

		private void ServerAuthorizeAsTitleAccountAndWatchExpirationAsync(TaskCompletionSource<LinkedPlayFabAccount> firstLoginTaskCompletionSource, IAccount account)
		{
		}

		private void AuthorizeLocalAccountAsGameServerAndWatchExpirationAsync()
		{
		}

		[AsyncStateMachine(typeof(_003CAuthorizeLocalAccountAsGameServerAndWatchExpirationAsync_003Ed__22))]
		private void AuthorizeLocalAccountAsGameServerAndWatchExpirationAsync(CancellationTokenSource cancellationTokenSource)
		{
		}

		[AsyncStateMachine(typeof(_003CWaitForExpiration_003Ed__23))]
		private static Task<bool> WaitForExpiration(DateTime expiration, CancellationTokenSource cancellationTokenSource)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CServerAuthorizeAsTitleAccountAndWatchExpirationAsync_003Ed__24))]
		private void ServerAuthorizeAsTitleAccountAndWatchExpirationAsync(CancellationTokenSource cancellationTokenSource, TaskCompletionSource<LinkedPlayFabAccount> firstLoginTaskCompletionSource, IAccount account)
		{
		}

		[AsyncStateMachine(typeof(_003CLinkWithSteamAccountAsync_003Ed__25))]
		private Task<LinkedPlayFabAccount> LinkWithSteamAccountAsync(IAccount platformAccount)
		{
			return null;
		}

		private static global::PlayFab.ClientModels.GetPlayerCombinedInfoRequestParams MakeInfoRequestParameters()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoginWithCustomIdAsync_003Ed__27))]
		private Task<LinkedPlayFabAccount> LoginWithCustomIdAsync(IAccount platformAccount, Func<IAccount, string> getUniqueIdFromPlatformAccount, bool createAccount)
		{
			return null;
		}

		private static string MakeCustomId(Chamber8.Framework.Platform.Platform platform, string uniqueId)
		{
			return null;
		}

		private static string GetUniqueIdFromPlatformAccount(IAccount platformAccount)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRebindOculusAccountAsync_003Ed__30))]
		private Task<LinkedPlayFabAccount> RebindOculusAccountAsync(IAccount accountToLink)
		{
			return null;
		}

		private static string GetOculusUserID(IAccount account)
		{
			return null;
		}

		private static string GetOculusID(IAccount account)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoginAsync_003Ed__33))]
		private Task<LinkedPlayFabAccount> LoginAsync(IAccount accountToLink)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetPhotonAuthToken_003Ed__34))]
		public Task<string> GetPhotonAuthToken(CancellationToken cancellationToken, string appId, bool forceRefresh = false)
		{
			return null;
		}
	}
}
