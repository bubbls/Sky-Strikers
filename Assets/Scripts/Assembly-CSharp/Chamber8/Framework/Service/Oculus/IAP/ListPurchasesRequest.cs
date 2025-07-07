using System.Collections.Generic;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Economy.Model;
using Oculus.Platform;
using Oculus.Platform.Models;

namespace Chamber8.Framework.Service.Oculus.IAP
{
	public class ListPurchasesRequest : AbstractApiRequest<List<PurchaseResult>>
	{
		public override void Execute()
		{
		}

		private void GetViewerPurchasesCallback(Message<PurchaseList> message)
		{
		}
	}
}
