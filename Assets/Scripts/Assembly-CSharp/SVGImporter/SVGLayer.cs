using System;

namespace SVGImporter
{
	[Serializable]
	public struct SVGLayer
	{
		public string name;

		public SVGShape[] shapes;

		public SVGLayer Clone()
		{
			return default(SVGLayer);
		}
	}
}
