namespace SVGImporter.Rendering
{
	public class SVGTransform
	{
		private SVGTransformMode _type;

		private SVGMatrix _matrix;

		private double _angle;

		public SVGMatrix matrix => default(SVGMatrix);

		public float angle => 0f;

		public SVGTransformMode type => default(SVGTransformMode);

		public SVGTransform()
		{
		}

		public SVGTransform(SVGMatrix matrix)
		{
		}

		public SVGTransform(string strKey, string strValue)
		{
		}

		public void SetMatrix(SVGMatrix matrix)
		{
		}

		public void SetTranslate(float tx, float ty)
		{
		}

		public void SetScale(float sx, float sy)
		{
		}

		public void SetRotate(float angle)
		{
		}

		public void SetRotate(float angle, float cx, float cy)
		{
		}

		public void SetSkewX(float angle)
		{
		}

		public void SetSkewY(float angle)
		{
		}
	}
}
