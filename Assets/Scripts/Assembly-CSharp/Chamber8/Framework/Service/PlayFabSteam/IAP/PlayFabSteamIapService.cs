using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using Chamber8.Framework.Core;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Economy.IAP;
using Chamber8.Framework.Economy.Model;
using Chamber8.Framework.Messaging;
using PlayFab;
using Steamworks;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFabSteam.IAP
{
	[Preserve]
	internal class PlayFabSteamIapService : IConditionalCreation, IIapService, IInitializer
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public string currency;

			public PlayFabSteamIapService _003C_003E4__this;

			internal void _003CListAllProducesAsync_003Eb__0(SteamInventoryRequestPricesResult_t result, bool ioFailure)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetPurchasedProductsAsync_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SteamInventoryResult_t mHandle;

			public Action<List<PurchaseResult>> onSuccess;

			public Action<Error> onError;

			private int _003CretryTimes_003E5__2;

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
		private struct _003CListAllProducesAsync_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayFabSteamIapService _003C_003E4__this;

			public Action<Error> onError;

			private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

			public Action<List<Product>> onSuccess;

			private TaskAwaiter<int> _003C_003Eu__1;

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

		private const int DefaultItemListingCount = 50;

		private PlayFabClientInstanceAPI _client;

		private PlayFabEconomyInstanceAPI _economy;

		private IMessageProducer _messageProducer;

		private static readonly Error _errorNotLoggedIn;

		private static readonly Error _errorInternalError;

		private TaskCompletionSource<int> _requestPricesTask;

		private CallResult<SteamInventoryRequestPricesResult_t> _crRequestPrices;

		private CallResult<SteamInventoryStartPurchaseResult_t> _crPurchaseResults;

		private Callback<SteamInventoryResultReady_t> _cbResultReady;

		private static Tuple<Action<List<PurchaseResult>>, Action<Error>> GetPurchasedProductsActions;

		public bool CreateOnCondition()
		{
			return false;
		}

		public void Initialize()
		{
		}

		public void ListProductBySkuId(string[] skuIds, Action<List<Product>> onSuccess, Action<Error> onError)
		{
		}

		[AsyncStateMachine(typeof(_003CListAllProducesAsync_003Ed__14))]
		private void ListAllProducesAsync(Action<List<Product>> onSuccess, Action<Error> onError)
		{
		}

		public void ListAllProducts(Action<List<Product>> onSuccess, Action<Error> onError)
		{
		}

		public void GetPurchasedProducts(Action<List<PurchaseResult>> onSuccess, Action<Error> onError)
		{
		}

		[AsyncStateMachine(typeof(_003CGetPurchasedProductsAsync_003Ed__17))]
		private void GetPurchasedProductsAsync(SteamInventoryResult_t mHandle, Action<List<PurchaseResult>> onSuccess, Action<Error> onError)
		{
		}

		public void LaunchCheckoutFlow(string skuId)
		{
		}

		private void OnInventoryResultReady(SteamInventoryResultReady_t param)
		{
		}

		private void OnInventoryStartPurchaseResult(SteamInventoryStartPurchaseResult_t param, bool biofailure)
		{
		}

		private void RedeemInventoryItem()
		{
		}

		public void TryExchangeUnconsumedIap2Igc(PurchaseResult purchaseResult)
		{
		}

		public void TryConsumePurchasedWebStoreItem(PurchaseResult purchaseResult)
		{
		}
	}
}
