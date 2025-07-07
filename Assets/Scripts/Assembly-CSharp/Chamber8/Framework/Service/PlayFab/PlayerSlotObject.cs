using System;

namespace Chamber8.Framework.Service.PlayFab
{
	public class PlayerSlotObject
	{
		public string Name { get; set; }

		public DateTime DueTime { get; set; }

		public string? ItemFriendlyId { get; set; }

		public string? StoreFriendlyId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
