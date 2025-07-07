using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGPathSegCurvetoQuadraticSmoothAbs : SVGPathSegCurvetoQuadratic
	{
		protected Vector2 _controlPoint1;

		public override Vector2 controlPoint1 => default(Vector2);

		public SVGPathSegCurvetoQuadraticSmoothAbs(float x, float y, SVGPathSeg segment)
		{
		}
	}
}
