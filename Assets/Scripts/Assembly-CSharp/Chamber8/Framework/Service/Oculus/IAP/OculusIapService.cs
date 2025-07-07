using System;
using System.Collections.Generic;
using Chamber8.Framework.Common;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Economy.IAP;
using Chamber8.Framework.Economy.Model;
using JetBrains.Annotations;
using Moon.Framework.Service.PlayFab.PlayerInventory;
using Oculus.Platform.Models;

namespace Chamber8.Framework.Service.Oculus.IAP
{
	[UsedImplicitly]
	public class OculusIapService : AbstractOculusService, IIapService, IInitializer
	{
		private class OculusIapError
		{
			public string category;

			public int code;

			public string message;
		}

		public void Initialize()
		{
		}

		public void ListAllProducts(Action<List<Chamber8.Framework.Economy.Model.Product>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		private static void ListAllProductsInternal(Action<List<global::Oculus.Platform.Models.Product>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		private static void NextPage(List<global::Oculus.Platform.Models.Product> products, ProductList productList, Action<List<global::Oculus.Platform.Models.Product>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		public void ListProductBySkuId(string[] skuIds, Action<List<Chamber8.Framework.Economy.Model.Product>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		public void GetPurchasedProducts(Action<List<PurchaseResult>> onSuccess, Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		private void Consume(RechargeMessagePayload payload)
		{
		}

		private void TryExchangeUnconsumedIap2Igc(Action<Chamber8.Framework.Economy.API.Error> onError)
		{
		}

		public void TryExchangeUnconsumedIap2Igc(PurchaseResult purchaseResult)
		{
		}

		private void Consume_OnError(RechargeMessagePayload payload, Chamber8.Framework.Economy.API.Error err)
		{
		}

		private static void Consume_OnSuccess(RechargeMessagePayload payload)
		{
		}

		public void LaunchCheckoutFlow(string skuId)
		{
		}

		private static void LaunchCheckoutFlow_OnError(string skuId, Chamber8.Framework.Economy.API.Error obj)
		{
		}

		private static void LaunchCheckoutFlow_OnSuccess(PurchaseResult obj)
		{
		}
	}
}
