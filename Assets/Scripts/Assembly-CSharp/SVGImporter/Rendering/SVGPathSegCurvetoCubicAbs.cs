using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGPathSegCurvetoCubicAbs : SVGPathSegCurvetoCubic
	{
		protected Vector2 _controlPoint1;

		protected Vector2 _controlPoint2;

		public override Vector2 controlPoint1 => default(Vector2);

		public override Vector2 controlPoint2 => default(Vector2);

		public SVGPathSegCurvetoCubicAbs(float x1, float y1, float x2, float y2, float x, float y, SVGPathSeg segment)
		{
		}
	}
}
