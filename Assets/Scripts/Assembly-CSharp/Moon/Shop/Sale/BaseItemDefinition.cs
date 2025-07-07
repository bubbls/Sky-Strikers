using NaughtyAttributes;
using UnityEngine;

namespace Moon.Shop.Sale
{
	public class BaseItemDefinition : ScriptableObject
	{
		[SerializeReference]
		protected BaseItemData _itemData;

		public BaseItemData ItemData => null;

		[Button(null, EButtonEnableMode.Always)]
		protected virtual void CreateNewItemData()
		{
		}
	}
}
