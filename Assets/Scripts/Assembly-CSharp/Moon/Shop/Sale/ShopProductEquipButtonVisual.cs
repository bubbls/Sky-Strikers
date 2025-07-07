using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Moon.Shop.Sale
{
	public class ShopProductEquipButtonVisual : MonoBehaviour
	{
		[SerializeField]
		private Image _frameImage;

		[SerializeField]
		private TMP_Text _messageText;

		[SerializeField]
		private TMP_Text _messageBackgroundText;

		[SerializeField]
		private Collider _buttonCollider;

		[SerializeField]
		private GameObject _uiContainer;

		[SerializeField]
		protected ShopSaleProductEquipButtonConfig _equipStateConfig;

		[SerializeField]
		protected ShopSaleProductEquipButtonConfig _equippedStateConfig;

		public void ToggleEquippableVisuals(bool isEquipped)
		{
		}

		protected void UpdateColor(Color frameColor)
		{
		}

		protected void UpdateText(string message, Color messageColor, Color messageBackgroundColor)
		{
		}

		public void ToggleButtonCollider(bool enable)
		{
		}

		public void ToggleUIContainer(bool enable)
		{
		}
	}
}
