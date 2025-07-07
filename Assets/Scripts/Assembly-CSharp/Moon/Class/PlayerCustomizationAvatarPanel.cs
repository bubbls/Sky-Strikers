using System;
using System.Collections.Generic;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon.Class
{
	public class PlayerCustomizationAvatarPanel : PlayerCustomizationPanel
	{
		[Flags]
		private enum ActiveFilters
		{
			Backpack = 1,
			Head = 2,
			Body = 4,
			Leg = 8,
			NameTag = 0x10,
			All = 0x1F
		}

		[SerializeField]
		private PlayerCustomizationFilterButton _backpackButton;

		[SerializeField]
		private PlayerCustomizationFilterButton _headButton;

		[SerializeField]
		private PlayerCustomizationFilterButton _bodyButton;

		[SerializeField]
		private PlayerCustomizationFilterButton _legButton;

		[SerializeField]
		private PlayerCustomizationFilterButton _nameTagButton;

		private ActiveFilters _activeFilters;

		protected override void InitializeInternal()
		{
		}

		protected override void OnDestroyInternal()
		{
		}

		private void HandleOnButtonPressed(ActiveFilters filterToCheck, PlayerCustomizationFilterButton buttonToSelect)
		{
		}

		private void ShowAllButtonsAsDeselected()
		{
		}

		protected override void HandleOnPlayerInfoUpdated(PlayerInfo oldPlayerInfo, PlayerInfo newPlayerInfo)
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
