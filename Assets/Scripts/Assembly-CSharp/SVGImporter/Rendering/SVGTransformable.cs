using SVGImporter.Document;
using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGTransformable
	{
		private SVGTransformList _inheritTransformList;

		private SVGTransformList _currentTransformList;

		private SVGTransformList _summaryTransformList;

		public SVGTransformList inheritTransformList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SVGTransformList currentTransformList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SVGTransformList summaryTransformList => null;

		public float transformAngle => 0f;

		public SVGMatrix transformMatrix => default(SVGMatrix);

		public SVGTransformable(SVGTransformList transformList)
		{
		}

		public static SVGMatrix GetRootViewBoxTransform(AttributeList attributeList, ref Rect viewport)
		{
			return default(SVGMatrix);
		}

		public static SVGMatrix GetViewBoxTransform(AttributeList attributeList, ref Rect viewport, bool negotiate = false)
		{
			return default(SVGMatrix);
		}
	}
}
