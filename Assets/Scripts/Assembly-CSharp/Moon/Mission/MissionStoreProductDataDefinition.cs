using UnityEngine;

namespace Moon.Mission
{
	[CreateAssetMenu(fileName = "MissionStoreProductDataDefinition", menuName = "Moon/Mission/Create MissionStoreProductDataDefinition")]
	public class MissionStoreProductDataDefinition : ScriptableObject
	{
		[SerializeField]
		private MissionStoreProductData _productData;

		public MissionStoreProductData ProductData => null;
	}
}
