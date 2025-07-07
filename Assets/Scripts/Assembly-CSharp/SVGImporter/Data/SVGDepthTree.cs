using SVGImporter.Utils;
using UnityEngine;

namespace SVGImporter.Data
{
	public class SVGDepthTree
	{
		protected QuadTree<int> quadTree;

		public SVGDepthTree(SVGBounds bounds)
		{
		}

		public SVGDepthTree(Rect bounds)
		{
		}

		public int[] TestDepthAdd(int node, SVGBounds bounds)
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
