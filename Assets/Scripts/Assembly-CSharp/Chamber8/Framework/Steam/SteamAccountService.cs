using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Account;
using Chamber8.Framework.Common;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Steam
{
	[Preserve]
	public class SteamAccountService : AbstractSteamService, IAsyncAccountService, IAccountService, IInitializer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAccountAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IAccount> _003C_003Et__builder;

			public SteamAccountService _003C_003E4__this;

			private TaskAwaiter<SteamAccount> _003C_003Eu__1;

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
		private struct _003CRequestLoggedInUser_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SteamAccountService _003C_003E4__this;

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

		private TaskCompletionSource<SteamAccount> _loggingInTask;

		private SteamAccount _account;

		public void Initialize()
		{
		}

		[AsyncStateMachine(typeof(_003CRequestLoggedInUser_003Ed__3))]
		private void RequestLoggedInUser()
		{
		}

		public IAccount GetCurrentAccount()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetAccountAsync_003Ed__5))]
		public Task<IAccount> GetAccountAsync()
		{
			return null;
		}
	}
}
