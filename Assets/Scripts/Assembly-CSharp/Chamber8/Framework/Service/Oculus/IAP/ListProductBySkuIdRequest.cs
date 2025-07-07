using System.Collections.Generic;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Economy.Model;
using Oculus.Platform;
using Oculus.Platform.Models;

namespace Chamber8.Framework.Service.Oculus.IAP
{
	public class ListProductBySkuIdRequest : AbstractApiRequest<List<Chamber8.Framework.Economy.Model.Product>>
	{
		public string[] SkuIds { get; set; }

		public override void Execute()
		{
		}

		private void GetProductsBySkuCallback(Message<ProductList> message)
		{
		}
	}
}
