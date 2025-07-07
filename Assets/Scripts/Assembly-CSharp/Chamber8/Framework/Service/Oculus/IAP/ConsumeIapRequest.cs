using Chamber8.Framework.Economy.API;
using Oculus.Platform;

namespace Chamber8.Framework.Service.Oculus.IAP
{
	public class ConsumeIapRequest : AbstractApiRequest<string>
	{
		public string SkuId { get; set; }

		public override void Execute()
		{
		}

		private void ConsumePurchaseCallback(Message message)
		{
		}
	}
}
