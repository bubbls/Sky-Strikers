using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.Arena;
using Moon.MultiPlay;
using Moon.Shop;
using UnityEngine;

namespace Moon.Class
{
	public abstract class PlayerCustomizationPanel : MonoBehaviour
	{
		private static readonly Dictionary<Rarity, int> _rarityOrder;

		[SerializeField]
		private PlayerCustomizationPanelPage[] _pages;

		[SerializeField]
		private PlayerCustomizationNavigationPanel _navigationPanel;

		[SerializeField]
		private int _slotsPerPage;

		private List<PlayerCustomizationPageSlotData> _slotsData;

		private List<PlayerCustomizationPageSlotData> _curPageSlotsData;

		private IMessageSubscriber[] _subscribers;

		private int _currentPanelPageIndex;

		private bool _canUpdatePanel;

		protected void Start()
		{
		}

		protected abstract void InitializeInternal();

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected abstract void OnDestroyInternal();

		private int HandlePlayerLocationChangedMessage(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		private int HandlePlayerVisualsChanged(IMessage<PlayerVisualsChangedMessage> message)
		{
			return 0;
		}

		private int HandleOnPlayerInfoUpdated(IMessage<PlayerInfoChangedMessage> message)
		{
			return 0;
		}

		protected abstract void HandleOnPlayerInfoUpdated(PlayerInfo oldPlayerInfo, PlayerInfo newPlayerInfo);

		private void HandlePurchasedSkusUpdated()
		{
		}

		protected abstract List<PlayerCustomizationPageSlotData> GetFilteredItemsToDisplay();

		protected PlayerCustomizationPageSlotData GenerateSlotData(PlayerCustomizationSlotType slotType, SkuData skuData, IPlayerVisualsPreset preset, int visualTheme, Sprite[] slotIcons)
		{
			return default(PlayerCustomizationPageSlotData);
		}

		protected void ReconfigureUI()
		{
		}

		private void NavigationPanel_OnPageChanged()
		{
		}

		private void UpdatePageContent()
		{
		}

		protected void UpdateSlotsTeamColor(TeamNo teamNo)
		{
		}

		protected abstract void Page_OnSlotSelected(PlayerCustomizationPageSlotData slotData);

		protected static List<PlayerCustomizationPageSlotData> SortPageSlotData(List<PlayerCustomizationPageSlotData> productsToShow)
		{
			return null;
		}
	}
}
