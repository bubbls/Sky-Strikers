using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGPathSegCurvetoCubicSmoothRel : SVGPathSegCurvetoCubic
	{
		protected Vector2 _controlPoint1;

		protected Vector2 _controlPoint2;

		public override Vector2 controlPoint1 => default(Vector2);

		public override Vector2 controlPoint2 => default(Vector2);

		public SVGPathSegCurvetoCubicSmoothRel(float x2, float y2, float x, float y, SVGPathSeg segment)
		{
		}
	}
}
