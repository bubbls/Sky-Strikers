using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGPathSegCurvetoQuadraticSmoothRel : SVGPathSegCurvetoQuadratic
	{
		protected Vector2 _controlPoint1;

		public override Vector2 controlPoint1 => default(Vector2);

		public SVGPathSegCurvetoQuadraticSmoothRel(float x, float y, SVGPathSeg segment)
		{
		}
	}
}
