using UnityEngine;

namespace SVGImporter.Rendering
{
	public class SVGPathSegCurvetoQuadraticRel : SVGPathSegCurvetoQuadratic
	{
		protected Vector2 _controlPoint1;

		public override Vector2 controlPoint1 => default(Vector2);

		public SVGPathSegCurvetoQuadraticRel(float x1, float y1, float x, float y, SVGPathSeg segment)
		{
		}
	}
}
