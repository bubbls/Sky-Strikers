namespace Chamber8.Framework.Service.Oculus.IAP
{
	public class VerifyOwnershipRequest : OculusS2SRequest<VerifyOwnershipResp>
	{
		public string SkuId;

		public override void Execute()
		{
		}
	}
}
