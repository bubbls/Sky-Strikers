using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Account;
using Chamber8.Framework.Common;
using Oculus.Platform;
using Oculus.Platform.Models;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.Oculus
{
	[Preserve]
	public class OculusAccountService : AbstractOculusService, IAsyncAccountService, IAccountService, IInitializer
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public TaskCompletionSource<User> tcsLoggedIn;

			public TaskCompletionSource<string> tcsAccessToken;

			public TaskCompletionSource<AccountAgeCategory> tcsAgeGroup;

			internal void _003CRequestLoggedInUser_003Eb__0(Message<User> msg)
			{
			}

			internal void _003CRequestLoggedInUser_003Eb__1(Message<string> msg)
			{
			}

			internal void _003CRequestLoggedInUser_003Eb__2(Message<UserAccountAgeCategory> msg)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAccountAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IAccount> _003C_003Et__builder;

			public OculusAccountService _003C_003E4__this;

			private TaskAwaiter<OculusAccount> _003C_003Eu__1;

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
		private struct _003CRequestLoggedInUser_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

			public OculusAccountService _003C_003E4__this;

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

		private TaskCompletionSource<OculusAccount> _loggingInTask;

		private OculusAccount _account;

		public void Initialize()
		{
		}

		public IAccount GetCurrentAccount()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetAccountAsync_003Ed__4))]
		public Task<IAccount> GetAccountAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestLoggedInUser_003Ed__5))]
		private void RequestLoggedInUser()
		{
		}

		public void UpdateUserProof(Action onComplete, Action onError)
		{
		}
	}
}
