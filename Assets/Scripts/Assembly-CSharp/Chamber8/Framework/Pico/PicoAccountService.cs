using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Account;
using Chamber8.Framework.Common;
using Pico.Platform;
using Pico.Platform.Models;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Pico
{
	[Preserve]
	public class PicoAccountService : AbstractPicoService, IAsyncAccountService, IAccountService, IInitializer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAccountAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IAccount> _003C_003Et__builder;

			public PicoAccountService _003C_003E4__this;

			private TaskAwaiter<PicoAccount> _003C_003Eu__1;

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
		private struct _003CRequestLoggedInUserAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PicoAccount> _003C_003Et__builder;

			private System.Threading.Tasks.Task<Message<User>> _003CtaskGetLoggedInUser_003E5__2;

			private System.Threading.Tasks.Task<Message<string>> _003CtaskGetAccessToken_003E5__3;

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

		private PicoAccount _account;

		private System.Threading.Tasks.Task<PicoAccount> _loggingInTask;

		public void Initialize()
		{
		}

		public IAccount GetCurrentAccount()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetAccountAsync_003Ed__4))]
		public System.Threading.Tasks.Task<IAccount> GetAccountAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRequestLoggedInUserAsync_003Ed__5))]
		private static System.Threading.Tasks.Task<PicoAccount> RequestLoggedInUserAsync()
		{
			return null;
		}
	}
}
