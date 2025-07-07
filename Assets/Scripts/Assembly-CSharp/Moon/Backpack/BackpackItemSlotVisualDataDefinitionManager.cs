using System.Collections.Generic;
using Chamber8.Framework.Common;
using UnityEngine;

namespace Moon.Backpack
{
	[CreateAssetMenu(fileName = "BackpackItemSlotVisualDataDefinitionManager", menuName = "Moon/Backpack/Create BackpackItemSlotVisualDataDefinitionManager")]
	public class BackpackItemSlotVisualDataDefinitionManager : SingleScriptableObject<BackpackItemSlotVisualDataDefinitionManager, DefaultResourcePathProvider<BackpackItemSlotVisualDataDefinitionManager>>
	{
		[SerializeField]
		private List<BackpackItemSlotVisualDataDefinition> _visualDataDefinitionList;

		private Dictionary<string, BackpackItemSlotVisualData> _visualDataLookup;

		public Dictionary<string, BackpackItemSlotVisualData> VisualDataLookup => null;
	}
}
