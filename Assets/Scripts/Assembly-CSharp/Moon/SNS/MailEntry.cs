using System;
using System.Runtime.CompilerServices;
using DP.Takeaway.Utils;
using Moon.Hub;
using SVGImporter;
using TMPro;
using UnityEngine;

namespace Moon.SNS
{
	public class MailEntry : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _textSubject;

		[SerializeField]
		private TMP_Text _textContent;

		[SerializeField]
		private TMP_Text _textAttachmentSummary;

		[SerializeField]
		private TMP_Text _textExpiration;

		[SerializeField]
		private ManualToggle _manualToggle;

		[SerializeField]
		private UIButton _button;

		[SerializeField]
		private SVGImage _mailIcon;

		[SerializeField]
		private SVGAsset? _svgMailRead;

		[SerializeField]
		private SVGAsset? _svgMailUnread;

		private MailItem? _mail;

		private readonly Cooldown _updateCd;

		public event Action<MailItem>? OnClicked
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

		private void HandleOnButtonPressed()
		{
		}

		private void Update()
		{
		}

		public void Set(MailItem mail)
		{
		}

		private void UpdateCurrentMail()
		{
		}

		public void Clear()
		{
		}

		public void UpdateMail(MailItem mailItem)
		{
		}
	}
}
