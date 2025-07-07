using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.SNS
{
	public class MailListPanel : MonoBehaviour
	{
		[SerializeField]
		private int _maxItemsPerPage;

		private int _pageIndex;

		[SerializeField]
		private TMP_Text _textPage;

		[SerializeField]
		private UIButton _btnPrevPage;

		[SerializeField]
		private UIButton _btnNextPage;

		[SerializeField]
		private MailEntry _mailEntryPrefab;

		[SerializeField]
		private Transform _listingRoot;

		private readonly List<MailItem> _mailItems;

		private readonly List<MailEntry> _mailEntries;

		public event Action<MailItem>? OnMailClicked
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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleNextPage()
		{
		}

		private void HandlePrevPage()
		{
		}

		public void UpdateMails(IReadOnlyList<MailItem> mails)
		{
		}

		private void UpdateMailsInternal(IReadOnlyList<MailItem> mails)
		{
		}

		public void SortMails()
		{
		}

		private void UpdateMailEntries()
		{
		}

		private void RemoveAllMails()
		{
		}

		public void UpdateMail(MailItem mailItem)
		{
		}

		private void HandleOnClicked(MailItem mailItem)
		{
		}
	}
}
