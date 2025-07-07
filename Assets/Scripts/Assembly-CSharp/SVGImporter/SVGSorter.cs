using UnityEngine;

namespace SVGImporter
{
	[ExecuteInEditMode]
	[AddComponentMenu("Rendering/SVG Sorter", 20)]
	public class SVGSorter : MonoBehaviour
	{
		public float depthOffset;

		public int layerIndex;

		public bool sort;

		private float zOffsetStart;

		private int layerIndexStart;

		public void Sort()
		{
		}

		private void SortRecursive(Transform transform, ref float zOffset, ref int layerIndex)
		{
		}
	}
}
