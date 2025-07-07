using System.Collections.Generic;
using Moon.Shop.TryOn;
using UnityEngine;

namespace Moon.Shop
{
	public class CustomTryMeProductDataProvider : MonoBehaviour
	{
		[SerializeField]
		private ShopCustomTryMeProductData[] _tryMeProductDataList;

		public IReadOnlyList<ShopCustomTryMeProductData> TryMeProductDataList => null;
	}
}
