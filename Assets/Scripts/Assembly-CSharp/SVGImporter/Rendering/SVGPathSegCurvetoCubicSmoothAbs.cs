using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGPathSegCurvetoCubicSmoothAbs : SVGPathSegCurvetoCubic
	{
		protected Vector2 _controlPoint1;

		protected Vector2 _controlPoint2;

		public override Vector2 controlPoint1 => default(Vector2);

		public override Vector2 controlPoint2 => default(Vector2);

		public SVGPathSegCurvetoCubicSmoothAbs(float x2, float y2, float x, float y, SVGPathSeg segment)
		{
		}
	}
}
