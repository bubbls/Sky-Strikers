using UnityEngine;

namespace Moon.Backpack
{
	[CreateAssetMenu(fileName = "BackpackItemSlotVisualDataDefinition", menuName = "Moon/Backpack/Create BackpackItemSlotVisualDataDefinition")]
	public class BackpackItemSlotVisualDataDefinition : ScriptableObject
	{
		[SerializeField]
		private BackpackItemSlotVisualData _visualData;

		public BackpackItemSlotVisualData VisualData => null;
	}
}
