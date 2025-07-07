using System;

namespace Moon.Shop.Charge
{
	[Serializable]
	public enum ShopChargeScreenStatus : byte
	{
		None = 0,
		NetworkError = 1,
		Press = 2,
		Loading = 3,
		PaymentError = 4,
		Charging = 5,
		IapReceiptConsumeFailed = 6,
		IgcExchangeFailed = 7
	}
}
