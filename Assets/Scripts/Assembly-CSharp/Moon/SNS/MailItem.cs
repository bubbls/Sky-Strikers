using System;
using System.Collections.Generic;
using Chamber8.Framework.Service.PlayFab.PlayerInventory;
using PlayFab.Json;

namespace Moon.SNS
{
	public class MailItem
	{
		private readonly PlayFabPlayerInventoryItem _item;

		private const int OneYearExpirationDaysThreshold = 365;

		public string MailStackId => null;

		public JsonObject? DisplayProperties => null;

		public bool IsClaimed()
		{
			return false;
		}

		private MailItem(PlayFabPlayerInventoryItem item)
		{
		}

		public static MailItem CreateFrom(PlayFabPlayerInventoryItem item)
		{
			return null;
		}

		public string GetSubject()
		{
			return null;
		}

		public string GetContent()
		{
			return null;
		}

		public string GetAttachmentId()
		{
			return null;
		}

		public List<ItemReference> GetAttachments()
		{
			return null;
		}

		public string GetAttachmentSummary()
		{
			return null;
		}

		public string GetExpirationCountdown()
		{
			return null;
		}

		public bool HasUnclaimedAttachment()
		{
			return false;
		}

		public void LocallyMarkClaimed()
		{
		}

		public void LocallySetExpirationTime(DateTime? expirationTime)
		{
		}

		public DateTime GetReceivedTime()
		{
			return default(DateTime);
		}
	}
}
