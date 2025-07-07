using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using PlayFab;
using PlayFab.ServerModels;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab.PlayerData
{
	[Preserve]
	public class PlayFabPlayerDataServer : IInitializer
	{
		public struct UpdateUserDataResult
		{
			public bool Success;

			public PlayFabError Error;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetUserDataInternal_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Dictionary<string, UserDataRecord>> _003C_003Et__builder;

			public string key;

			public string[] otherKeys;

			public PlayFabPlayerDataServer _003C_003E4__this;

			public string playFabId;

			private List<string> _003Ckeys_003E5__2;

			private TaskAwaiter<GetUserDataResult?> _003C_003Eu__1;

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
		private struct _003CSetUserDataInternalAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UpdateUserDataResult?> _003C_003Et__builder;

			public PlayFabPlayerDataServer _003C_003E4__this;

			public string playFabId;

			public Dictionary<string, string> data;

			private TaskAwaiter<UpdateUserDataResult?> _003C_003Eu__1;

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

		private PlayFabServerInstanceAPI _serverApi;

		public void Initialize()
		{
		}

		[AsyncStateMachine(typeof(_003CGetUserDataInternal_003Ed__3))]
		public Task<Dictionary<string, UserDataRecord>> GetUserDataInternal(string playFabId, string key, params string[] otherKeys)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSetUserDataInternalAsync_003Ed__4))]
		public Task<UpdateUserDataResult?> SetUserDataInternalAsync(string playFabId, Dictionary<string, string> data)
		{
			return null;
		}

		public void SetUserDataInternal(string playFabId, string key, string val)
		{
		}

		public void SetUserDataInternal(string playFabId, Dictionary<string, string> data)
		{
		}
	}
}
