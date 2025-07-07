using Chamber8.Framework.Messaging;

namespace Chamber8.Framework.Economy
{
	public static class EconomyMessageSubsModels
	{
		public static readonly ISubscriptionModel IapCheckoutSucceeded;

		public static readonly ISubscriptionModel IapCheckoutFailed;

		public static readonly ISubscriptionModel IapConsumeIapSucceeded;

		public static readonly ISubscriptionModel IapConsumeIapFailed;

		public static readonly ISubscriptionModel PlayerInventoryRechargeSucceeded;

		public static readonly ISubscriptionModel PlayerInventoryRechargeFailed;

		public static readonly ISubscriptionModel PaymentTxSucceeded;

		public static readonly ISubscriptionModel PaymentTxFailed;
	}
}
