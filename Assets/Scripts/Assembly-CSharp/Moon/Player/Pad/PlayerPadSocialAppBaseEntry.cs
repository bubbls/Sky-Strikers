using UnityEngine;

namespace Moon.Player.Pad
{
	public abstract class PlayerPadSocialAppBaseEntry : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rectTransform;

		[SerializeField]
		private BoxCollider _boxCollider;

		private bool _shouldEnableBoxCollider;

		public string PlayFabId { get; protected set; }

		public void ToggleUI(bool enable)
		{
		}

		public void ToggleButtonInteraction(bool enable)
		{
		}
	}
}
