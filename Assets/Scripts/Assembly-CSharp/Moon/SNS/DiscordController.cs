using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Common;

namespace Moon.SNS
{
	public class DiscordController : Singleton<DiscordController>
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckLinkAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public DiscordController _003C_003E4__this;

			private TaskAwaiter<HttpStatusCode> _003C_003Eu__1;

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
		private struct _003CPollLinkAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public DiscordController _003C_003E4__this;

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

		private const int PollInterval = 5000;

		private const string ScopeKey = "Scope";

		private const string CodeKey = "Code";

		private CancellationTokenSource? _pollCts;

		public DiscordGuildUserInfo? DiscordGuildUserInfo { get; private set; }

		public CodeWithExpiration? CodeWithExpiration { get; private set; }

		public event Action? OnDiscordLinkStatusChanged
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

		public event Action? OnLinkCodeGenerated
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

		public event Action? OnLinkCodeGenerateFailed
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

		public void GetAccountBindingInformation()
		{
		}

		public void CancelPolling()
		{
		}

		[AsyncStateMachine(typeof(_003CCheckLinkAsync_003Ed__23))]
		private Task CheckLinkAsync()
		{
			return null;
		}

		public void PollLink(DateTime tillTimeUtc)
		{
		}

		[AsyncStateMachine(typeof(_003CPollLinkAsync_003Ed__25))]
		private void PollLinkAsync()
		{
		}

		public void TryLink()
		{
		}

		private void RaiseLinkCodeGeneratedFailed()
		{
		}
	}
}
