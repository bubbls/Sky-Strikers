using System;
using System.Collections.Generic;
using Chamber8.Framework.Messaging;
using Moon.MultiPlay;
using TMPro;
using UnityEngine;

namespace Moon.Class
{
	public class PlayerCustomizationSuitAndWeaponPanel : PlayerCustomizationPanel
	{
		[Flags]
		private enum ActiveFilters
		{
			Suits = 1,
			Weapons = 2,
			All = 3
		}

		[SerializeField]
		private TMP_Text _titleText;

		[SerializeField]
		private PlayerCustomizationFilterButton _suitsButton;

		[SerializeField]
		private PlayerCustomizationFilterButton _weaponsButton;

		private IMessageSubscriber[] _subscribers;

		private ActiveFilters _activeFilters;

		protected override void InitializeInternal()
		{
		}

		protected override void OnDestroyInternal()
		{
		}

		private int HandleMPlayerSpawnedMessage(IMessage<MPlayer> message)
		{
			return 0;
		}

		protected override void HandleOnPlayerInfoUpdated(PlayerInfo oldPlayerInfo, PlayerInfo newPlayerInfo)
		{
		}

		private void SetClassTitle(PlayerSuitClass suitClass)
		{
		}

		private void HandleOnButtonPressed(ActiveFilters filterToCheck, PlayerCustomizationFilterButton buttonToSelect)
		{
		}

		private void ShowAllButtonsAsDeselected()
		{
		}

		protected override List<PlayerCustomizationPageSlotData> GetFilteredItemsToDisplay()
		{
			return null;
		}

		protected override void Page_OnSlotSelected(PlayerCustomizationPageSlotData slotData)
		{
		}
	}
}
