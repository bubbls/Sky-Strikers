using System.Collections.Generic;
using Chamber8.Framework.Service.PlayFab.PlayerInventory;
using Moon.Economy;
using UnityEngine;

namespace Moon.Backpack
{
	public class BackpackItemSlotsController : MonoBehaviour
	{
		[SerializeField]
		private List<BackpackItemSlot> _slotsList;

		[SerializeField]
		private GameObject _container;

		private PlayerEconomy _playerEconomy;

		public List<BackpackItemSlot> SlotsList => null;

		private void Awake()
		{
		}

		public void ToggleContainer(bool enable)
		{
		}

		public void SetupSlots(List<PlayFabPlayerInventoryItem> inventoryItems)
		{
		}

		public bool DropItemInSlot(MGrabbableBackpackItem itemToDrop, BackpackItemSlot targetSlot)
		{
			return false;
		}

		private static BackpackItemSlot FindClosestSlot(List<BackpackItemSlot> emptySlots, Vector3 position)
		{
			return null;
		}

		public void AddPendingTransfer(BackpackItemSlot fromSlot, BackpackItemSlot toSlot)
		{
		}

		private void UpdateSlot(BackpackItemSlot slot)
		{
		}
	}
}
