using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Economy.IAP;
using Chamber8.Framework.Economy.Model;
using Chamber8.Framework.Messaging;
using Moon.Framework.Service.PlayFab.PlayerInventory;
using Pico.Platform.Models;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Pico
{
	[Preserve]
	public class PicoIapService : AbstractPicoService, IIapService, IInitializer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckTimeout_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TaskCompletionSource<string> tcs;

			public TimeSpan timeSpan;

			public string skuId;

			public PicoIapService _003C_003E4__this;

			private TaskAwaiter<string> _003C_003Eu__1;

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

		private bool _isCheckoutTimeout;

		public void Initialize()
		{
		}

		public void ListProductBySkuId(string[] skuIds, Action<List<Chamber8.Framework.Economy.Model.Product>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		public void ListAllProducts(Action<List<Chamber8.Framework.Economy.Model.Product>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		private static void ListAllProductsInternal(Action<List<global::Pico.Platform.Models.Product>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		private static void NextPage(List<global::Pico.Platform.Models.Product> products, ProductList productList, Action<List<global::Pico.Platform.Models.Product>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		public void GetPurchasedProducts(Action<List<PurchaseResult>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		public void Consume(string skuId)
		{
		}

		public void LaunchCheckoutFlow(string skuId)
		{
		}

		[AsyncStateMachine(typeof(_003CCheckTimeout_003Ed__9))]
		private void CheckTimeout(TaskCompletionSource<string> tcs, TimeSpan timeSpan, string skuId)
		{
		}

		private void LaunchCheckoutFlow_OnError(string skuId, Chamber8.Framework.Economy.API.Error obj)
		{
		}

		private void LaunchCheckoutFlow_OnSuccess(PurchaseResult obj)
		{
		}

		private void TryExchangeUnconsumedIap2Igc(Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		public void TryExchangeUnconsumedIap2Igc(PurchaseResult purchaseResult)
		{
		}

		public void TryConsumePurchasedWebStoreItem(PurchaseResult purchaseResult)
		{
		}

		private void SubscribePlayerInventoryMessage()
		{
		}

		private int OnPlayerInventoryRechargeSucceeded(IMessage<RechargeMessagePayload> message)
		{
			return 0;
		}

		private Chamber8.Framework.Economy.Model.Product ConvertToProduct(global::Pico.Platform.Models.Product arg)
		{
			return null;
		}

		private PurchaseResult ConvertPurchaseResult(Purchase purchase)
		{
			return null;
		}
	}
}
