using System.Collections.Generic;

namespace SVGImporter.ClipperLib
{
	public class PolyTree : PolyNode
	{
		internal List<PolyNode> m_AllPolys;

		public int Total => 0;

		~PolyTree()
		{
		}

		public void Clear()
		{
		}

		public PolyNode GetFirst()
		{
			return null;
		}
	}
}
