using UnityEngine;

namespace Moon.GameActivity
{
	[CreateAssetMenu(fileName = "ActivityStoreItemDefinition", menuName = "Moon/Shop/Create ActivityStoreItemDefinition")]
	public abstract class ActivityStoreItemDefinition : ScriptableObject
	{
		[SerializeField]
		private ActivityStoreProductData _productData;

		public ActivityStoreProductData ProductData => null;
	}
}
