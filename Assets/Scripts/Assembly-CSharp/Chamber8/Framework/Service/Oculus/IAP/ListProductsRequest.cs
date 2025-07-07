using System.Collections.Generic;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Economy.Model;
using Oculus.Platform;
using Oculus.Platform.Models;

namespace Chamber8.Framework.Service.Oculus.IAP
{
	public class ListProductsRequest : AbstractApiRequest<List<Chamber8.Framework.Economy.Model.Product>>
	{
		public ProductList ProductList;

		public override void Execute()
		{
		}

		private void GetNextProductListPageCallback(Message<ProductList> message)
		{
		}
	}
}
