using System;
using System.Collections.Generic;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Economy.Model;

namespace Chamber8.Framework.Economy.IAP
{
	public interface IIapService
	{
		void ListProductBySkuId(string[] skuIds, Action<List<Product>> onSuccess, Action<Error> onError);

		void ListAllProducts(Action<List<Product>> onSuccess, Action<Error> onError);

		void GetPurchasedProducts(Action<List<PurchaseResult>> onSuccess, Action<Error> onError);

		void LaunchCheckoutFlow(string skuId);

		void TryExchangeUnconsumedIap2Igc(PurchaseResult purchaseResult);
	}
}
