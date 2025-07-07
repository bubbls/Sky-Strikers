using System.Collections.Generic;
using SVGImporter.Document;

namespace SVGImporter.Rendering
{
	public class SVGGradientElement
	{
		private SVGGradientUnit _gradientUnits;

		private SVGSpreadMethod _spreadMethod;

		private SVGTransformList _gradientTransform;

		private string _id;

		private SVGParser _xmlImp;

		private List<SVGStopElement> _stopList;

		protected AttributeList _attrList;

		public SVGGradientUnit gradientUnits => default(SVGGradientUnit);

		public SVGSpreadMethod spreadMethod => default(SVGSpreadMethod);

		public string id => null;

		public List<SVGStopElement> stopList => null;

		public SVGTransformList gradientTransform => null;

		public SVGGradientElement(SVGParser xmlImp, Node node)
		{
		}

		protected void GetElementList()
		{
		}

		public SVGStopElement GetStopElement(int i)
		{
			return null;
		}
	}
}
