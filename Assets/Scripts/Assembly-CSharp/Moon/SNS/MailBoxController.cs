using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Common;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Service.PlayFab.PlayerInventory;

namespace Moon.SNS
{
	public class MailBoxController : Singleton<MailBoxController>
	{
		private const string MailStackIdKey = "MailStackId";

		private readonly List<MailItem> _mails;

		private int _numUnread;

		public IReadOnlyList<MailItem> Mails => null;

		public int NumRead => 0;

		public event Action? OnMailReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void ListAllMails()
		{
		}

		private void RaiseMailListed(List<PlayFabPlayerInventoryItem> items)
		{
		}

		private void CheckUnreadMails()
		{
		}

		private void HandleMailBoxListed(List<PlayFabPlayerInventoryItem> mailItems)
		{
		}

		public void ClaimMail(MailItem mailItem, Action<ClaimMailResult?>? onSuccess, Action? onError)
		{
		}

		private void HandleMailBoxListFailed(Error obj)
		{
		}
	}
}
