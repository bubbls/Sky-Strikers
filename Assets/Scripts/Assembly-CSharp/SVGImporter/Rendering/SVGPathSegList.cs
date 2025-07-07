using System.Collections.Generic;

namespace SVGImporter.Rendering
{
	public class SVGPathSegList
	{
		private List<object> _segList;

		public int Count => 0;

		public SVGPathSegList(int size)
		{
		}

		public void Clear()
		{
		}

		public SVGPathSeg GetItem(int index)
		{
			return null;
		}

		public SVGPathSeg GetLastItem()
		{
			return null;
		}

		public SVGPathSeg AppendItem(SVGPathSeg newItem)
		{
			return null;
		}

		internal SVGPathSeg GetPreviousSegment(int index)
		{
			return null;
		}

		private void SetList(SVGPathSeg newItem)
		{
		}
	}
}
