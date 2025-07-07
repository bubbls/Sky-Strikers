using System.Collections.Generic;
using UnityEngine;

namespace Moon.SNS
{
	public class AttachmentListPanel : MonoBehaviour
	{
		[SerializeField]
		private AttachmentEntry _attachmentEntryPrefab;

		[SerializeField]
		private Transform _attachmentListRoot;

		public void SetAttachments(List<ItemReference>? attachments, bool claimed)
		{
		}

		private void RemoveAllAttachments()
		{
		}
	}
}
