using SVGImporter.Document;
using SVGImporter.Utils;

namespace SVGImporter.Rendering
{
	public class SVGLinearGradientElement : SVGGradientElement
	{
		private SVGLength _x1;

		private SVGLength _y1;

		private SVGLength _x2;

		private SVGLength _y2;

		public SVGLength x1 => default(SVGLength);

		public SVGLength y1 => default(SVGLength);

		public SVGLength x2 => default(SVGLength);

		public SVGLength y2 => default(SVGLength);

		public SVGLinearGradientElement(SVGParser xmlImp, Node node)
			: base(null, null)
		{
		}
	}
}
