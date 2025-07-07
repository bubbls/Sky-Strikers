using SVGImporter.Document;
using SVGImporter.Utils;

namespace SVGImporter.Rendering
{
	public class SVGRadialGradientElement : SVGGradientElement
	{
		private SVGLength _cx;

		private SVGLength _cy;

		private SVGLength _r;

		private SVGLength _fx;

		private SVGLength _fy;

		public SVGLength cx => default(SVGLength);

		public SVGLength cy => default(SVGLength);

		public SVGLength r => default(SVGLength);

		public SVGLength fx => default(SVGLength);

		public SVGLength fy => default(SVGLength);

		public SVGRadialGradientElement(SVGParser xmlImp, Node node)
			: base(null, null)
		{
		}
	}
}
