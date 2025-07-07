using SVGImporter.Document;
using SVGImporter.Utils;

namespace SVGImporter.Rendering
{
	public class SVGStopElement
	{
		private float _offset;

		private SVGColor _stopColor;

		public float offset => 0f;

		public SVGColor stopColor => default(SVGColor);

		public SVGStopElement(AttributeList attrList)
		{
		}
	}
}
