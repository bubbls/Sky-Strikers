namespace Moon.Economy
{
	public enum PlayerEconomyError
	{
		None = 0,
		NotInitialized = 400,
		Operating = 401,
		Duplicated = 402,
		InvalidOperation = 403,
		NotFound = 404,
		InsufficientFunds = 405,
		InternalError = 500,
		CheckoutFailed = 501,
		RechargeFailed = 502,
		IapReceiptConsumeFailed = 503,
		RecoverIgcExchangeFailed = 504
	}
}
