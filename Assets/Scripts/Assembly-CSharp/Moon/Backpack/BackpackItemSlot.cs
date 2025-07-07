using UnityEngine;

namespace Moon.Backpack
{
	public class BackpackItemSlot : MonoBehaviour
	{
		[SerializeField]
		private string _slotId;

		private int _currentAmount;

		private int _borrowedAmount;

		public string SlotId => null;

		public bool HasItem => false;

		public int CurrentInteractingAmount => 0;

		public int CurrentAmount => 0;

		public string FriendlyId { get; private set; }

		public string StackId { get; private set; }

		public void SetStackId(string backpackName)
		{
		}

		public void SetSlotData(string friendlyId, int amount)
		{
		}

		private void SetAmount(int amount)
		{
		}

		public void AddOne()
		{
		}

		public void TakeoutOne()
		{
		}

		public void Cleanup()
		{
		}

		public void BorrowOne()
		{
		}

		public void ReturnOne()
		{
		}
	}
}
