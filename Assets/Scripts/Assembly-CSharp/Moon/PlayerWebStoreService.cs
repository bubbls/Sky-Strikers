using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using Chamber8.Framework.Service.PlayFab;
using PlayFab;
using UnityEngine.Scripting;

namespace Moon
{
	public class PlayerWebStoreService : IInitializer
	{
		[Serializable]
		[Preserve]
		public class AddPurchasedItemsFromWebStoreRequestData
		{
			public List<string> PurchasedItemsIdListFromWebStore;

			public Dictionary<string, string> PurchasedProductsVerifyData;
		}

		[Serializable]
		[Preserve]
		public class AddPurchasedItemsFromWebStoreResponseData
		{
			public bool IsSucceed;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddPurchasedItemsFromWebStore_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<AddPurchasedItemsFromWebStoreResponseData> _003C_003Et__builder;

			public PlayerWebStoreService _003C_003E4__this;

			public List<string> itemsIdList;

			private TaskAwaiter<AddPurchasedItemsFromWebStoreResponseData> _003C_003Eu__1;

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

		private PlayFabCloudScriptInstanceAPI _cloudScriptInstanceAPI;

		private PlayFabAccountService _accountService;

		private const string PurchasedWebStoreItemsDataKey = "PurchasedWebStoreItemsData";

		public void Initialize()
		{
		}

		[AsyncStateMachine(typeof(_003CAddPurchasedItemsFromWebStore_003Ed__4))]
		public Task<AddPurchasedItemsFromWebStoreResponseData> AddPurchasedItemsFromWebStore(List<string> itemsIdList)
		{
			return null;
		}
	}
}
