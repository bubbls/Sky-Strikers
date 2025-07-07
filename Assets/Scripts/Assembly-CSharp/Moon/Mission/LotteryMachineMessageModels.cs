using Chamber8.Framework.Messaging;

namespace Moon.Mission
{
	public static class LotteryMachineMessageModels
	{
		public static readonly ISubscriptionModel SearchLotteryMachine;

		public static readonly ISubscriptionModel ReportLotteryMachineInstalled;

		public static readonly ISubscriptionModel RequestDrawPrize;
	}
}
