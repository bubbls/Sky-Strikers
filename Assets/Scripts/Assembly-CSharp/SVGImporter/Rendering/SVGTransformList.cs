using System.Collections.Generic;

namespace SVGImporter.Rendering
{
	public class SVGTransformList
	{
		private List<SVGTransform> _listTransform;

		public int Count => 0;

		public SVGMatrix totalMatrix => default(SVGMatrix);

		public SVGTransform this[int index] => null;

		public SVGTransformList()
		{
		}

		public SVGTransformList(int capacity)
		{
		}

		public SVGTransformList(string listString)
		{
		}

		public void Clear()
		{
		}

		public void AppendItem(SVGTransform newItem)
		{
		}

		public void AppendItemAt(SVGTransform newItem, int index)
		{
		}

		public void AppendItems(SVGTransformList newListItem)
		{
		}

		public void AppendItemsAt(SVGTransformList newListItem, int index)
		{
		}

		public SVGTransform Consolidate()
		{
			return null;
		}
	}
}
