using UnityEngine;

namespace SVGImporter.Utils
{
	public struct SVGColor
	{
		public SVGColorType colorType;

		public Color color;

		public SVGColor(string colorString)
		{
			colorType = default(SVGColorType);
			color = default(Color);
		}
	}
}
