using System.Collections.Generic;
using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.GameActivity
{
	[CreateAssetMenu(fileName = "ActivityStoreItemDefinitionsLookup", menuName = "Moon/Shop/Create ActivityStoreItemDefinitionsLookup")]
	public class ActivityStoreItemDefinitionsLookup : SingleScriptableObject<ActivityStoreItemDefinitionsLookup, DefaultResourcePathProvider<ActivityStoreItemDefinitionsLookup>>
	{
		[SerializeField]
		private List<ActivityStoreItemDefinition> _productDataDefinitions;
	}
}
