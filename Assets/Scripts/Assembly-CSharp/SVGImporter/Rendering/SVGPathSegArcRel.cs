namespace SVGImporter.Rendering
{
	public class SVGPathSegArcRel : SVGPathSeg
	{
		private float _r1;

		private float _r2;

		private float _angle;

		private bool _largeArcFlag;

		private bool _sweepFlag;

		public float r1 => 0f;

		public float r2 => 0f;

		public float angle => 0f;

		public bool largeArcFlag => false;

		public bool sweepFlag => false;

		public SVGPathSegArcRel(float r1, float r2, float angle, bool largeArcFlag, bool sweepFlag, float x, float y, SVGPathSeg segment)
		{
		}
	}
}
