using System;
using Moon.Shop;

namespace Moon
{
	[Serializable]
	public class ConsumableItemData : BaseItemData
	{
		public int Amount { get; set; }

		public int Price => 0;
	}
}
