using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab.PlayerData
{
	[Preserve]
	public class PlayFabPlayerDataClient : IInitializer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPublicStringFromAsync_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Dictionary<string, UserDataRecord>> _003C_003Et__builder;

			public string key;

			public string[] otherKeys;

			public PlayFabPlayerDataClient _003C_003E4__this;

			public string playFabId;

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

		private PlayFabClientInstanceAPI _client;

		private readonly Dictionary<string, string> _cachedData;

		private readonly Dictionary<string, string> _toSet;

		private readonly Dictionary<string, string> _toSetPublic;

		private readonly HashSet<string> _keysToRemove;

		public void Initialize()
		{
		}

		public void SetStringPublic(string key, string value)
		{
		}

		public void SetString(string key, string value)
		{
		}

		public void Remove(string key)
		{
		}

		public void RemovePublic(string key)
		{
		}

		public void Flush()
		{
		}

		public void Cache(Dictionary<string, UserDataRecord> data)
		{
		}

		public bool TryGet(string key, out string value)
		{
			value = null;
			return false;
		}

		[AsyncStateMachine(typeof(_003CGetPublicStringFromAsync_003Ed__13))]
		public Task<Dictionary<string, UserDataRecord>> GetPublicStringFromAsync(string playFabId, string key, params string[] otherKeys)
		{
			return null;
		}
	}
}
