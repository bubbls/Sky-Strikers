using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Moon.Backpack
{
	public class BackpackItemSlotVisual : MonoBehaviour
	{
		[SerializeField]
		private Transform _visualSpawnPoint;

		[SerializeField]
		private TMP_Text _amountText;

		[SerializeField]
		private GameObject _indicator;

		private GrabbableBackpackItemVisual _itemVisual;

		private Tween _squeezeTween;

		public string RenderingItemFriendlyId { get; private set; }

		public string RenderingSlotId { get; private set; }

		public void ToggleSlotIndicator(bool enable)
		{
		}

		public void PlaySqueezeTween()
		{
		}

		private void OnDestroy()
		{
		}

		public void ToggleModelIndicator(bool enable)
		{
		}

		public void Render(BackpackItemSlot slot)
		{
		}

		private static BackpackItemSlotVisualData GetVisualData(string friendlyId)
		{
			return null;
		}
	}
}
