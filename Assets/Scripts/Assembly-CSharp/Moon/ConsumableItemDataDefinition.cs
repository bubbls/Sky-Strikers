using UnityEngine;

namespace Moon
{
	[CreateAssetMenu(fileName = "ConsumableItemDataDefinition", menuName = "Moon/Shop/Create ConsumableItemDataDefinition")]
	public class ConsumableItemDataDefinition : ScriptableObject
	{
		[SerializeField]
		private ConsumableItemData _data;

		public ConsumableItemData Data => null;
	}
}
