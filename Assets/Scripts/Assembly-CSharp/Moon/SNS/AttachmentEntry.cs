using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.SNS
{
	public class AttachmentEntry : MonoBehaviour
	{
		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TMP_Text _textAmount;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private GameObject _tickIcon;

		public void Set(ItemReference attachment)
		{
		}

		public void SetClaimed(bool claimed)
		{
		}
	}
}
