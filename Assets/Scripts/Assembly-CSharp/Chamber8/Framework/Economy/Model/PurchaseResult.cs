using System;

namespace Chamber8.Framework.Economy.Model
{
	public class PurchaseResult
	{
		private string _idempotencyId;

		public string DeveloperPayload { get; set; }

		public DateTime ExpirationTime { get; set; }

		public DateTime GrantTime { get; set; }

		public string Id { get; set; }

		public string ReportingId { get; set; }

		public string SkuId { get; set; }

		public string IdempotencyId => null;
	}
}
