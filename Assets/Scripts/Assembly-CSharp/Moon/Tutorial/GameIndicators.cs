using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Common;

namespace Moon.Tutorial
{
	public class GameIndicators : Singleton<GameIndicators>
	{
		public class SetGameTagResult
		{
			public List<string> Tags;

			public List<string> CompletedTags;
		}

		public class GetGameTagsResult
		{
			public List<string> Tags;

			public List<string> CompletedTags;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetGameTagsAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<GetGameTagsResult> _003C_003Et__builder;

			public GameIndicators _003C_003E4__this;

			public string tagListName;

			private TaskAwaiter<GetGameTagsResult> _003C_003Eu__1;

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
		private struct _003CSetGameTagAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<SetGameTagResult> _003C_003Et__builder;

			public string tagListName;

			public string tagName;

			private TaskAwaiter<SetGameTagResult?> _003C_003Eu__1;

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

		private const string TagNameKey = "TagName";

		private const string TagListNameKey = "TagListName";

		private readonly Dictionary<string, TaskCompletionSource<GetGameTagsResult?>> _getGameTagsTasks;

		[AsyncStateMachine(typeof(_003CSetGameTagAsync_003Ed__5))]
		public Task<SetGameTagResult> SetGameTagAsync(string tagListName, string tagName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetGameTagsAsync_003Ed__6))]
		public Task<GetGameTagsResult> GetGameTagsAsync(string tagListName)
		{
			return null;
		}
	}
}
