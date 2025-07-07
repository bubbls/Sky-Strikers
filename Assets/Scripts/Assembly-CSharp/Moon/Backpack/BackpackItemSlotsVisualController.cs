using System.Collections.Generic;
using Moon.Interaction;
using UnityEngine;

namespace Moon.Backpack
{
	public class BackpackItemSlotsVisualController : MonoBehaviour
	{
		[SerializeField]
		private List<BackpackItemSlotVisual> _slotsVisualList;

		[SerializeField]
		private GameObject _container;

		private BackpackItemSlot _hoveringOnSlot;

		private BackpackItemSlot _lastGrabbingSlot;

		private BackpackItemSlotVisual _lastGrabbingSlotVisual;

		private BackpackItemSlotVisualData _lastGrabbingSlotVisualData;

		private GrabbableBackpackItemVisual _grabbedVisual;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void ToggleSlots(bool enable)
		{
		}

		private static BackpackItemSlotVisualData GetVisualData(string friendlyId)
		{
			return null;
		}

		public void RenderHoveringOnSlot(BackpackItemSlot slot, MGrabInteractor withInteractor)
		{
		}

		public void BackpackFull()
		{
		}

		public void RenderGrabbingSlot(BackpackItemSlot grabbingSlot, Vector3 position, Quaternion rotation, bool isLeft)
		{
		}

		private void RenderGrabbingSlotInternal(BackpackItemSlotVisualData visualData, Vector3 position, Quaternion rotation, bool isLeft)
		{
		}

		private static bool IsSameModel(BackpackItemSlotVisualData dataA, BackpackItemSlotVisualData dataB)
		{
			return false;
		}

		public void RenderSlots(IReadOnlyList<BackpackItemSlot> slots)
		{
		}
	}
}
