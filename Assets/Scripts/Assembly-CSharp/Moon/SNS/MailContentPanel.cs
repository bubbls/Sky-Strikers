using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.SNS
{
	public class MailContentPanel : MonoBehaviour
	{
		[SerializeField]
		private UIButton _btnClose;

		[SerializeField]
		private TMP_Text _textSubject;

		[SerializeField]
		private TMP_Text _textContent;

		[SerializeField]
		private AttachmentListPanel _attachmentListPanel;

		private MailItem? _mail;

		public MailItem? Mail => null;

		public event Action? RequestClosingPanel
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

		private void HandleClose()
		{
		}

		public void Set(MailItem mail)
		{
		}

		public void UpdateCurrentMail()
		{
		}

		public void UpdateMail(MailItem mailItem)
		{
		}
	}
}
