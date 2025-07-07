using Chamber8.Framework.Messaging;
using DP.Takeaway.Sound;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Shop.Sale
{
	[RequireComponent(typeof(SoundPlayerStub))]
	public class ShopProductEquipButton : MonoBehaviour
	{
		[SerializeField]
		private bool _autoEnterEquippableState;

		[SerializeField]
		private ShopProductEquipButtonVisual _visual;

		private IMessageSubscriber[] _subscribers;

		[SerializeField]
		private SoundPlayerStub _soundPlayerStub;

		protected ShopProductEquipButtonVisual Visual => null;

		protected ShopSaleProductData ProductData { get; set; }

		public void Initialize(ShopSaleProductData productData)
		{
		}

		public virtual void HandleOnProductDataUpdated(ShopSaleProductData productData, bool isPurchased)
		{
		}

		public void EnableEquippableState()
		{
		}

		public void HideUI()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private int HandlePlayerInfoChanged(IMessage<PlayerInfoChangedMessage> playerInfoChangedMessage)
		{
			return 0;
		}

		private int HandlePlayerInventoryUpdated(IMessage<object> arg)
		{
			return 0;
		}

		protected virtual void UpdateButtonsEquippedState()
		{
		}

		protected void EnableSoundPlayback()
		{
		}

		protected void DisableSoundPlayback()
		{
		}
	}
}
