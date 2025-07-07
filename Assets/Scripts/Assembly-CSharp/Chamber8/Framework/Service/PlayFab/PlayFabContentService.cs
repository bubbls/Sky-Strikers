using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	internal class PlayFabContentService : IInitializer
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public string title;

			internal bool _003CGetItem_003Eb__0(TitleNewsItem i)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetDevSettings_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IDictionary<string, object>> _003C_003Et__builder;

			public PlayFabContentService _003C_003E4__this;

			private TaskAwaiter<GetTitleNewsResult> _003C_003Eu__1;

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
		private struct _003CGetItem_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<TitleNewsItem> _003C_003Et__builder;

			public string title;

			public PlayFabContentService _003C_003E4__this;

			public CancellationToken cancellationToken;

			private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

			private TaskAwaiter<GetTitleNewsResult> _003C_003Eu__1;

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
		private struct _003CGetTitleNewsInternal_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetTitleNewsResult> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public int count;

			public PlayFabContentService _003C_003E4__this;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private GetTitleNewsResult _003Cresult_003E5__3;

			private TaskAwaiter<GetTitleNewsResult> _003C_003Eu__1;

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
		private struct _003CGetVersion_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<string> _003C_003Et__builder;

			public PlayFabContentService _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter<GetTitleNewsResult> _003C_003Eu__1;

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

		private const string TitleNewsVersionKey = "--version--";

		private const string DevKey = "--dev--";

		private PlayFabClientInstanceAPI _client;

		public void Initialize()
		{
		}

		[AsyncStateMachine(typeof(_003CGetVersion_003Ed__4))]
		public Task<string> GetVersion(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetDevSettings_003Ed__5))]
		public Task<IDictionary<string, object>> GetDevSettings()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetItem_003Ed__6))]
		public Task<TitleNewsItem> GetItem(string title, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetTitleNewsInternal_003Ed__7))]
		private Task<GetTitleNewsResult> GetTitleNewsInternal(CancellationToken cancellationToken, int count = 10)
		{
			return null;
		}
	}
}
