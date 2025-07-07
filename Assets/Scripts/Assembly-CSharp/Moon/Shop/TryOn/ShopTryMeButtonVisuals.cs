using UnityEngine;

namespace Moon.Shop.TryOn
{
	public class ShopTryMeButtonVisuals : MonoBehaviour
	{
		[SerializeField]
		private GameObject _tryMeModel;

		[SerializeField]
		private GameObject? _equipModel;

		[SerializeField]
		private GameObject? _equippedModel;

		[SerializeField]
		private GameObject[] _activeVisuals;

		public void Initialize()
		{
		}

		public void ToggleButtonState(ShopTryMeButton.TryMeButtonState state)
		{
		}
	}
}
