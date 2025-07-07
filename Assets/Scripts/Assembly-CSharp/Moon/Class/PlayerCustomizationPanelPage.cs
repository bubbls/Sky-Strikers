using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Moon.Arena;
using UnityEngine;

namespace Moon.Class
{
	public class PlayerCustomizationPanelPage : MonoBehaviour
	{
		[SerializeField]
		protected PlayerCustomizationPageSlot[] _slots;

		public event Action<PlayerCustomizationPageSlotData> OnSlotSelected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Initialize()
		{
		}

		private void Slot_OnSlotSelected(PlayerCustomizationPageSlotData slotData)
		{
		}

		public void ShowPage(List<PlayerCustomizationPageSlotData> slotsData, TeamNo playerTeamNo)
		{
		}

		public void UpdateSlotsSelectedState(PlayerVisualsConfig visualsConfig)
		{
		}

		public void HidePage()
		{
		}

		public void Unload()
		{
		}

		public void UpdateSlotsTeamColor(TeamNo teamNo)
		{
		}
	}
}
