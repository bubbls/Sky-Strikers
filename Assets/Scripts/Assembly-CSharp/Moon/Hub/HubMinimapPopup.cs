using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Moon.Hub
{
	public class HubMinimapPopup : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _tmpText;

		[SerializeField]
		private float _repositionScaleDuration;

		[SerializeField]
		private float _scaleUpDuration;

		[SerializeField]
		private float _scaleDownDuration;

		[SerializeField]
		private Transform _defaultParent;

		private Sequence _sequence;

		private void OnDestroy()
		{
		}

		public void Place(Transform parent, string text)
		{
		}

		public void Hide()
		{
		}

		public void HideInstantly()
		{
		}
	}
}
