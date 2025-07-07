using UnityEngine;

namespace SVGImporter.Rendering
{
	public abstract class SVGPathSeg
	{
		protected SVGPathSegTypes _type;

		protected int _index;

		protected SVGPathSeg _prevSeg;

		protected Vector2 _currentPoint;

		protected Vector2 _previousPoint;

		protected SVGPathSegList _segList;

		public SVGPathSegTypes type => default(SVGPathSegTypes);

		public int index => 0;

		public SVGPathSeg previousSeg => null;

		public Vector2 currentPoint => default(Vector2);

		public Vector2 previousPoint => default(Vector2);

		public int SetIndex(int value)
		{
			return 0;
		}

		public void SetPosition(Vector2 value)
		{
		}

		public void SetPreviousSegment(SVGPathSeg prevSeg)
		{
		}

		internal void SetList(SVGPathSegList segList)
		{
		}
	}
}
